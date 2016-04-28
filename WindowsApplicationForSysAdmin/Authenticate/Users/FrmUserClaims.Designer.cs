namespace WindowsApplicationForSysAdmin.Authenticate.Users
{
    partial class FrmUserClaims
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
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn2 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            this.gpUserList = new Telerik.WinControls.UI.RadGroupBox();
            this.lblUserId = new Telerik.WinControls.UI.RadLabel();
            this.txtSearchUserName = new Telerik.WinControls.UI.RadTextBox();
            this.dgUserList = new Telerik.WinControls.UI.RadGridView();
            this.btnShow = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.txtClaimType = new Telerik.WinControls.UI.RadTextBox();
            this.txtClaimName = new Telerik.WinControls.UI.RadTextBox();
            this.panelLog = new Telerik.WinControls.UI.RadCollapsiblePanel();
            this.txtInfo = new Telerik.WinControls.UI.RadTextBox();
            this.erp = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgClaim = new Telerik.WinControls.UI.RadGridView();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.gpUserList)).BeginInit();
            this.gpUserList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblUserId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUserList.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClaimType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClaimName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelLog)).BeginInit();
            this.panelLog.PanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgClaim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgClaim.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gpUserList
            // 
            this.gpUserList.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gpUserList.Controls.Add(this.lblUserId);
            this.gpUserList.Controls.Add(this.txtSearchUserName);
            this.gpUserList.Controls.Add(this.dgUserList);
            this.gpUserList.Controls.Add(this.btnShow);
            this.gpUserList.HeaderText = "لیست کاربران";
            this.gpUserList.Location = new System.Drawing.Point(0, 3);
            this.gpUserList.Name = "gpUserList";
            this.gpUserList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gpUserList.Size = new System.Drawing.Size(521, 224);
            this.gpUserList.TabIndex = 3;
            this.gpUserList.Text = "لیست کاربران";
            // 
            // lblUserId
            // 
            this.lblUserId.Location = new System.Drawing.Point(9, 23);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(50, 18);
            this.lblUserId.TabIndex = 3;
            this.lblUserId.Text = "lblUserId";
            this.lblUserId.TextAlignment = System.Drawing.ContentAlignment.TopRight;
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
            this.dgUserList.Size = new System.Drawing.Size(503, 161);
            this.dgUserList.TabIndex = 0;
            this.dgUserList.Text = "radGridView1";
            this.dgUserList.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.dgUserList_CellClick);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(232, 23);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(110, 20);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "جستجو";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.btnCancel);
            this.radGroupBox1.Controls.Add(this.btnSave);
            this.radGroupBox1.Controls.Add(this.txtClaimType);
            this.radGroupBox1.Controls.Add(this.txtClaimName);
            this.radGroupBox1.HeaderText = "اطلاعات ذخیره سازی";
            this.radGroupBox1.Location = new System.Drawing.Point(2, 446);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radGroupBox1.Size = new System.Drawing.Size(521, 51);
            this.radGroupBox1.TabIndex = 4;
            this.radGroupBox1.Text = "اطلاعات ذخیره سازی";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(228, 21);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 20);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(8, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(214, 20);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "ذخیره";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtClaimType
            // 
            this.txtClaimType.Location = new System.Drawing.Point(305, 21);
            this.txtClaimType.Name = "txtClaimType";
            this.txtClaimType.NullText = "نوع";
            this.txtClaimType.Size = new System.Drawing.Size(100, 20);
            this.txtClaimType.TabIndex = 1;
            this.txtClaimType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtClaimName
            // 
            this.txtClaimName.Location = new System.Drawing.Point(411, 21);
            this.txtClaimName.Name = "txtClaimName";
            this.txtClaimName.NullText = "نام";
            this.txtClaimName.Size = new System.Drawing.Size(100, 20);
            this.txtClaimName.TabIndex = 0;
            this.txtClaimName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelLog
            // 
            this.panelLog.Location = new System.Drawing.Point(2, 503);
            this.panelLog.Name = "panelLog";
            // 
            // panelLog.PanelContainer
            // 
            this.panelLog.PanelContainer.Controls.Add(this.txtInfo);
            this.panelLog.PanelContainer.Size = new System.Drawing.Size(519, 75);
            this.panelLog.Size = new System.Drawing.Size(521, 103);
            this.panelLog.TabIndex = 5;
            this.panelLog.Text = "radCollapsiblePanel2";
            // 
            // txtInfo
            // 
            this.txtInfo.AutoSize = false;
            this.txtInfo.Location = new System.Drawing.Point(8, 13);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInfo.Size = new System.Drawing.Size(503, 50);
            this.txtInfo.TabIndex = 1;
            // 
            // erp
            // 
            this.erp.ContainerControl = this;
            this.erp.RightToLeft = true;
            // 
            // dgClaim
            // 
            this.dgClaim.Location = new System.Drawing.Point(6, 55);
            this.dgClaim.Margin = new System.Windows.Forms.Padding(0);
            // 
            // dgClaim
            // 
            this.dgClaim.MasterTemplate.AllowAddNewRow = false;
            this.dgClaim.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewCheckBoxColumn2.HeaderText = "انتخاب";
            gridViewCheckBoxColumn2.MaxWidth = 50;
            gridViewCheckBoxColumn2.MinWidth = 40;
            gridViewCheckBoxColumn2.Name = "clmSelect";
            gridViewCheckBoxColumn2.VisibleInColumnChooser = false;
            this.dgClaim.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewCheckBoxColumn2});
            this.dgClaim.MasterTemplate.EnableGrouping = false;
            this.dgClaim.MasterTemplate.EnablePaging = true;
            this.dgClaim.MasterTemplate.PageSize = 10;
            this.dgClaim.Name = "dgClaim";
            this.dgClaim.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgClaim.Size = new System.Drawing.Size(509, 140);
            this.dgClaim.TabIndex = 6;
            this.dgClaim.Text = "radGridView1";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.radTextBox1);
            this.radGroupBox2.Controls.Add(this.radButton1);
            this.radGroupBox2.Controls.Add(this.dgClaim);
            this.radGroupBox2.HeaderText = "خصوصیات کاربر";
            this.radGroupBox2.Location = new System.Drawing.Point(2, 233);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radGroupBox2.Size = new System.Drawing.Size(519, 207);
            this.radGroupBox2.TabIndex = 7;
            this.radGroupBox2.Text = "خصوصیات کاربر";
            // 
            // radTextBox1
            // 
            this.radTextBox1.Location = new System.Drawing.Point(348, 20);
            this.radTextBox1.Margin = new System.Windows.Forms.Padding(5);
            this.radTextBox1.MaxLength = 10;
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.NullText = "خصوصیت";
            this.radTextBox1.Padding = new System.Windows.Forms.Padding(2);
            this.radTextBox1.Size = new System.Drawing.Size(161, 21);
            this.radTextBox1.TabIndex = 7;
            this.radTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(230, 21);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(110, 20);
            this.radButton1.TabIndex = 8;
            this.radButton1.Text = "جستجو";
            // 
            // FrmUserClaims
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 611);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.panelLog);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.gpUserList);
            this.Name = "FrmUserClaims";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "خصوصیات کاربران";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.FrmUserClaims_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gpUserList)).EndInit();
            this.gpUserList.ResumeLayout(false);
            this.gpUserList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblUserId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUserList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClaimType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClaimName)).EndInit();
            this.panelLog.PanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgClaim.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgClaim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox gpUserList;
        private Telerik.WinControls.UI.RadTextBox txtSearchUserName;
        private Telerik.WinControls.UI.RadGridView dgUserList;
        private Telerik.WinControls.UI.RadButton btnShow;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadTextBox txtClaimType;
        private Telerik.WinControls.UI.RadTextBox txtClaimName;
        private Telerik.WinControls.UI.RadCollapsiblePanel panelLog;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadTextBox txtInfo;
        private System.Windows.Forms.ErrorProvider erp;
        private Telerik.WinControls.UI.RadLabel lblUserId;
        private Telerik.WinControls.UI.RadGridView dgClaim;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
}
