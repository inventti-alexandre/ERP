namespace WindowsApplicationForSysAdmin.Authenticate.Users
{
    partial class FrmUsers
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
            this.dgUserList = new Telerik.WinControls.UI.RadGridView();
            this.btnShow = new Telerik.WinControls.UI.RadButton();
            this.gpUserList = new Telerik.WinControls.UI.RadGroupBox();
            this.txtSearchUserName = new Telerik.WinControls.UI.RadTextBox();
            this.panelInfo = new Telerik.WinControls.UI.RadCollapsiblePanel();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.txtRePass = new Telerik.WinControls.UI.RadTextBox();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.txtPass = new Telerik.WinControls.UI.RadTextBox();
            this.txtPhone = new Telerik.WinControls.UI.RadTextBox();
            this.txtMail = new Telerik.WinControls.UI.RadTextBox();
            this.txtUserName = new Telerik.WinControls.UI.RadTextBox();
            this.erp = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelLog = new Telerik.WinControls.UI.RadCollapsiblePanel();
            this.txtInfo = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgUserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUserList.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpUserList)).BeginInit();
            this.gpUserList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelInfo)).BeginInit();
            this.panelInfo.PanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRePass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelLog)).BeginInit();
            this.panelLog.PanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
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
            this.dgUserList.Size = new System.Drawing.Size(503, 225);
            this.dgUserList.TabIndex = 0;
            this.dgUserList.Text = "radGridView1";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(232, 23);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(110, 20);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "نمایش";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // gpUserList
            // 
            this.gpUserList.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gpUserList.Controls.Add(this.txtSearchUserName);
            this.gpUserList.Controls.Add(this.dgUserList);
            this.gpUserList.Controls.Add(this.btnShow);
            this.gpUserList.HeaderText = "لیست کاربران";
            this.gpUserList.Location = new System.Drawing.Point(4, 1);
            this.gpUserList.Name = "gpUserList";
            this.gpUserList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gpUserList.Size = new System.Drawing.Size(521, 293);
            this.gpUserList.TabIndex = 2;
            this.gpUserList.Text = "لیست کاربران";
            // 
            // txtSearchUserName
            // 
            this.txtSearchUserName.Location = new System.Drawing.Point(350, 22);
            this.txtSearchUserName.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearchUserName.MaxLength = 10;
            this.txtSearchUserName.Name = "txtSearchUserName";
            this.txtSearchUserName.NullText = "نام کاربری";
            this.txtSearchUserName.Padding = new System.Windows.Forms.Padding(2);
            this.txtSearchUserName.Size = new System.Drawing.Size(161, 21);
            this.txtSearchUserName.TabIndex = 1;
            this.txtSearchUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            // 
            // panelInfo
            // 
            this.panelInfo.Location = new System.Drawing.Point(4, 300);
            this.panelInfo.Name = "panelInfo";
            // 
            // panelInfo.PanelContainer
            // 
            this.panelInfo.PanelContainer.Controls.Add(this.radButton2);
            this.panelInfo.PanelContainer.Controls.Add(this.txtRePass);
            this.panelInfo.PanelContainer.Controls.Add(this.btnSave);
            this.panelInfo.PanelContainer.Controls.Add(this.txtPass);
            this.panelInfo.PanelContainer.Controls.Add(this.txtPhone);
            this.panelInfo.PanelContainer.Controls.Add(this.txtMail);
            this.panelInfo.PanelContainer.Controls.Add(this.txtUserName);
            this.panelInfo.PanelContainer.Size = new System.Drawing.Size(519, 75);
            this.panelInfo.Size = new System.Drawing.Size(521, 103);
            this.panelInfo.TabIndex = 3;
            this.panelInfo.Text = "radCollapsiblePanel1";
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(105, 41);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(65, 20);
            this.radButton2.TabIndex = 6;
            this.radButton2.Text = "انصراف";
            // 
            // txtRePass
            // 
            this.txtRePass.Location = new System.Drawing.Point(22, 9);
            this.txtRePass.Margin = new System.Windows.Forms.Padding(5);
            this.txtRePass.MaxLength = 30;
            this.txtRePass.Name = "txtRePass";
            this.txtRePass.NullText = "تکرار گذرواژه";
            this.txtRePass.Padding = new System.Windows.Forms.Padding(2);
            this.txtRePass.Size = new System.Drawing.Size(148, 21);
            this.txtRePass.TabIndex = 6;
            this.txtRePass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(22, 41);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 20);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "ذخیره";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(187, 9);
            this.txtPass.Margin = new System.Windows.Forms.Padding(5);
            this.txtPass.MaxLength = 30;
            this.txtPass.Name = "txtPass";
            this.txtPass.NullText = "گذرواژه";
            this.txtPass.Padding = new System.Windows.Forms.Padding(2);
            this.txtPass.Size = new System.Drawing.Size(161, 21);
            this.txtPass.TabIndex = 5;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(187, 40);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(5);
            this.txtPhone.MaxLength = 30;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.NullText = "شماره همراه";
            this.txtPhone.Padding = new System.Windows.Forms.Padding(2);
            this.txtPhone.Size = new System.Drawing.Size(161, 21);
            this.txtPhone.TabIndex = 4;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(361, 40);
            this.txtMail.Margin = new System.Windows.Forms.Padding(5);
            this.txtMail.MaxLength = 30;
            this.txtMail.Name = "txtMail";
            this.txtMail.NullText = "رایانامه";
            this.txtMail.Padding = new System.Windows.Forms.Padding(2);
            this.txtMail.Size = new System.Drawing.Size(149, 21);
            this.txtMail.TabIndex = 3;
            this.txtMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(361, 9);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(5);
            this.txtUserName.MaxLength = 30;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.NullText = "نام کاربری";
            this.txtUserName.Padding = new System.Windows.Forms.Padding(2);
            this.txtUserName.Size = new System.Drawing.Size(149, 21);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // erp
            // 
            this.erp.ContainerControl = this;
            this.erp.RightToLeft = true;
            // 
            // panelLog
            // 
            this.panelLog.Location = new System.Drawing.Point(4, 409);
            this.panelLog.Name = "panelLog";
            // 
            // panelLog.PanelContainer
            // 
            this.panelLog.PanelContainer.Controls.Add(this.txtInfo);
            this.panelLog.PanelContainer.Size = new System.Drawing.Size(519, 113);
            this.panelLog.Size = new System.Drawing.Size(521, 141);
            this.panelLog.TabIndex = 4;
            this.panelLog.Text = "radCollapsiblePanel2";
            // 
            // txtInfo
            // 
            this.txtInfo.AutoSize = false;
            this.txtInfo.Location = new System.Drawing.Point(7, 13);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInfo.Size = new System.Drawing.Size(503, 86);
            this.txtInfo.TabIndex = 0;
            // 
            // FrmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 555);
            this.Controls.Add(this.panelLog);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.gpUserList);
            this.Name = "FrmUsers";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "فرم تعریف کاربران";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.FrmUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUserList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpUserList)).EndInit();
            this.gpUserList.ResumeLayout(false);
            this.gpUserList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchUserName)).EndInit();
            this.panelInfo.PanelContainer.ResumeLayout(false);
            this.panelInfo.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRePass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            this.panelLog.PanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView dgUserList;
        private Telerik.WinControls.UI.RadButton btnShow;
        private Telerik.WinControls.UI.RadGroupBox gpUserList;
        private Telerik.WinControls.UI.RadTextBox txtSearchUserName;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadTextBox txtUserName;
        private Telerik.WinControls.UI.RadCollapsiblePanel panelInfo;
        private Telerik.WinControls.UI.RadTextBox txtPhone;
        private Telerik.WinControls.UI.RadTextBox txtMail;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadTextBox txtRePass;
        private Telerik.WinControls.UI.RadTextBox txtPass;
        private System.Windows.Forms.ErrorProvider erp;
        private Telerik.WinControls.UI.RadTextBox txtInfo;
        private Telerik.WinControls.UI.RadCollapsiblePanel panelLog;
    }
}
