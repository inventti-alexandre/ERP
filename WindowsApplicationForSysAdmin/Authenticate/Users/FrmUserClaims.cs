using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using ServiceLayer.Authentication.User.Manager;
using Telerik.WinControls;

namespace WindowsApplicationForSysAdmin.Authenticate.Users
{
    public partial class FrmUserClaims : Telerik.WinControls.UI.RadForm
    {

        private readonly IApplicationUserManager _userManager;
        
        public FrmUserClaims(IApplicationUserManager userManager)
        {
            InitializeComponent();
            _userManager = userManager;
        }


        #region Form UI Events

        private void btnShow_Click(object sender, EventArgs e)
        {
            FillDgUser(txtSearchUserName.Text);
        }


        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateclaimInfo()) return;

            var result =await SaveClaim();

            if (result.Succeeded)
            {
                ShowLog("خصوصیت با موفقیت ذخیره شد");
            }
            else
            {
                ShowLog(result.Errors.First());
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblUserId.Text = string.Empty;
        }

        private void dgUserList_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            lblUserId.Text = dgUserList.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            LoadClaim(Guid.Parse(lblUserId.Text));

        }

        #endregion Form UI Events

        #region dgUser

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


        #endregion dgUser

         #region Load Claim

        private async void LoadClaim(Guid userId)
        {

            var claim= await _userManager.GetClaimsAsync(userId);

            dgClaim.DataSource = claim.Select(s=>new
            {
                
                s.Type,
                s.Value,
            });

            SetDgClaimHeaders();
            dgClaim.Refresh();
        }


        private void SetDgClaimHeaders()
        {
            dgClaim.Columns["Type"].HeaderText = @"نوع";
            dgClaim.Columns["Value"].HeaderText = @"مقدار";
        }

        #endregion Load Claim

        #region Save Claim



        private async Task<IdentityResult> SaveClaim()
        {


            var userId = Guid.Parse(lblUserId.Text);

            var newClaim = new Claim(txtClaimType.Text.Trim(), txtClaimName.Text.Trim());


            
            
            return await _userManager.AddClaimAsync(userId, newClaim);


        }

        private bool ValidateclaimInfo()
        {
            erp.Clear();


            if (string.IsNullOrEmpty(lblUserId.Text))
            {
                erp.SetError(dgUserList, "انتخاب کنید");
                return false;
            }
            
            
            if (string.IsNullOrEmpty(txtClaimName.Text))
            {
                erp.SetError(txtClaimName,"الزامی");
                return false;
            }

            if (string.IsNullOrEmpty(txtClaimType.Text))
            {
                erp.SetError(txtClaimType, "الزامی");
                return false;
            }

            return true;
        }


        #endregion Save Claim

        #region Form Functions

        private void ShowLog(string msg)
        {
            txtInfo.Text = string.Empty;
            txtInfo.Text = string.Format(msg);
        }

        #endregion Form Functions

        private void FrmUserClaims_Load(object sender, EventArgs e)
        {

        }

     

      




    }
}
