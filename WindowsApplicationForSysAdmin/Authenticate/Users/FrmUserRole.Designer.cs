namespace WindowsApplicationForSysAdmin.Authenticate.Users
{
    partial class FrmUserRole
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
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn3 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            this.gpUserList = new Telerik.WinControls.UI.RadGroupBox();
            this.lblUserId = new Telerik.WinControls.UI.RadLabel();
            this.txtSearchUserName = new Telerik.WinControls.UI.RadTextBox();
            this.dgUserList = new Telerik.WinControls.UI.RadGridView();
            this.btnSearchUser = new Telerik.WinControls.UI.RadButton();
            this.gbRoles = new Telerik.WinControls.UI.RadGroupBox();
            this.panelRoles = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.panelLog = new Telerik.WinControls.UI.RadCollapsiblePanel();
            this.txtInfo = new Telerik.WinControls.UI.RadTextBox();
            this.erp = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gpUserList)).BeginInit();
            this.gpUserList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblUserId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUserList.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbRoles)).BeginInit();
            this.gbRoles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelLog)).BeginInit();
            this.panelLog.PanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gpUserList
            // 
            this.gpUserList.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gpUserList.Controls.Add(this.lblUserId);
            this.gpUserList.Controls.Add(this.txtSearchUserName);
            this.gpUserList.Controls.Add(this.dgUserList);
            this.gpUserList.Controls.Add(this.btnSearchUser);
            this.gpUserList.HeaderText = "لیست کاربران";
            this.gpUserList.Location = new System.Drawing.Point(2, 0);
            this.gpUserList.Name = "gpUserList";
            this.gpUserList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gpUserList.Size = new System.Drawing.Size(521, 224);
            this.gpUserList.TabIndex = 4;
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
            gridViewCheckBoxColumn3.HeaderText = "انتخاب";
            gridViewCheckBoxColumn3.MaxWidth = 50;
            gridViewCheckBoxColumn3.MinWidth = 40;
            gridViewCheckBoxColumn3.Name = "clmSelect";
            gridViewCheckBoxColumn3.VisibleInColumnChooser = false;
            this.dgUserList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewCheckBoxColumn3});
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
            // btnSearchUser
            // 
            this.btnSearchUser.Location = new System.Drawing.Point(232, 23);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(110, 20);
            this.btnSearchUser.TabIndex = 2;
            this.btnSearchUser.Text = "جستجو";
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // gbRoles
            // 
            this.gbRoles.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbRoles.Controls.Add(this.btnSave);
            this.gbRoles.Controls.Add(this.panelRoles);
            this.gbRoles.HeaderText = "نقش ها";
            this.gbRoles.Location = new System.Drawing.Point(2, 230);
            this.gbRoles.Name = "gbRoles";
            this.gbRoles.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbRoles.Size = new System.Drawing.Size(521, 135);
            this.gbRoles.TabIndex = 6;
            this.gbRoles.Text = "نقش ها";
            // 
            // panelRoles
            // 
            this.panelRoles.AutoScroll = true;
            this.panelRoles.Location = new System.Drawing.Point(10, 21);
            this.panelRoles.Name = "panelRoles";
            this.panelRoles.Size = new System.Drawing.Size(501, 78);
            this.panelRoles.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(10, 105);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(501, 24);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "ذخیره";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panelLog
            // 
            this.panelLog.Location = new System.Drawing.Point(2, 371);
            this.panelLog.Name = "panelLog";
            // 
            // panelLog.PanelContainer
            // 
            this.panelLog.PanelContainer.Controls.Add(this.txtInfo);
            this.panelLog.PanelContainer.Size = new System.Drawing.Size(519, 113);
            this.panelLog.Size = new System.Drawing.Size(521, 141);
            this.panelLog.TabIndex = 7;
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
            this.txtInfo.Size = new System.Drawing.Size(503, 86);
            this.txtInfo.TabIndex = 1;
            // 
            // erp
            // 
            this.erp.ContainerControl = this;
            this.erp.RightToLeft = true;
            // 
            // FrmUserRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 522);
            this.Controls.Add(this.panelLog);
            this.Controls.Add(this.gbRoles);
            this.Controls.Add(this.gpUserList);
            this.Name = "FrmUserRole";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "نقش کاربران";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.FrmUserRole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gpUserList)).EndInit();
            this.gpUserList.ResumeLayout(false);
            this.gpUserList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblUserId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUserList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbRoles)).EndInit();
            this.gbRoles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            this.panelLog.PanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox gpUserList;
        private Telerik.WinControls.UI.RadLabel lblUserId;
        private Telerik.WinControls.UI.RadTextBox txtSearchUserName;
        private Telerik.WinControls.UI.RadGridView dgUserList;
        private Telerik.WinControls.UI.RadButton btnSearchUser;
        private Telerik.WinControls.UI.RadGroupBox gbRoles;
        private System.Windows.Forms.FlowLayoutPanel panelRoles;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadCollapsiblePanel panelLog;
        private Telerik.WinControls.UI.RadTextBox txtInfo;
        private System.Windows.Forms.ErrorProvider erp;
    }
}
