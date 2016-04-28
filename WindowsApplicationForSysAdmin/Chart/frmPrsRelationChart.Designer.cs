namespace WindowsApplicationForSysAdmin.Chart
{
    partial class FrmPrsRelationChart
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
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            this.tvChart = new Telerik.WinControls.UI.RadTreeView();
            this.txtUserName = new Telerik.WinControls.UI.RadTextBox();
            this.dgUserList = new Telerik.WinControls.UI.RadGridView();
            this.btnShow = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.tvChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUserList.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // tvChart
            // 
            this.tvChart.AllowDragDrop = true;
            this.tvChart.AllowPlusMinusAnimation = true;
            this.tvChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.tvChart.Cursor = System.Windows.Forms.Cursors.Default;
            this.tvChart.Dock = System.Windows.Forms.DockStyle.Right;
            this.tvChart.DropHintColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tvChart.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tvChart.ForeColor = System.Drawing.Color.Black;
            this.tvChart.Location = new System.Drawing.Point(599, 0);
            this.tvChart.Name = "tvChart";
            this.tvChart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tvChart.ShowLines = true;
            this.tvChart.ShowNodeToolTips = true;
            this.tvChart.Size = new System.Drawing.Size(233, 433);
            this.tvChart.SpacingBetweenNodes = -1;
            this.tvChart.TabIndex = 4;
            this.tvChart.Text = "radTreeView1";
            this.tvChart.SelectedNodeChanged += new Telerik.WinControls.UI.RadTreeView.RadTreeViewEventHandler(this.tvChart_SelectedNodeChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(339, 228);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(5);
            this.txtUserName.MaxLength = 10;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.NullText = "نام کاربری";
            this.txtUserName.Padding = new System.Windows.Forms.Padding(2);
            this.txtUserName.Size = new System.Drawing.Size(252, 21);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgUserList
            // 
            this.dgUserList.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgUserList.Location = new System.Drawing.Point(0, 0);
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
            this.dgUserList.Size = new System.Drawing.Size(599, 225);
            this.dgUserList.TabIndex = 0;
            this.dgUserList.Text = "radGridView1";
            this.dgUserList.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.dgUserList_CellClick);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(12, 228);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(319, 20);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "نمایش";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(130, 403);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 20);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "انتصاب";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // radTextBox1
            // 
            this.radTextBox1.AutoSize = false;
            this.radTextBox1.Location = new System.Drawing.Point(12, 257);
            this.radTextBox1.Multiline = true;
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(579, 140);
            this.radTextBox1.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 403);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 20);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "انصراف";
            // 
            // FrmPrsRelationChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 433);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.radTextBox1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgUserList);
            this.Controls.Add(this.tvChart);
            this.Name = "FrmPrsRelationChart";
            this.Text = "انتصاب کارمندان به عناوین";
            this.Load += new System.EventHandler(this.frmPrsRelationChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tvChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUserList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTreeView tvChart;
        private Telerik.WinControls.UI.RadTextBox txtUserName;
        private Telerik.WinControls.UI.RadGridView dgUserList;
        private Telerik.WinControls.UI.RadButton btnShow;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadButton btnCancel;
    }
}