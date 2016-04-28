using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApplicationForSysAdmin.Authenticate.Role;
using WindowsApplicationForSysAdmin.Authenticate.Users;
using WindowsApplicationForSysAdmin.Chart;
using WindowsApplicationForSysAdmin.Employee;
using Microsoft.Owin.Security;
using ServiceLayer.Authentication.Role.Manager;
using ServiceLayer.Authentication.User.Manager;
using ServiceLayer.Chart;
using ServiceLayer.ChartEmployee;
using ServiceLayer.Employee;
using ServiceLayer.General.Type;

namespace WindowsApplicationForSysAdmin
{
    public partial class FrmMain : Form
    {

        private readonly string _userId ;
        private readonly string _userName;
        public FrmMain(string userId,string userName)
        {
            InitializeComponent();
            _userId = userId;
            _userName = userName;
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            SetFirstSetting();
        }

        
        
        #region User Menu

       
        private FrmUsers _formUser;
        private FrmUserRole _formUserRole;

        private void btnUsersNew_Click(object sender, EventArgs e)
        {
            if (_formUser == null)
            {
                //'Take Instance Of User Manager For Use in formuser
                var sharpUserManager = ObjectFactory.WinForm.WinFormAppObjectFactory.Container.GetInstance<ApplicationUserManager>();

                _formUser = new FrmUsers(sharpUserManager) { MdiParent = this, StartPosition = FormStartPosition.CenterScreen };
                _formUser.FormClosed += delegate
                {
                    _formUser = null;
                };
                _formUser.Show();
            }
            else
            {
                _formUser.Activate();
            }
        }
        private void btnUserRole_Click(object sender, EventArgs e)
        {
            if (_formUserRole == null)
            {
                //'Take Instance Of User Manager For Use in formUserRol 
                var sharpUserManager = ObjectFactory.WinForm.WinFormAppObjectFactory.Container.GetInstance<ApplicationUserManager>();
                
                //'Take Instance Of Role Manager For Use in formUserRol 
                var sharpRoleManager = ObjectFactory.WinForm.WinFormAppObjectFactory.Container.GetInstance<IApplicationRoleManager>();

                _formUserRole = new FrmUserRole(sharpUserManager, sharpRoleManager) { MdiParent = this, StartPosition = FormStartPosition.CenterScreen };
                _formUserRole.FormClosed += delegate
                {
                    _formUserRole = null;
                };
                _formUserRole.Show();
            }
            else
            {
                _formUser.Activate();
            }
        }

        #endregion  User Menu

        #region Role

        private FrmRole _formRole;
        private FrmRoleUser _formRoleUser;
        private void btnRoleNew_Click(object sender, EventArgs e)
        {
            if (_formRole == null)
            {
               
                //'Take Instance Of Role Manager For Use in formUserRol 
                var sharpRoleManager = ObjectFactory.WinForm.WinFormAppObjectFactory.Container.GetInstance<IApplicationRoleManager>();

                _formRole = new FrmRole(sharpRoleManager) { MdiParent = this, StartPosition = FormStartPosition.CenterScreen };
                _formRole.FormClosed += delegate
                {
                    _formRole = null;
                };
                _formRole.Show();
            }
            else
            {
                _formRole.Activate();
            }
        }

        private void btnRoleUser_Click(object sender, EventArgs e)
        {
            if (_formRoleUser == null)
            {
                //'Take Instance Of User Manager For Use in formUserRol 
                var sharpUserManager = ObjectFactory.WinForm.WinFormAppObjectFactory.Container.GetInstance<ApplicationUserManager>();

                //'Take Instance Of Role Manager For Use in formUserRol 
                var sharpRoleManager = ObjectFactory.WinForm.WinFormAppObjectFactory.Container.GetInstance<IApplicationRoleManager>();

                _formRoleUser = new FrmRoleUser(sharpRoleManager,sharpUserManager) { MdiParent = this, StartPosition = FormStartPosition.CenterScreen };
                _formRoleUser.FormClosed += delegate
                {
                    _formRoleUser = null;
                };
                _formRoleUser.Show();
            }
            else
            {
                _formRoleUser.Activate();
            }
        }

        
        #endregion Role

        #region Employee

        private FrmEmployee _formEmployee;
        private void btnEmployeeNew_Click(object sender, EventArgs e)
        {
            if (_formRole == null)
            {

                //'Take Instance Of Employee Manager For Use in ormEmployee 
                var sharpEmployeeManager = ObjectFactory.WinForm.WinFormAppObjectFactory.Container.GetInstance<IEmployeeService>();
                //'Take Instance Of User Manager For Use in formUserRol 
                var sharpUserManager = ObjectFactory.WinForm.WinFormAppObjectFactory.Container.GetInstance<ApplicationUserManager>();

                _formEmployee = new FrmEmployee(sharpUserManager,sharpEmployeeManager) { MdiParent = this, StartPosition = FormStartPosition.CenterScreen };
                _formEmployee.FormClosed += delegate
                {
                    _formEmployee = null;
                };
                _formEmployee.Show();
            }
            else
            {
                _formEmployee.Activate();
            }
        }
        
        #endregion Employee

        #region Chart

        private FrmChart _formChart;
        private FrmPrsRelationChart _formPrsRelationChart;
        
        private void btnChartNew_Click(object sender, EventArgs e)
        {
            if (_formChart == null)
            {

                var typeManager = ObjectFactory.WinForm.WinFormAppObjectFactory.Container.GetInstance<ITypeService>();
                var chartManager = ObjectFactory.WinForm.WinFormAppObjectFactory.Container.GetInstance<IChartService>();

                _formChart = new FrmChart(typeManager, chartManager) { MdiParent = this, StartPosition = FormStartPosition.CenterScreen };
                _formChart.FormClosed += delegate
                {
                    _formChart = null;
                };
                _formChart.Show();
            }
            else
            {
                _formChart.Activate();
            }
        }
        private void btnPrsRelationChart_Click(object sender, EventArgs e)
        {
            if (_formPrsRelationChart == null)
            {

                
                var chartManager = ObjectFactory.WinForm.WinFormAppObjectFactory.Container.GetInstance<IChartService>();
                var appChartEmployeerManager = ObjectFactory.WinForm.WinFormAppObjectFactory.Container.GetInstance<IChartEmployeeService>();
                var employeeManager = ObjectFactory.WinForm.WinFormAppObjectFactory.Container.GetInstance<IEmployeeService>();

                _formPrsRelationChart = new FrmPrsRelationChart(appChartEmployeerManager, employeeManager, chartManager) { MdiParent = this, StartPosition = FormStartPosition.CenterScreen };
                _formPrsRelationChart.FormClosed += delegate
                {
                    _formPrsRelationChart = null;
                };
                _formPrsRelationChart.Show();
            }
            else
            {
                _formPrsRelationChart.Activate();
            }
        }

        #endregion Chart




        private void SetFirstSetting()
        {
            txtUserName.Text = _userName;
            txtDateSH.Text = FrameWork.General.Date.Getdate();
            txtDateML.Text = FrameWork.General.Date.Getdate(false);

        }

     
      


    }
}
