namespace WindowsApplicationForSysAdmin.Employee
{
    partial class FrmEmployee
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
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            this.gpUserList = new Telerik.WinControls.UI.RadGroupBox();
            this.lblUserId = new Telerik.WinControls.UI.RadLabel();
            this.txtUserName = new Telerik.WinControls.UI.RadTextBox();
            this.dgUserList = new Telerik.WinControls.UI.RadGridView();
            this.btnShow = new Telerik.WinControls.UI.RadButton();
            this.gpEmployeeInfo = new Telerik.WinControls.UI.RadGroupBox();
            this.txtBirthDate = new Telerik.WinControls.UI.RadTextBox();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.txtName = new Telerik.WinControls.UI.RadTextBox();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.txtFatherName = new Telerik.WinControls.UI.RadTextBox();
            this.txtFamily = new Telerik.WinControls.UI.RadTextBox();
            this.txtNationalCode = new Telerik.WinControls.UI.RadTextBox();
            this.radCollapsiblePanel2 = new Telerik.WinControls.UI.RadCollapsiblePanel();
            this.txtInfo = new Telerik.WinControls.UI.RadTextBox();
            this.erp = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gpUserList)).BeginInit();
            this.gpUserList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblUserId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUserList.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpEmployeeInfo)).BeginInit();
            this.gpEmployeeInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirthDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFatherName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFamily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNationalCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCollapsiblePanel2)).BeginInit();
            this.radCollapsiblePanel2.PanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gpUserList
            // 
            this.gpUserList.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gpUserList.Controls.Add(this.lblUserId);
            this.gpUserList.Controls.Add(this.txtUserName);
            this.gpUserList.Controls.Add(this.dgUserList);
            this.gpUserList.Controls.Add(this.btnShow);
            this.gpUserList.HeaderText = "لیست کاربران";
            this.gpUserList.Location = new System.Drawing.Point(2, 2);
            this.gpUserList.Name = "gpUserList";
            this.gpUserList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gpUserList.Size = new System.Drawing.Size(703, 293);
            this.gpUserList.TabIndex = 3;
            this.gpUserList.Text = "لیست کاربران";
            // 
            // lblUserId
            // 
            this.lblUserId.Location = new System.Drawing.Point(10, 22);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(50, 18);
            this.lblUserId.TabIndex = 7;
            this.lblUserId.Text = "lblUserId";
            this.lblUserId.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lblUserId.Visible = false;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(453, 20);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(5);
            this.txtUserName.MaxLength = 10;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.NullText = "نام کاربری";
            this.txtUserName.Padding = new System.Windows.Forms.Padding(2);
            this.txtUserName.Size = new System.Drawing.Size(240, 21);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchUserName_KeyDown);
            // 
            // dgUserList
            // 
            this.dgUserList.Location = new System.Drawing.Point(8, 50);
            this.dgUserList.Margin = new System.Windows.Forms.Padding(0);
            // 
            // dgUserList
            // 
            this.dgUserList.MasterTemplate.AllowAddNewRow = false;
            this.dgUserList.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewCheckBoxColumn1.HeaderText = "انتخاب";
            gridViewCheckBoxColumn1.MaxWidth = 50;
            gridViewCheckBoxColumn1.MinWidth = 40;
            gridViewCheckBoxColumn1.Name = "clmSelect";
            gridViewCheckBoxColumn1.VisibleInColumnChooser = false;
            this.dgUserList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewCheckBoxColumn1});
            this.dgUserList.MasterTemplate.EnableGrouping = false;
            this.dgUserList.MasterTemplate.EnablePaging = true;
            this.dgUserList.MasterTemplate.PageSize = 10;
            this.dgUserList.Name = "dgUserList";
            this.dgUserList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgUserList.Size = new System.Drawing.Size(685, 225);
            this.dgUserList.TabIndex = 0;
            this.dgUserList.Text = "radGridView1";
            this.dgUserList.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.dgUserList_CellClick);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(335, 21);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(110, 20);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "نمایش";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // gpEmployeeInfo
            // 
            this.gpEmployeeInfo.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gpEmployeeInfo.Controls.Add(this.txtBirthDate);
            this.gpEmployeeInfo.Controls.Add(this.btnCancel);
            this.gpEmployeeInfo.Controls.Add(this.txtName);
            this.gpEmployeeInfo.Controls.Add(this.btnSave);
            this.gpEmployeeInfo.Controls.Add(this.txtFatherName);
            this.gpEmployeeInfo.Controls.Add(this.txtFamily);
            this.gpEmployeeInfo.Controls.Add(this.txtNationalCode);
            this.gpEmployeeInfo.HeaderText = "اطلاعات پرسنلی";
            this.gpEmployeeInfo.Location = new System.Drawing.Point(2, 301);
            this.gpEmployeeInfo.Name = "gpEmployeeInfo";
            this.gpEmployeeInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gpEmployeeInfo.Size = new System.Drawing.Size(703, 98);
            this.gpEmployeeInfo.TabIndex = 4;
            this.gpEmployeeInfo.Text = "اطلاعات پرسنلی";
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Location = new System.Drawing.Point(8, 21);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.NullText = "تاریخ تولد";
            this.txtBirthDate.Size = new System.Drawing.Size(124, 20);
            this.txtBirthDate.TabIndex = 4;
            this.txtBirthDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(149, 56);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 24);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(430, 21);
            this.txtName.Name = "txtName";
            this.txtName.NullText = "نام";
            this.txtName.Size = new System.Drawing.Size(124, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(10, 56);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 24);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "ذخیره";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(147, 21);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.NullText = "نام پدر";
            this.txtFatherName.Size = new System.Drawing.Size(124, 20);
            this.txtFatherName.TabIndex = 3;
            this.txtFatherName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFamily
            // 
            this.txtFamily.Location = new System.Drawing.Point(287, 21);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.NullText = "نام خانوادگی";
            this.txtFamily.Size = new System.Drawing.Size(124, 20);
            this.txtFamily.TabIndex = 2;
            this.txtFamily.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Location = new System.Drawing.Point(571, 21);
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.NullText = "کدملی";
            this.txtNationalCode.Size = new System.Drawing.Size(124, 20);
            this.txtNationalCode.TabIndex = 0;
            this.txtNationalCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radCollapsiblePanel2
            // 
            this.radCollapsiblePanel2.Location = new System.Drawing.Point(2, 405);
            this.radCollapsiblePanel2.Name = "radCollapsiblePanel2";
            // 
            // radCollapsiblePanel2.PanelContainer
            // 
            this.radCollapsiblePanel2.PanelContainer.Controls.Add(this.txtInfo);
            this.radCollapsiblePanel2.PanelContainer.Size = new System.Drawing.Size(701, 113);
            this.radCollapsiblePanel2.Size = new System.Drawing.Size(703, 141);
            this.radCollapsiblePanel2.TabIndex = 7;
            this.radCollapsiblePanel2.Text = "radCollapsiblePanel2";
            // 
            // txtInfo
            // 
            this.txtInfo.AutoSize = false;
            this.txtInfo.Location = new System.Drawing.Point(7, 12);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInfo.Size = new System.Drawing.Size(687, 86);
            this.txtInfo.TabIndex = 1;
            // 
            // erp
            // 
            this.erp.ContainerControl = this;
            this.erp.RightToLeft = true;
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 548);
            this.Controls.Add(this.radCollapsiblePanel2);
            this.Controls.Add(this.gpEmployeeInfo);
            this.Controls.Add(this.gpUserList);
            this.Name = "FrmEmployee";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "فرم اطلاعات کارمندی";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.FrmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gpUserList)).EndInit();
            this.gpUserList.ResumeLayout(false);
            this.gpUserList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblUserId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUserList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpEmployeeInfo)).EndInit();
            this.gpEmployeeInfo.ResumeLayout(false);
            this.gpEmployeeInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirthDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFatherName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFamily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNationalCode)).EndInit();
            this.radCollapsiblePanel2.PanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radCollapsiblePanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox gpUserList;
        private Telerik.WinControls.UI.RadTextBox txtUserName;
        private Telerik.WinControls.UI.RadGridView dgUserList;
        private Telerik.WinControls.UI.RadButton btnShow;
        private Telerik.WinControls.UI.RadGroupBox gpEmployeeInfo;
        private Telerik.WinControls.UI.RadTextBox txtName;
        private Telerik.WinControls.UI.RadTextBox txtNationalCode;
        private Telerik.WinControls.UI.RadTextBox txtFamily;
        private Telerik.WinControls.UI.RadTextBox txtFatherName;
        private Telerik.WinControls.UI.RadTextBox txtBirthDate;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadCollapsiblePanel radCollapsiblePanel2;
        private Telerik.WinControls.UI.RadTextBox txtInfo;
        private Telerik.WinControls.UI.RadLabel lblUserId;
        private System.Windows.Forms.ErrorProvider erp;
    }
}
