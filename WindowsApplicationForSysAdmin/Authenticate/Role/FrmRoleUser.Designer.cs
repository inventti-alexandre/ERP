namespace WindowsApplicationForSysAdmin.Authenticate.Role
{
    partial class FrmRoleUser
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
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn3 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn4 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            this.gpRole = new Telerik.WinControls.UI.RadGroupBox();
            this.txtSearchRole = new Telerik.WinControls.UI.RadTextBox();
            this.dgRole = new Telerik.WinControls.UI.RadGridView();
            this.btnSearchRole = new Telerik.WinControls.UI.RadButton();
            this.gbRoleUser = new Telerik.WinControls.UI.RadGroupBox();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.dgRoleUser = new Telerik.WinControls.UI.RadGridView();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radCollapsiblePanel1 = new Telerik.WinControls.UI.RadCollapsiblePanel();
            this.btnAddMember = new Telerik.WinControls.UI.RadButton();
            this.radButton3 = new Telerik.WinControls.UI.RadButton();
            this.radButton4 = new Telerik.WinControls.UI.RadButton();
            this.panelLog = new Telerik.WinControls.UI.RadCollapsiblePanel();
            this.txtInfo = new Telerik.WinControls.UI.RadTextBox();
            this.lblRoleId = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gpRole)).BeginInit();
            this.gpRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRole.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbRoleUser)).BeginInit();
            this.gbRoleUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRoleUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRoleUser.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCollapsiblePanel1)).BeginInit();
            this.radCollapsiblePanel1.PanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelLog)).BeginInit();
            this.panelLog.PanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRoleId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gpRole
            // 
            this.gpRole.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gpRole.Controls.Add(this.lblRoleId);
            this.gpRole.Controls.Add(this.txtSearchRole);
            this.gpRole.Controls.Add(this.dgRole);
            this.gpRole.Controls.Add(this.btnSearchRole);
            this.gpRole.HeaderText = "لیست نقش های موجود";
            this.gpRole.Location = new System.Drawing.Point(1, 12);
            this.gpRole.Name = "gpRole";
            this.gpRole.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gpRole.Size = new System.Drawing.Size(521, 207);
            this.gpRole.TabIndex = 4;
            this.gpRole.Text = "لیست نقش های موجود";
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
            this.dgRole.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.dgRole_CellClick);
            // 
            // btnSearchRole
            // 
            this.btnSearchRole.Location = new System.Drawing.Point(232, 23);
            this.btnSearchRole.Name = "btnSearchRole";
            this.btnSearchRole.Size = new System.Drawing.Size(110, 20);
            this.btnSearchRole.TabIndex = 2;
            this.btnSearchRole.Text = "جستجو";
            this.btnSearchRole.Click += new System.EventHandler(this.btnSearchRole_Click);
            // 
            // gbRoleUser
            // 
            this.gbRoleUser.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbRoleUser.Controls.Add(this.radTextBox1);
            this.gbRoleUser.Controls.Add(this.dgRoleUser);
            this.gbRoleUser.Controls.Add(this.radButton1);
            this.gbRoleUser.HeaderText = "کاربران عضو در نقش ";
            this.gbRoleUser.Location = new System.Drawing.Point(7, 13);
            this.gbRoleUser.Name = "gbRoleUser";
            this.gbRoleUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbRoleUser.Size = new System.Drawing.Size(513, 207);
            this.gbRoleUser.TabIndex = 5;
            this.gbRoleUser.Text = "کاربران عضو در نقش ";
            // 
            // radTextBox1
            // 
            this.radTextBox1.Location = new System.Drawing.Point(342, 24);
            this.radTextBox1.Margin = new System.Windows.Forms.Padding(5);
            this.radTextBox1.MaxLength = 10;
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.NullText = "کاربر";
            this.radTextBox1.Padding = new System.Windows.Forms.Padding(2);
            this.radTextBox1.Size = new System.Drawing.Size(161, 21);
            this.radTextBox1.TabIndex = 1;
            this.radTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgRoleUser
            // 
            this.dgRoleUser.Location = new System.Drawing.Point(8, 50);
            this.dgRoleUser.Margin = new System.Windows.Forms.Padding(0);
            // 
            // dgRoleUser
            // 
            this.dgRoleUser.MasterTemplate.AllowAddNewRow = false;
            this.dgRoleUser.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewCheckBoxColumn4.HeaderText = "انتخاب";
            gridViewCheckBoxColumn4.MaxWidth = 50;
            gridViewCheckBoxColumn4.MinWidth = 40;
            gridViewCheckBoxColumn4.Name = "clmSelect";
            gridViewCheckBoxColumn4.VisibleInColumnChooser = false;
            this.dgRoleUser.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewCheckBoxColumn4});
            this.dgRoleUser.MasterTemplate.EnableGrouping = false;
            this.dgRoleUser.MasterTemplate.EnablePaging = true;
            this.dgRoleUser.MasterTemplate.PageSize = 10;
            this.dgRoleUser.Name = "dgRoleUser";
            this.dgRoleUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgRoleUser.Size = new System.Drawing.Size(495, 143);
            this.dgRoleUser.TabIndex = 0;
            this.dgRoleUser.Text = "radGridView1";
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(224, 24);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(110, 20);
            this.radButton1.TabIndex = 2;
            this.radButton1.Text = "جستجو";
            // 
            // radCollapsiblePanel1
            // 
            this.radCollapsiblePanel1.Location = new System.Drawing.Point(1, 225);
            this.radCollapsiblePanel1.Name = "radCollapsiblePanel1";
            // 
            // radCollapsiblePanel1.PanelContainer
            // 
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(this.gbRoleUser);
            this.radCollapsiblePanel1.PanelContainer.Size = new System.Drawing.Size(530, 230);
            this.radCollapsiblePanel1.Size = new System.Drawing.Size(532, 257);
            this.radCollapsiblePanel1.TabIndex = 6;
            this.radCollapsiblePanel1.Text = "radCollapsiblePanel1";
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(399, 488);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(110, 24);
            this.btnAddMember.TabIndex = 7;
            this.btnAddMember.Text = "افزودن کاربر جدید";
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // radButton3
            // 
            this.radButton3.Location = new System.Drawing.Point(283, 489);
            this.radButton3.Name = "radButton3";
            this.radButton3.Size = new System.Drawing.Size(110, 24);
            this.radButton3.TabIndex = 8;
            this.radButton3.Text = "حذف کاربر";
            // 
            // radButton4
            // 
            this.radButton4.Location = new System.Drawing.Point(167, 489);
            this.radButton4.Name = "radButton4";
            this.radButton4.Size = new System.Drawing.Size(110, 24);
            this.radButton4.TabIndex = 9;
            this.radButton4.Text = "انصراف";
            // 
            // panelLog
            // 
            this.panelLog.Location = new System.Drawing.Point(2, 515);
            this.panelLog.Name = "panelLog";
            // 
            // panelLog.PanelContainer
            // 
            this.panelLog.PanelContainer.Controls.Add(this.txtInfo);
            this.panelLog.PanelContainer.Size = new System.Drawing.Size(528, 113);
            this.panelLog.Size = new System.Drawing.Size(530, 141);
            this.panelLog.TabIndex = 10;
            this.panelLog.Text = "radCollapsiblePanel2";
            // 
            // txtInfo
            // 
            this.txtInfo.AutoSize = false;
            this.txtInfo.Location = new System.Drawing.Point(13, 13);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInfo.Size = new System.Drawing.Size(503, 86);
            this.txtInfo.TabIndex = 2;
            // 
            // lblRoleId
            // 
            this.lblRoleId.Location = new System.Drawing.Point(12, 23);
            this.lblRoleId.Name = "lblRoleId";
            this.lblRoleId.Size = new System.Drawing.Size(50, 18);
            this.lblRoleId.TabIndex = 3;
            this.lblRoleId.Text = "lblRoleId";
            this.lblRoleId.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // FrmRoleUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 657);
            this.Controls.Add(this.panelLog);
            this.Controls.Add(this.radButton4);
            this.Controls.Add(this.radButton3);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.radCollapsiblePanel1);
            this.Controls.Add(this.gpRole);
            this.Name = "FrmRoleUser";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "فرم انتصاب کاربر به نقش";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this.gpRole)).EndInit();
            this.gpRole.ResumeLayout(false);
            this.gpRole.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRole.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbRoleUser)).EndInit();
            this.gbRoleUser.ResumeLayout(false);
            this.gbRoleUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRoleUser.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRoleUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            this.radCollapsiblePanel1.PanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radCollapsiblePanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton4)).EndInit();
            this.panelLog.PanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRoleId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox gpRole;
        private Telerik.WinControls.UI.RadTextBox txtSearchRole;
        private Telerik.WinControls.UI.RadGridView dgRole;
        private Telerik.WinControls.UI.RadButton btnSearchRole;
        private Telerik.WinControls.UI.RadGroupBox gbRoleUser;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadGridView dgRoleUser;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadCollapsiblePanel radCollapsiblePanel1;
        private Telerik.WinControls.UI.RadButton btnAddMember;
        private Telerik.WinControls.UI.RadButton radButton3;
        private Telerik.WinControls.UI.RadButton radButton4;
        private Telerik.WinControls.UI.RadCollapsiblePanel panelLog;
        private Telerik.WinControls.UI.RadTextBox txtInfo;
        private Telerik.WinControls.UI.RadLabel lblRoleId;
    }
}
