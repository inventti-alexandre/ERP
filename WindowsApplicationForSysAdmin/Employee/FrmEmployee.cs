using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainLayer.Employee;
using DomainLayer.General;
using ServiceLayer.Authentication.User.Manager;
using ServiceLayer.Employee;
using ServiceLayer.Employee;
using Telerik.WinControls;

namespace WindowsApplicationForSysAdmin.Employee
{
    public partial class FrmEmployee : Telerik.WinControls.UI.RadForm
    {

        private readonly IApplicationUserManager _userManager;
        private readonly IEmployeeService _employeeManager;


        public FrmEmployee(IApplicationUserManager userManager,IEmployeeService employeeManager)
        {
            InitializeComponent();
            
            _userManager = userManager;
            _employeeManager = employeeManager;
        }


        #region UI Events


        private void btnShow_Click(object sender, EventArgs e)
        {
            FillDgUser(txtUserName.Text);
        }

        private void txtSearchUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FillDgUser(txtUserName.Text);
            }
        }

        private  void dgUserList_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            Cleare(false);
            var userId = (Guid)dgUserList.Rows[e.RowIndex].Cells["Id"].Value;
          
            LoadEmployeeData(userId);

               

           
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cleare();
        }


        private async void btnSave_Click(object sender, EventArgs e)
        {
           
            
            if(!ValidateEmployeeInfo()) return;


            //آیا قبلا اطلاعات پرسنلی برای این کاربر تکمیل شده است یا خیر
            var isCompleteInfo=await _employeeManager.IsCompletMainInfo(Guid.Parse(lblUserId.Text));

            //تکمیل نشده است پس باید ثبت شود
            if (!isCompleteInfo)
            {
                var result = await CreateNewEmployee();
                ShowLog(result.Success
               ? "اطلاعات پرسنلی کاربر با موفقیت به سامانه افزوده شد"
               : string.Format("{0}{1}{2}", result.Message, Environment.NewLine, result.InnerExeption)
               );
            }
            //تکمیل شده است پس باید ویرایش شود
            else
            {
                var result = await UpdateEmployee(Guid.Parse(lblUserId.Text));
              
                ShowLog(result.Success
               ? "اطلاعات پرسنلی کاربر با موفقیت ویرایش شد"
               : string.Format("{0}{1}{2}", result.Message, Environment.NewLine, result.InnerExeption)
               );
            }


            Cleare();
        }

        #endregion UI Events


        #region dgUser

        private void FillDgUser(string userName = "")
        {



            var query = _userManager.Users.Select(s => new
            {
                s.Id,
                s.Employee.FirstName,
                s.Employee.LastName,
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
            dgUserList.Columns["FirstName"].HeaderText = @"نام";
            dgUserList.Columns["LastName"].HeaderText = @"نام خانوادگی";

        }





        #endregion dgUser


        #region Load Employee Data


        private void LoadEmployeeData(Guid userId)
        {

           

            var employee=_employeeManager.Find(userId);
            lblUserId.Text = userId.ToString();

            if (employee != null)
            {
               
             
                
                txtNationalCode.Text = employee.NationalId;
                txtNationalCode.Enabled = false;

                txtName.Text = employee.FirstName;
                txtFamily.Text = employee.LastName;
                txtFatherName.Text = employee.FatherName;
                txtBirthDate.Text = employee.BirthDay;

                gpEmployeeInfo.Text = string.Format("اطلاعات پرسنلی {0}", employee.FullName);

                ShowLog("اطلاعات پرسنلی برای این کاربر بارگزاری شد");
            }
            else
            {
               
                ShowLog("اطلاعات پرسنلی برای این کاربر هنوز ثبت نشده است");
            }

          
        }


        #endregion Load Employee Data

        #region Save Employee Data

        private async Task<ServicesResult> CreateNewEmployee()
        {
            
            
            
            
            
            var newEmployee = new DomainLayer.Employee.Employee()
            {
                AppUserId = Guid.Parse(lblUserId.Text),
                NationalId = txtNationalCode.Text,
                FirstName = txtName.Text,
                LastName = txtFamily.Text,
                FatherName = txtFatherName.Text,
                BirthDay = txtBirthDate.Text,
              
                
            };

            return await _employeeManager.CreateAsync(newEmployee);
        }

        private async Task<ServicesResult> UpdateEmployee(Guid userId)
        {

            var employee = _employeeManager.Find(userId);
            
            employee.FirstName = txtName.Text.Trim();
            employee.LastName = txtFamily.Text.Trim();
            employee.FatherName = txtFatherName.Text.Trim();
            employee.BirthDay = txtBirthDate.Text.Trim();

            return await _employeeManager.UpdateAsync(employee);
        }

        private bool ValidateEmployeeInfo()
        {
            erp.Clear();
            if (string.IsNullOrEmpty(txtNationalCode.Text.Trim()))
            {
                erp.SetError(txtNationalCode,"کد ملی اجباریست");
                return false;
            }
            
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                erp.SetError(txtName, "نام اجباریست");
                return false;
            }
            


            
            return true;
        }


        #endregion Save Employee Data

        #region Form Functions

        private void Cleare(bool reLoadUserList=true)
        {

            lblUserId.Text = string.Empty;
            txtNationalCode.Text = string.Empty;
            txtNationalCode.Enabled = true;
            txtName.Text = string.Empty;
            txtFamily.Text = string.Empty;
            txtFatherName.Text = string.Empty;
            txtBirthDate.Text = string.Empty;

            gpEmployeeInfo.Text = @"اطلاعات پرسنلی";

            if(reLoadUserList)
                FillDgUser();
        }

        private void ShowLog(string msg)
        {
            txtInfo.Text = string.Empty;
            txtInfo.Text = string.Format(msg);
        }

        #endregion Form Functions

        private void FrmEmployee_Load(object sender, EventArgs e)
        {

        }

       

     




    }
}
