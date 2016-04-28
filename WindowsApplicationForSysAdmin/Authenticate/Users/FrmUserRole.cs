using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNet.Identity;
using ServiceLayer.Authentication.Role.Manager;
using ServiceLayer.Authentication.User.Manager;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace WindowsApplicationForSysAdmin.Authenticate.Users
{
    public partial class FrmUserRole : Telerik.WinControls.UI.RadForm
    {

        private readonly IApplicationUserManager _userManager;
        private readonly IApplicationRoleManager _roleManager;
        public FrmUserRole(IApplicationUserManager userManager,IApplicationRoleManager roleManager)
        {
            InitializeComponent();
            _userManager = userManager;
            _roleManager = roleManager;
        }

     

        #region Form UI Events
        private void FrmUserRole_Load(object sender, EventArgs e)
        {
            LoadAllRole();
        }
        
        private void dgUserList_CellClick(object sender, GridViewCellEventArgs e)
        {
            var userId = dgUserList.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            lblUserId.Text = userId;

            LoadUserRole(Guid.Parse(userId));
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            FillDgUser(txtSearchUserName.Text);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForSave()) return;
            var resultList=await  SaveUserToRoles(Guid.Parse(lblUserId.Text));

            var completeSave = true;
            foreach (var identityResult in resultList)
            {
                if (!identityResult.Succeeded)
                {
                    completeSave = false;
                    ShowLog(identityResult.Errors.First() + Environment.NewLine);
                }
            }


            if(completeSave) ShowLog("تغییرات با موفقیت ذخیره شد");

        }

        #endregion Form UI Events



        #region Load User Roles

        private void LoadAllRole()
        {
            var roles = _roleManager.Roles.ToList();
            foreach (var role in roles)
            {
                var x = new RadCheckBox()
                {
                    Name = string.Format("chk{0}", role.Name),
                    Text = role.Name,
                    Checked = false,
                };

                panelRoles.Controls.Add(x);
            }


        }
        private async void LoadUserRole(Guid userId)
        {
            foreach (RadCheckBox roleBox in panelRoles.Controls)
            {
                var existResult = await _userManager.IsInRoleAsync(userId, roleBox.Text);

                roleBox.Checked = existResult;


            }
        }

        #endregion Load User Roles

        #region Load User

        private void FillDgUser(string userName = "")
        {



            var query = _userManager.Users.Select(s => new
            {
                s.Id,
                //s.Employee.FirstName,
                //s.Employee.LastName,
                s.UserName,
                s.IsActive,
                s.PhoneNumber,

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
            dgUserList.Columns["Id"].IsVisible = false;
            dgUserList.Columns["IsActive"].HeaderText = @"فعال";
            dgUserList.Columns["IsActive"].Width = 50;
            dgUserList.Columns["UserName"].HeaderText = @"نام کاربری";
            dgUserList.Columns["UserName"].Width = 180;
            dgUserList.Columns["PhoneNumber"].HeaderText = @"شماره تماس";
            //dgUserList.Columns["FirstName"].HeaderText = @"نام";
            //dgUserList.Columns["LastName"].HeaderText = @"نام خانوادگی";

        }


        #endregion Load User

        #region Form Functions

        private void ShowLog(string msg)
        {
            txtInfo.Text = string.Empty;
            txtInfo.Text = string.Format(msg);
        }

        #endregion Form Functions

        #region Save


        private async Task<List<IdentityResult>> SaveUserToRoles(Guid userId)
        {


            var resultList = new List<IdentityResult>();
            
            foreach (RadCheckBox roleBox in panelRoles.Controls)
            {

                if (roleBox.Checked)
                {

                    //اگر عضو گروه تیک خورده نبود ذخیره شود
                    if (!await  _userManager.IsInRoleAsync(userId, roleBox.Text))
                    {
                        resultList.Add(await _userManager.AddToRoleAsync(userId, roleBox.Text));
                    }
                }
                else
                {
                    //اگر عضو گروه تیک خورده بود  عضویت لغو گردد
                    if (await  _userManager.IsInRoleAsync(userId, roleBox.Text))
                    {
                        resultList.Add(await _userManager.RemoveFromRoleAsync(userId, roleBox.Text));
                    }
                    

                }
            }

            return resultList;

        }


        private bool ValidateForSave()
        {
            erp.Clear();

            if (lblUserId.Text.Length < 10)
            {
                erp.SetError(btnSearchUser,"انتخاب کاربر");
                return false;
            }
           return true;
        }

        #endregion Save






    }
}
