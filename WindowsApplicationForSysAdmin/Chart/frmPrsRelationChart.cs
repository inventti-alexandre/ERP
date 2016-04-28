using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainLayer.General;
using ServiceLayer.Authentication.User.Manager;
using ServiceLayer.Chart;
using ServiceLayer.ChartEmployee;
using ServiceLayer.Employee;
using ServiceLayer.General.Type;
using Telerik.WinControls.UI;

namespace WindowsApplicationForSysAdmin.Chart
{
    public partial class FrmPrsRelationChart : Form
    {


        private readonly IChartService _chartManager;
        private readonly IChartEmployeeService _chartEmployeeManager;
        private readonly IEmployeeService _employeeManager;

        private string _chartId =string.Empty;
        private string _prsId = string.Empty;



        public FrmPrsRelationChart(IChartEmployeeService userManager,
            IEmployeeService employeeManager,
            IChartService chartManager)
        {
            
            InitializeComponent();

            _chartEmployeeManager = userManager;
            _employeeManager=employeeManager;
            _chartManager = chartManager;

        }

        private void frmPrsRelationChart_Load(object sender, EventArgs e)
        {
            LoadChart();
            FillDgUser();
            tvChart.ExpandAll();
        }


        #region LoadData
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
            var nodes = _chartManager.FindWithParrentId(Guid.Parse(pnode.Value.ToString()));
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

        private void FillDgUser(string userName = "")
        {



            var query = _employeeManager.GetAllEmployees().Select(s => new
            {
               s.AppUserId,
               s.FirstName,
               s.LastName,
               s.AppUser.UserName,
               s.AppUser.IsActive,
               s.AppUser.PhoneNumber
            });

           

            if (!string.IsNullOrEmpty(userName))
            {
                query = query.Where(w => w.UserName.Contains(userName.Trim()));

            }

            dgUserList.DataSource = query.ToList();
            SetDgUserHeaders();
            dgUserList.Refresh();

        }

        private void SetDgUserHeaders()
        {
            dgUserList.Columns["AppUserId"].IsVisible = false;
            dgUserList.Columns["IsActive"].HeaderText = @"فعال";
            dgUserList.Columns["IsActive"].Width = 50;
            dgUserList.Columns["UserName"].HeaderText = @"نام کاربری";
            dgUserList.Columns["UserName"].Width = 180;
            dgUserList.Columns["PhoneNumber"].HeaderText = @"شماره تماس";
            dgUserList.Columns["FirstName"].HeaderText = @"نام";
            dgUserList.Columns["LastName"].HeaderText = @"نام خانوادگی";

        }


        
        #endregion LoadData


        #region UI Events

        private void btnShow_Click(object sender, EventArgs e)
        {
            FillDgUser(txtUserName.Text);
        }

        private void tvChart_SelectedNodeChanged(object sender, RadTreeViewEventArgs e)
        {
            _chartId = e.Node.Value.ToString();

        }

        private void dgUserList_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            _prsId = dgUserList.Rows[e.RowIndex].Cells["AppUserId"].Value.ToString();


        }
        
        
        private async void btnSave_Click(object sender, EventArgs e)
        {

            var result = await JoinPrsToChart();
            if (result.Success)
            {
                MessageBox.Show(@"Yess");
            }
            else
            {
                MessageBox.Show(@"Noooo");
            }



        }

        #endregion UI Events

        private async Task<ServicesResult> JoinPrsToChart()
        {
            return await  _chartEmployeeManager.JoinPrsToChart(Guid.Parse(_prsId), Guid.Parse(_chartId));
            
           
        }

        #region Save Relation

      


        

        #endregion Save Relation




    }
}
