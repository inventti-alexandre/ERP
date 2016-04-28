using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainLayer.Authentication;
using Microsoft.AspNet.Identity;
using ServiceLayer.Authentication.Role.Manager;
using ServiceLayer.Authentication.User.Manager;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace WindowsApplicationForSysAdmin.Authenticate.Role
{
    public partial class FrmRoleUser : Telerik.WinControls.UI.RadForm
    {

        private readonly IApplicationRoleManager _roleManager;
        private readonly ApplicationUserManager _userManager;
        
        
        public FrmRoleUser(IApplicationRoleManager roleManager,ApplicationUserManager userManager)
        {
            InitializeComponent();

            _roleManager = roleManager;
            _userManager = userManager;
        }

        #region UI Events

        private void btnSearchRole_Click(object sender, EventArgs e)
        {
            FillDgRole(txtSearchRole.Text);
        }


        private void dgRole_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            
            var roleId= dgRole.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            var roleName= dgRole.Rows[e.RowIndex].Cells["Name"].Value.ToString();

            gbRoleUser.Text = string.Format("کاربران عضو در نقش {0}",roleName);

            btnAddMember.Text = string.Format("افزودن کاربر جدید");

            lblRoleId.Text = roleId;
            FillDgRoleUser(Guid.Parse(roleId));

        }



        private async void btnAddMember_Click(object sender, EventArgs e)
        {


            Boolean actionStatus = btnAddMember.Text == string.Format("ذخیره نقش کاربر");

            if (actionStatus)
            {
                var result=await SaveUserToRole();
                if (result.Succeeded)
                {
                    ShowLog("کاربر با موفقیت به نقش افزوده شد");
                }
                else
                {
                    ShowLog(result.Errors.First());
                }
            }
            else
            {
                if (lblRoleId.Text.Length < 10) return;
                FillDgUser();
                btnAddMember.Text = string.Format("ذخیره نقش کاربر");
                var roleName = gbRoleUser.Text.Split(' ')[4];
                gbRoleUser.Text = string.Format(" لیست تمام پرسنل برای افزودن در نقش {0}", roleName); 
            }

        }


        #endregion UI Events


        #region Load Role To Grid

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
            SetDgRoleHeaders();
            dgRole.Refresh();

        }

        private void SetDgRoleHeaders()
        {
            dgRole.Columns["Id"].IsVisible = false;

            dgRole.Columns["Name"].HeaderText = @"نقش";


        }


        #endregion Load Data To Grid


        #region Load User To Grid

        private async void  FillDgRoleUser(Guid roleId)
        {

            var role=await _roleManager.FindByIdAsync(roleId);
            var usersCollection =new List<ApplicationUser>() ;
            
            //foreach (var user in role.Users)
            //{
            //    var tempuser=await _userManager.FindByIdAsync(user.UserId);
            //    usersCollection.Add(tempuser);
               
            //}



            foreach (var user in _userManager.Users.ToList())
            {
                if (await _userManager.IsInRoleAsync(user.Id, role.Name))
                {
                    usersCollection.Add(user);
                }
            }




            dgRoleUser.DataSource = usersCollection.Select(s=>new
            {
                s.Id,
                //s.Employee.FirstName,
                //s.Employee.LastName,
                s.UserName,
                s.IsActive,
                s.PhoneNumber,
            });
            SetDgRoleUserHeaders();

        }
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

            if (!string.IsNullOrEmpty(userName))
            {
                query = query.Where(w => w.UserName.Contains(userName.Trim()));
            }



            dgRoleUser.DataSource = query.ToList();
            SetDgRoleUserHeaders();

        }
        private void SetDgRoleUserHeaders()
        {
            dgRoleUser.Columns["Id"].IsVisible = false;
            dgRoleUser.Columns["IsActive"].HeaderText = @"فعال";
            dgRoleUser.Columns["IsActive"].Width = 50;
            dgRoleUser.Columns["UserName"].HeaderText = @"نام کاربری";
            dgRoleUser.Columns["UserName"].Width = 180;
            dgRoleUser.Columns["PhoneNumber"].HeaderText = @"شماره تماس";
            //dgUserList.Columns["FirstName"].HeaderText = @"نام";
            //dgUserList.Columns["LastName"].HeaderText = @"نام خانوادگی";


        }



       

      

        #endregion Load Data To Grid


        #region Form Functions

        private void ShowLog(string msg)
        {
            txtInfo.Text = string.Empty;
            txtInfo.Text = string.Format(msg);
        }

        #endregion Form Functions


        #region Save User To Role


        private async Task<IdentityResult> SaveUserToRole()
        {
            foreach (var row in dgRoleUser.Rows)
            {
                if (Convert.ToBoolean(row.Cells["clmSelect"].Value))
                {
                    var userId = row.Cells["Id"].Value.ToString();
                    var roleName = gbRoleUser.Text.Split(' ')[8];

                   return await _userManager.AddToRolesAsync(Guid.Parse(userId), roleName);
                }

            }

            return new IdentityResult("No Select User");
        }

        #endregion Save User To Role



    }
}
