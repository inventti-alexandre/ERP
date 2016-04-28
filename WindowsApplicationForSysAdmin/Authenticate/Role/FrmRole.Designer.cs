namespace WindowsApplicationForSysAdmin.Authenticate.Role
{
    partial class FrmRole
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
            this.gpRole = new Telerik.WinControls.UI.RadGroupBox();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.txtSearchRole = new Telerik.WinControls.UI.RadTextBox();
            this.dgRole = new Telerik.WinControls.UI.RadGridView();
            this.btnShowRole = new Telerik.WinControls.UI.RadButton();
            this.panelLog = new Telerik.WinControls.UI.RadCollapsiblePanel();
            this.txtInfo = new Telerik.WinControls.UI.RadTextBox();
            this.gbRoleInfo = new Telerik.WinControls.UI.RadGroupBox();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.txtRoleName = new Telerik.WinControls.UI.RadTextBox();
            this.erp = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gpRole)).BeginInit();
            this.gpRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRole.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelLog)).BeginInit();
            this.panelLog.PanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbRoleInfo)).BeginInit();
            this.gbRoleInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoleName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gpRole
            // 
            this.gpRole.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gpRole.Controls.Add(this.txtSearchRole);
            this.gpRole.Controls.Add(this.dgRole);
            this.gpRole.Controls.Add(this.btnShowRole);
            this.gpRole.HeaderText = "لیست نقش های موجود";
            this.gpRole.Location = new System.Drawing.Point(2, 3);
            this.gpRole.Name = "gpRole";
            this.gpRole.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gpRole.Size = new System.Drawing.Size(521, 207);
            this.gpRole.TabIndex = 3;
            this.gpRole.Text = "لیست نقش های موجود";
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(125, 22);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(110, 19);
            this.radButton2.TabIndex = 4;
            this.radButton2.Text = "حذف نقش";
            // 
            // txtSearchRole
            // 
            this.txtSearchRole.Location = new System.Drawing.Point(350, 22);
            this.txtSearchRole.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearchRole.MaxLength = 10;
            this.txtSearchRole.Name = "txtSearchRole";
            this.txtSearchRole.NullText = "نقش";
            this.txtSearchRole.Padding = new System.Windows.Forms.Padding(2);
            this.txtSearchRole.Size = new System.Drawing.Size(161, 21);
            this.txtSearchRole.TabIndex = 1;
            this.txtSearchRole.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgRole
            // 
            this.dgRole.Location = new System.Drawing.Point(8, 50);
            this.dgRole.Margin = new System.Windows.Forms.Padding(0);
            // 
            // dgRole
            // 
            this.dgRole.MasterTemplate.AllowAddNewRow = false;
            this.dgRole.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewCheckBoxColumn3.HeaderText = "انتخاب";
            gridViewCheckBoxColumn3.MaxWidth = 50;
            gridViewCheckBoxColumn3.MinWidth = 40;
            gridViewCheckBoxColumn3.Name = "clmSelect";
            gridViewCheckBoxColumn3.VisibleInColumnChooser = false;
            this.dgRole.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewCheckBoxColumn3});
            this.dgRole.MasterTemplate.EnableGrouping = false;
            this.dgRole.MasterTemplate.EnablePaging = true;
            this.dgRole.MasterTemplate.PageSize = 10;
            this.dgRole.Name = "dgRole";
            this.dgRole.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgRole.Size = new System.Drawing.Size(503, 143);
            this.dgRole.TabIndex = 0;
            this.dgRole.Text = "radGridView1";
            // 
            // btnShowRole
            // 
            this.btnShowRole.Location = new System.Drawing.Point(232, 23);
            this.btnShowRole.Name = "btnShowRole";
            this.btnShowRole.Size = new System.Drawing.Size(110, 20);
            this.btnShowRole.TabIndex = 2;
            this.btnShowRole.Text = "نمایش";
            this.btnShowRole.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // panelLog
            // 
            this.panelLog.Location = new System.Drawing.Point(4, 274);
            this.panelLog.Name = "panelLog";
            // 
            // panelLog.PanelContainer
            // 
            this.panelLog.PanelContainer.Controls.Add(this.txtInfo);
            this.panelLog.PanelContainer.Size = new System.Drawing.Size(519, 113);
            this.panelLog.Size = new System.Drawing.Size(521, 141);
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
            this.txtInfo.Size = new System.Drawing.Size(503, 86);
            this.txtInfo.TabIndex = 1;
            // 
            // gbRoleInfo
            // 
            this.gbRoleInfo.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbRoleInfo.Controls.Add(this.txtRoleName);
            this.gbRoleInfo.Controls.Add(this.radButton2);
            this.gbRoleInfo.Controls.Add(this.btnSave);
            this.gbRoleInfo.HeaderText = "اطلاعات نقش";
            this.gbRoleInfo.Location = new System.Drawing.Point(4, 216);
            this.gbRoleInfo.Name = "gbRoleInfo";
            this.gbRoleInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbRoleInfo.Size = new System.Drawing.Size(518, 52);
            this.gbRoleInfo.TabIndex = 6;
            this.gbRoleInfo.Text = "اطلاعات نقش";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(9, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 19);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "ذخیره";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtRoleName
            // 
            this.txtRoleName.Location = new System.Drawing.Point(264, 21);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.NullText = "نام نقش جدید";
            this.txtRoleName.Size = new System.Drawing.Size(245, 20);
            this.txtRoleName.TabIndex = 8;
            // 
            // erp
            // 
            this.erp.ContainerControl = this;
            this.erp.RightToLeft = true;
            // 
            // FrmRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 423);
            this.Controls.Add(this.gbRoleInfo);
            this.Controls.Add(this.panelLog);
            this.Controls.Add(this.gpRole);
            this.Name = "FrmRole";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "فرم تعریف نقش ها";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this.gpRole)).EndInit();
            this.gpRole.ResumeLayout(false);
            this.gpRole.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRole.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowRole)).EndInit();
            this.panelLog.PanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbRoleInfo)).EndInit();
            this.gbRoleInfo.ResumeLayout(false);
            this.gbRoleInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoleName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox gpRole;
        private Telerik.WinControls.UI.RadTextBox txtSearchRole;
        private Telerik.WinControls.UI.RadGridView dgRole;
        private Telerik.WinControls.UI.RadButton btnShowRole;
        private Telerik.WinControls.UI.RadCollapsiblePanel panelLog;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadTextBox txtInfo;
        private Telerik.WinControls.UI.RadGroupBox gbRoleInfo;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadTextBox txtRoleName;
        private System.Windows.Forms.ErrorProvider erp;

    }
}
