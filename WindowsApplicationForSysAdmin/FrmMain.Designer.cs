namespace WindowsApplicationForSysAdmin
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.RibbonBar = new Telerik.WinControls.UI.RadRibbonBar();
            this.ribbonTabUsers = new Telerik.WinControls.UI.RibbonTab();
            this.RibbonBarGroupUserBase = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.btnUsersNew = new Telerik.WinControls.UI.RadButtonElement();
            this.btnUserEdit = new Telerik.WinControls.UI.RadButtonElement();
            this.btnUserRole = new Telerik.WinControls.UI.RadButtonElement();
            this.btnUserClaims = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup1 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.btnRoleNew = new Telerik.WinControls.UI.RadButtonElement();
            this.btnRoleEdit = new Telerik.WinControls.UI.RadButtonElement();
            this.btnRoleUser = new Telerik.WinControls.UI.RadButtonElement();
            this.ribbonTabEmployee = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup2 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.btnEmployeeNew = new Telerik.WinControls.UI.RadButtonElement();
            this.ribbonTab3 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup3 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.btnChartNew = new Telerik.WinControls.UI.RadButtonElement();
            this.btnPrsRelationChart = new Telerik.WinControls.UI.RadButtonElement();
            this.ribbonTab4 = new Telerik.WinControls.UI.RibbonTab();
            this.radButtonElement1 = new Telerik.WinControls.UI.RadButtonElement();
            this.StatusStrip = new Telerik.WinControls.UI.RadStatusStrip();
            this.radLabelElement1 = new Telerik.WinControls.UI.RadLabelElement();
            this.radLabelElement2 = new Telerik.WinControls.UI.RadLabelElement();
            this.commandBarSeparator1 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.radLabelElement3 = new Telerik.WinControls.UI.RadLabelElement();
            this.txtDateSH = new Telerik.WinControls.UI.RadLabelElement();
            this.commandBarSeparator2 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.radLabelElement5 = new Telerik.WinControls.UI.RadLabelElement();
            this.txtDateML = new Telerik.WinControls.UI.RadLabelElement();
            this.commandBarSeparator3 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.radLabelElement7 = new Telerik.WinControls.UI.RadLabelElement();
            this.txtUserName = new Telerik.WinControls.UI.RadLabelElement();
            this.office2013DarkTheme = new Telerik.WinControls.Themes.Office2013DarkTheme();
            ((System.ComponentModel.ISupportInitialize)(this.RibbonBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusStrip)).BeginInit();
            this.SuspendLayout();
            // 
            // RibbonBar
            // 
            this.RibbonBar.CommandTabs.AddRange(new Telerik.WinControls.RadItem[] {
            this.ribbonTabUsers,
            this.ribbonTabEmployee,
            this.ribbonTab3,
            this.ribbonTab4});
            this.RibbonBar.Location = new System.Drawing.Point(0, 0);
            this.RibbonBar.Name = "RibbonBar";
            this.RibbonBar.QuickAccessToolBarItems.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement1});
            this.RibbonBar.Size = new System.Drawing.Size(851, 150);
            this.RibbonBar.StartButtonImage = ((System.Drawing.Image)(resources.GetObject("RibbonBar.StartButtonImage")));
            this.RibbonBar.TabIndex = 1;
            this.RibbonBar.ThemeName = "Office2013Dark";
            // 
            // ribbonTabUsers
            // 
            this.ribbonTabUsers.AccessibleDescription = "مدیریت کاربران";
            this.ribbonTabUsers.AccessibleName = "مدیریت کاربران";
            this.ribbonTabUsers.IsSelected = false;
            this.ribbonTabUsers.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.RibbonBarGroupUserBase,
            this.radRibbonBarGroup1});
            this.ribbonTabUsers.Name = "ribbonTabUsers";
            this.ribbonTabUsers.Text = "مدیریت کاربران";
            this.ribbonTabUsers.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // RibbonBarGroupUserBase
            // 
            this.RibbonBarGroupUserBase.AccessibleDescription = "اطلاعات پایه";
            this.RibbonBarGroupUserBase.AccessibleName = "اطلاعات پایه";
            this.RibbonBarGroupUserBase.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnUsersNew,
            this.btnUserEdit,
            this.btnUserRole,
            this.btnUserClaims});
            this.RibbonBarGroupUserBase.Name = "RibbonBarGroupUserBase";
            this.RibbonBarGroupUserBase.Text = "کاربران";
            this.RibbonBarGroupUserBase.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // btnUsersNew
            // 
            this.btnUsersNew.AccessibleDescription = "کاربر جدید";
            this.btnUsersNew.AccessibleName = "کاربر جدید";
            this.btnUsersNew.Name = "btnUsersNew";
            this.btnUsersNew.Text = "کاربر جدید";
            this.btnUsersNew.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnUsersNew.Click += new System.EventHandler(this.btnUsersNew_Click);
            // 
            // btnUserEdit
            // 
            this.btnUserEdit.AccessibleDescription = "ویرایش و حذف";
            this.btnUserEdit.AccessibleName = "ویرایش و حذف";
            this.btnUserEdit.Name = "btnUserEdit";
            this.btnUserEdit.Text = "ویرایش و حذف";
            this.btnUserEdit.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // btnUserRole
            // 
            this.btnUserRole.AccessibleDescription = "مدیریت نقش کاربران";
            this.btnUserRole.AccessibleName = "مدیریت نقش کاربران";
            this.btnUserRole.Name = "btnUserRole";
            this.btnUserRole.Text = "مدیریت نقش کاربران";
            this.btnUserRole.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnUserRole.Click += new System.EventHandler(this.btnUserRole_Click);
            // 
            // btnUserClaims
            // 
            this.btnUserClaims.AccessibleDescription = "انتصاب ویژگی های خاص";
            this.btnUserClaims.AccessibleName = "انتصاب ویژگی های خاص";
            this.btnUserClaims.Name = "btnUserClaims";
            this.btnUserClaims.Text = "انتصاب ویژگی های خاص";
            this.btnUserClaims.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radRibbonBarGroup1
            // 
            this.radRibbonBarGroup1.AccessibleDescription = "نقش ها";
            this.radRibbonBarGroup1.AccessibleName = "نقش ها";
            this.radRibbonBarGroup1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnRoleNew,
            this.btnRoleEdit,
            this.btnRoleUser});
            this.radRibbonBarGroup1.Name = "radRibbonBarGroup1";
            this.radRibbonBarGroup1.Text = "نقش ها";
            this.radRibbonBarGroup1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // btnRoleNew
            // 
            this.btnRoleNew.AccessibleDescription = "btnRole";
            this.btnRoleNew.AccessibleName = "btnRole";
            this.btnRoleNew.Name = "btnRoleNew";
            this.btnRoleNew.Text = "تعریف نقش جدید";
            this.btnRoleNew.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnRoleNew.Click += new System.EventHandler(this.btnRoleNew_Click);
            // 
            // btnRoleEdit
            // 
            this.btnRoleEdit.AccessibleDescription = "ویرایش و حذف نقش";
            this.btnRoleEdit.AccessibleName = "ویرایش و حذف نقش";
            this.btnRoleEdit.Name = "btnRoleEdit";
            this.btnRoleEdit.Text = "ویرایش و حذف نقش";
            this.btnRoleEdit.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // btnRoleUser
            // 
            this.btnRoleUser.AccessibleDescription = "مدیریت کاربران نقش";
            this.btnRoleUser.AccessibleName = "مدیریت کاربران نقش";
            this.btnRoleUser.Name = "btnRoleUser";
            this.btnRoleUser.Text = "مدیریت کاربران نقش";
            this.btnRoleUser.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnRoleUser.Click += new System.EventHandler(this.btnRoleUser_Click);
            // 
            // ribbonTabEmployee
            // 
            this.ribbonTabEmployee.AccessibleDescription = "مدیریت کارمندان";
            this.ribbonTabEmployee.AccessibleName = "مدیریت کارمندان";
            this.ribbonTabEmployee.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup2});
            this.ribbonTabEmployee.Name = "ribbonTabEmployee";
            this.ribbonTabEmployee.Text = "مدیریت کارمندان";
            this.ribbonTabEmployee.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radRibbonBarGroup2
            // 
            this.radRibbonBarGroup2.AccessibleDescription = "اطلاعات پایه";
            this.radRibbonBarGroup2.AccessibleName = "اطلاعات پایه";
            this.radRibbonBarGroup2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnEmployeeNew});
            this.radRibbonBarGroup2.Name = "radRibbonBarGroup2";
            this.radRibbonBarGroup2.Text = "اطلاعات پایه";
            this.radRibbonBarGroup2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // btnEmployeeNew
            // 
            this.btnEmployeeNew.AccessibleDescription = "کارمند جدید";
            this.btnEmployeeNew.AccessibleName = "کارمند جدید";
            this.btnEmployeeNew.Name = "btnEmployeeNew";
            this.btnEmployeeNew.Text = "کارمند جدید";
            this.btnEmployeeNew.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnEmployeeNew.Click += new System.EventHandler(this.btnEmployeeNew_Click);
            // 
            // ribbonTab3
            // 
            this.ribbonTab3.AccessibleDescription = "چارت سازمانی";
            this.ribbonTab3.AccessibleName = "چارت سازمانی";
            this.ribbonTab3.IsSelected = true;
            this.ribbonTab3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup3});
            this.ribbonTab3.Name = "ribbonTab3";
            this.ribbonTab3.Text = "چارت سازمانی";
            this.ribbonTab3.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radRibbonBarGroup3
            // 
            this.radRibbonBarGroup3.AccessibleDescription = "اطلاعات پایه";
            this.radRibbonBarGroup3.AccessibleName = "اطلاعات پایه";
            this.radRibbonBarGroup3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnChartNew,
            this.btnPrsRelationChart});
            this.radRibbonBarGroup3.Name = "radRibbonBarGroup3";
            this.radRibbonBarGroup3.Text = "اطلاعات پایه";
            this.radRibbonBarGroup3.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // btnChartNew
            // 
            this.btnChartNew.AccessibleDescription = "تعریف چارت سازمانی";
            this.btnChartNew.AccessibleName = "تعریف چارت سازمانی";
            this.btnChartNew.Name = "btnChartNew";
            this.btnChartNew.Text = "تعریف چارت سازمانی";
            this.btnChartNew.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnChartNew.Click += new System.EventHandler(this.btnChartNew_Click);
            // 
            // btnPrsRelationChart
            // 
            this.btnPrsRelationChart.AccessibleDescription = "انتصاب کارمند به سمت سازمانی";
            this.btnPrsRelationChart.AccessibleName = "انتصاب کارمند به سمت سازمانی";
            this.btnPrsRelationChart.Name = "btnPrsRelationChart";
            this.btnPrsRelationChart.Text = "انتصاب کارمند به سمت سازمانی";
            this.btnPrsRelationChart.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnPrsRelationChart.Click += new System.EventHandler(this.btnPrsRelationChart_Click);
            // 
            // ribbonTab4
            // 
            this.ribbonTab4.AccessibleDescription = "تنظیمات";
            this.ribbonTab4.AccessibleName = "تنظیمات";
            this.ribbonTab4.Name = "ribbonTab4";
            this.ribbonTab4.Text = "تنظیمات";
            this.ribbonTab4.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radButtonElement1
            // 
            this.radButtonElement1.AccessibleDescription = "پشتیبانی";
            this.radButtonElement1.AccessibleName = "پشتیبانی";
            this.radButtonElement1.Name = "radButtonElement1";
            this.radButtonElement1.StretchHorizontally = false;
            this.radButtonElement1.StretchVertically = false;
            this.radButtonElement1.Text = "پشتیبانی";
            this.radButtonElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radLabelElement1,
            this.radLabelElement2,
            this.commandBarSeparator1,
            this.radLabelElement3,
            this.txtDateSH,
            this.commandBarSeparator2,
            this.radLabelElement5,
            this.txtDateML,
            this.commandBarSeparator3,
            this.radLabelElement7,
            this.txtUserName});
            this.StatusStrip.Location = new System.Drawing.Point(0, 577);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(851, 27);
            this.StatusStrip.TabIndex = 2;
            this.StatusStrip.Text = "radStatusStrip1";
            this.StatusStrip.ThemeName = "Office2013Dark";
            // 
            // radLabelElement1
            // 
            this.radLabelElement1.AccessibleDescription = "ساعت : ";
            this.radLabelElement1.AccessibleName = "ساعت : ";
            this.radLabelElement1.Name = "radLabelElement1";
            this.StatusStrip.SetSpring(this.radLabelElement1, false);
            this.radLabelElement1.Text = "ساعت : ";
            this.radLabelElement1.TextWrap = true;
            this.radLabelElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radLabelElement2
            // 
            this.radLabelElement2.AccessibleDescription = "00 : 00 : 00";
            this.radLabelElement2.AccessibleName = "00 : 00 : 00";
            this.radLabelElement2.Name = "radLabelElement2";
            this.StatusStrip.SetSpring(this.radLabelElement2, false);
            this.radLabelElement2.Text = "00 : 00 : 00";
            this.radLabelElement2.TextWrap = true;
            this.radLabelElement2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // commandBarSeparator1
            // 
            this.commandBarSeparator1.AccessibleDescription = "commandBarSeparator1";
            this.commandBarSeparator1.AccessibleName = "commandBarSeparator1";
            this.commandBarSeparator1.Name = "commandBarSeparator1";
            this.StatusStrip.SetSpring(this.commandBarSeparator1, false);
            this.commandBarSeparator1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarSeparator1.VisibleInOverflowMenu = false;
            // 
            // radLabelElement3
            // 
            this.radLabelElement3.AccessibleDescription = "تاریخ شمسی : ";
            this.radLabelElement3.AccessibleName = "تاریخ شمسی : ";
            this.radLabelElement3.Name = "radLabelElement3";
            this.StatusStrip.SetSpring(this.radLabelElement3, false);
            this.radLabelElement3.Text = "تاریخ شمسی : ";
            this.radLabelElement3.TextWrap = true;
            this.radLabelElement3.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // txtDateSH
            // 
            this.txtDateSH.AccessibleDescription = "0000/00/00 ";
            this.txtDateSH.AccessibleName = "0000/00/00 ";
            this.txtDateSH.Name = "txtDateSH";
            this.StatusStrip.SetSpring(this.txtDateSH, false);
            this.txtDateSH.Text = "0000/00/00 ";
            this.txtDateSH.TextWrap = true;
            this.txtDateSH.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // commandBarSeparator2
            // 
            this.commandBarSeparator2.AccessibleDescription = "commandBarSeparator2";
            this.commandBarSeparator2.AccessibleName = "commandBarSeparator2";
            this.commandBarSeparator2.Name = "commandBarSeparator2";
            this.StatusStrip.SetSpring(this.commandBarSeparator2, false);
            this.commandBarSeparator2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarSeparator2.VisibleInOverflowMenu = false;
            // 
            // radLabelElement5
            // 
            this.radLabelElement5.AccessibleDescription = "تاریخ میلادی : ";
            this.radLabelElement5.AccessibleName = "تاریخ میلادی : ";
            this.radLabelElement5.Name = "radLabelElement5";
            this.StatusStrip.SetSpring(this.radLabelElement5, false);
            this.radLabelElement5.Text = "تاریخ میلادی : ";
            this.radLabelElement5.TextWrap = true;
            this.radLabelElement5.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // txtDateML
            // 
            this.txtDateML.AccessibleDescription = "0000/00/00 ";
            this.txtDateML.AccessibleName = "0000/00/00 ";
            this.txtDateML.Name = "txtDateML";
            this.StatusStrip.SetSpring(this.txtDateML, false);
            this.txtDateML.Text = "0000/00/00 ";
            this.txtDateML.TextWrap = true;
            this.txtDateML.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // commandBarSeparator3
            // 
            this.commandBarSeparator3.AccessibleDescription = "commandBarSeparator3";
            this.commandBarSeparator3.AccessibleName = "commandBarSeparator3";
            this.commandBarSeparator3.Name = "commandBarSeparator3";
            this.StatusStrip.SetSpring(this.commandBarSeparator3, false);
            this.commandBarSeparator3.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarSeparator3.VisibleInOverflowMenu = false;
            // 
            // radLabelElement7
            // 
            this.radLabelElement7.AccessibleDescription = "نام کاربری :";
            this.radLabelElement7.AccessibleName = "نام کاربری :";
            this.radLabelElement7.Name = "radLabelElement7";
            this.StatusStrip.SetSpring(this.radLabelElement7, false);
            this.radLabelElement7.Text = "نام کاربری :";
            this.radLabelElement7.TextWrap = true;
            this.radLabelElement7.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // txtUserName
            // 
            this.txtUserName.AccessibleDescription = "میهمان";
            this.txtUserName.AccessibleName = "میهمان";
            this.txtUserName.Name = "txtUserName";
            this.StatusStrip.SetSpring(this.txtUserName, false);
            this.txtUserName.Text = "میهمان";
            this.txtUserName.TextWrap = true;
            this.txtUserName.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 604);
            this.ControlBox = false;
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.RibbonBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RibbonBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusStrip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private Telerik.WinControls.UI.RadRibbonBar RibbonBar;
        private Telerik.WinControls.UI.RadStatusStrip StatusStrip;
        private Telerik.WinControls.Themes.Office2013DarkTheme office2013DarkTheme;
       
        private Telerik.WinControls.UI.RibbonTab ribbonTabUsers;
        private Telerik.WinControls.UI.RibbonTab ribbonTabEmployee;
        private Telerik.WinControls.UI.RibbonTab ribbonTab3;
        private Telerik.WinControls.UI.RibbonTab ribbonTab4;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement1;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement1;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement2;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator1;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement3;
        private Telerik.WinControls.UI.RadLabelElement txtDateSH;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator2;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement5;
        private Telerik.WinControls.UI.RadLabelElement txtDateML;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator3;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement7;
        private Telerik.WinControls.UI.RadLabelElement txtUserName;
        private Telerik.WinControls.UI.RadRibbonBarGroup RibbonBarGroupUserBase;
        private Telerik.WinControls.UI.RadButtonElement btnUsersNew;
        private Telerik.WinControls.UI.RadButtonElement btnUserEdit;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup1;
        private Telerik.WinControls.UI.RadButtonElement btnRoleNew;
        private Telerik.WinControls.UI.RadButtonElement btnUserRole;
        private Telerik.WinControls.UI.RadButtonElement btnUserClaims;
        private Telerik.WinControls.UI.RadButtonElement btnRoleEdit;
        private Telerik.WinControls.UI.RadButtonElement btnRoleUser;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup2;
        private Telerik.WinControls.UI.RadButtonElement btnEmployeeNew;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup3;
        private Telerik.WinControls.UI.RadButtonElement btnChartNew;
        private Telerik.WinControls.UI.RadButtonElement btnPrsRelationChart;
    }
}



