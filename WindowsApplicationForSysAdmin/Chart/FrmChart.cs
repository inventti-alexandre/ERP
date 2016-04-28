using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainLayer.General;
using FrameWork.General;
using Microsoft.Owin.Security.Provider;
using ServiceLayer.Chart;
using ServiceLayer.General.Type;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace WindowsApplicationForSysAdmin.Chart
{
    public partial class FrmChart : Telerik.WinControls.UI.RadForm
    {
        private readonly ITypeService _typeManager;
        private readonly IChartService _chartManager;
        public FrmChart(ITypeService typeManager, IChartService chartManager)
        {
            InitializeComponent();
            _typeManager = typeManager;
            _chartManager = chartManager;
        }

        private void FrmChart_Load(object sender, EventArgs e)
        {


            LoadChartType();
            LoadChart();
        }



        #region Form UI

        private async void btnSave_Click(object sender, EventArgs e)
        {

            var selectedNode = tvChart.SelectedNode;

            if (selectedNode == null) return;

            var result = await CreateNewPartOfChart(Guid.Parse(selectedNode.Value.ToString()), Guid.Parse(ddlChartType.SelectedValue.ToString()));

            if (result.Success)
            {
                tvChart.SelectedNode.Nodes.Add(new RadTreeNode()
                {
                    Text = txtFolName.Text.Trim(),
                    Value = selectedNode.Value.ToString()
                });
            }
            else
            {
                MessageBox.Show("Save To DB Have Error");
            }





        }


        #endregion Form UI

        #region Save

        private Task<ServicesResult> CreateNewPartOfChart(Guid parrentId, Guid typeid)
        {
            var newchart = new DomainLayer.Chart.Chart
            {
                ChartId = Guid.NewGuid(),
                Name = txtFolName.Text.Trim(),
                ParentId = parrentId,
                TypeId = typeid,
                RegisterDate = DateTime.Now,
                RegisterDateSH = FrameWork.General.Date.Getdate(),
                IsActive = chkActive.Checked,
                OwnerUserId = new Guid(),

            };



            return _chartManager.CreateAsync(newchart);

        }

        #endregion Save

        #region Load Data
        
        private async void LoadChartType()
        {
            var x = await _typeManager.LoadWithGroupIdAsync(1);
            ddlChartType.DataSource = x;

            ddlChartType.ValueMember = "TypeId";
            ddlChartType.DisplayMember = "Subject";
            ddlChartType.Refresh();
        }
        private void LoadChart()
        {

            var root = _chartManager.LoadChart().Single(s => s.ParentId == null);

            var rootNode = new RadTreeNode()
            {
                Text = root.Name,
                Value = root.ChartId,
            };

            tvChart.Nodes.Add(RecLoadChart(rootNode));

        }
        private RadTreeNode RecLoadChart(RadTreeNode pnode)
        {
            var nodes = _chartManager.LoadChart().Where(s => s.ParentId ==Guid.Parse(pnode.Value.ToString()));
            foreach (var node in nodes)
            {
                
                var childNode = new RadTreeNode()
                    {
                        Text = node.Name,
                        Value = node.ChartId,
                        
                    };


                pnode.Nodes.Add(childNode);


                RecLoadChart(childNode);
            }

            return pnode;
        }


        #endregion Load Data








    }
}
