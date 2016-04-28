using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using ServiceLayer.Authentication.User.Manager;
using Telerik.WinControls;

namespace WindowsApplicationForSysAdmin
{
    public partial class FrmLogin : Telerik.WinControls.UI.RadForm
    {

        private readonly ApplicationUserManager _userManager;
        private  string _userId ;
        private  string _userName;
        
        public FrmLogin(ApplicationUserManager userManager)
        {
            InitializeComponent();
            _userManager = userManager;
        }


        #region Form UI

        private async void btnOk_Click(object sender, EventArgs e)
        {
            

            if (await VerifyUserNamePassword(txtUser.Text.Trim(), txtPass.Text))
            {
                var frm = new FrmMain(_userId,_userName);
                frm.Show();
                this.Hide();
            }
          
            



        }

        #endregion Form UI




        #region Login

      

        private async Task<bool> VerifyUserNamePassword(string userName, string password)
        {
            erp.Clear();

            if (string.IsNullOrEmpty(userName.Trim()))
            {
                erp.SetError(txtUser, "نام کاربری خود را وارد نمایید");
                return false;
            }

            if (string.IsNullOrEmpty(password.Trim()))
            {
                erp.SetError(txtPass, "گزرواژه خود را وارد نمایید");
                return false;
            }

            var result = await _userManager.FindAsync(userName, password);

            if (result == null)
            {
                erp.SetError(txtUser, "نام کاربری یا گزر واژه اشتباه است");
                return false;
            }

            _userId = result.Id.ToString();
            _userName = result.UserName;

            return true;

        }


        #endregion Login



    }
}
