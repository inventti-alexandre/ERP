using System;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainLayer.Authentication;
using Microsoft.AspNet.Identity;
using ServiceLayer.Authentication.User.Manager;

namespace WindowsApplicationForSysAdmin.Authenticate.Users
{
    public partial class FrmUsers : Telerik.WinControls.UI.RadForm
    {


        private readonly IApplicationUserManager _userManager;

        public FrmUsers(IApplicationUserManager userManager)
        {
            InitializeComponent();
            _userManager = userManager;
        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {

        }


        #region Form UI Events

        private void btnShow_Click(object sender, EventArgs e)
        {
            FillDgUser(txtSearchUserName.Text);
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FillDgUser(txtSearchUserName.Text);
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateUserInfo()) return;

            var result =await CreateNewUser();
            
            ShowLog(result.Succeeded
                ? "کاربر جدید با موفقیت به سامانه افزوده شد"
                : result.Errors.First().ToString(CultureInfo.InvariantCulture));
        }


        #endregion Form UI Events

        #region dgUser

        private void FillDgUser(string userName="")
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
            
            if  (!string.IsNullOrEmpty(userName))
            {
                query=query.Where(w => w.UserName.Contains(userName.Trim()));

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


        #endregion dgUser

        #region Save

        private async Task<IdentityResult> CreateNewUser()
        {

            var newUser = new ApplicationUser()
            {
                UserName = txtUserName.Text.Trim(),
                Email = txtMail.Text.Trim(),
                PhoneNumber = txtPhone.Text.Trim(),
                IsActive = true,
                
                

            };


            return  await _userManager.CreateAsync(newUser, txtPass.Text.Trim());

        }


        private bool ValidateUserInfo()
        {
            erp.Clear();



            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                erp.SetError(txtUserName, "نام کاربری اجباریست");
                return false;
            }

            if (txtPass.Text.Trim() != txtRePass.Text.Trim())
            {
                erp.SetError(txtRePass,"کلمه عبور یکسان نیست");
                return false;
            }



            return true;
        }

        #endregion Save

        #region Form Functions

        private void ShowLog(string msg)
        {
            txtInfo.Text = string.Empty;
            txtInfo.Text = string.Format(msg);
        }

        #endregion Form Functions



    }
}
