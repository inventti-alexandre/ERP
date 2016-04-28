using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainLayer.Authentication;
using Microsoft.AspNet.Identity;
using ServiceLayer.Authentication.Role.Manager;
using ServiceLayer.Authentication.User.Manager;
using Telerik.WinControls;

namespace WindowsApplicationForSysAdmin.Authenticate.Role
{
    public partial class FrmRole : Telerik.WinControls.UI.RadForm
    {



        private readonly IApplicationRoleManager _roleManager;
        

        public FrmRole(IApplicationRoleManager roleManager)
        {
            InitializeComponent();
            _roleManager = roleManager;
            
        }

       
        #region UI Events

        private void btnShow_Click(object sender, EventArgs e)
        {
            FillDgRole(txtSearchRole.Text);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidationRoleInfo()) return;


            var result = await Save();

            if (result.Succeeded)
            {
                ShowLog("نقش جدید با موفقیت به سامانه افزوده شد");
                FillDgRole();
            }
            else
            {
                ShowLog(result.Errors.First().ToString(CultureInfo.InvariantCulture));
            }



        }

        #endregion UI Events


        #region Load Data To Grid

        private void FillDgRole(string roleName = "")
        {



            var query = _roleManager.Roles.Select(s => new
            {
                s.Id,
                s.Name
            });

            if (!string.IsNullOrEmpty(roleName))
            {
                query = query.Where(w => w.Name.Contains(roleName.Trim()));

            }

            dgRole.DataSource = query.ToList();
            SetDgUserHeaders();
            dgRole.Refresh();

        }

        private void SetDgUserHeaders()
        {
            dgRole.Columns["Id"].IsVisible = false;

            dgRole.Columns["Name"].HeaderText = @"نقش";


        }


        #endregion Load Data To Grid



        #region Save Role


        private bool ValidationRoleInfo()
        {
            erp.Clear();

            if (txtRoleName.Text.Trim().Length < 4)
            {
                erp.SetError(txtRoleName,"انتخاب یک نام برای نقش اجباریست");
                return false;
            }

            return true;
        }

        private Task<IdentityResult> Save()
        {
            var newRole = new ApplicationRole()
            {
                Name = txtRoleName.Text.Trim()
            };

            return _roleManager.CreateAsync(newRole);

        }

        #endregion Save Role


        #region Form Functions

        private void ShowLog(string msg)
        {
            txtInfo.Text = string.Empty;
            txtInfo.Text = string.Format(msg);
        }

        #endregion Form Functions










    }
}
