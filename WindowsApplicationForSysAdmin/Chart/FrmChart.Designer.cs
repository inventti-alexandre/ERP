namespace WindowsApplicationForSysAdmin.Chart
{
    partial class FrmChart
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
            this.txtFolName = new Telerik.WinControls.UI.RadTextBox();
            this.chkActive = new Telerik.WinControls.UI.RadCheckBox();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.tvChart = new Telerik.WinControls.UI.RadTreeView();
            this.ddlChartType = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlChartType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFolName
            // 
            this.txtFolName.Location = new System.Drawing.Point(221, 12);
            this.txtFolName.Name = "txtFolName";
            this.txtFolName.NullText = "نام ";
            this.txtFolName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFolName.Size = new System.Drawing.Size(152, 20);
            this.txtFolName.TabIndex = 0;
            this.txtFolName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkActive
            // 
            this.chkActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActive.Location = new System.Drawing.Point(12, 15);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(43, 18);
            this.chkActive.TabIndex = 1;
            this.chkActive.Text = "فعال";
            this.chkActive.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(3, 38);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(370, 24);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "ثبت این بخش از چارت";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tvChart
            // 
            this.tvChart.AllowShowFocusCues = true;
            this.tvChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.tvChart.Cursor = System.Windows.Forms.Cursors.Default;
            this.tvChart.Dock = System.Windows.Forms.DockStyle.Right;
            this.tvChart.DropHintColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tvChart.ExpandAnimation = Telerik.WinControls.UI.ExpandAnimation.None;
            this.tvChart.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tvChart.ForeColor = System.Drawing.Color.Black;
            this.tvChart.Location = new System.Drawing.Point(384, 0);
            this.tvChart.Name = "tvChart";
            this.tvChart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tvChart.ShowLines = true;
            this.tvChart.ShowNodeToolTips = true;
            this.tvChart.Size = new System.Drawing.Size(243, 401);
            this.tvChart.SpacingBetweenNodes = -1;
            this.tvChart.TabIndex = 3;
            this.tvChart.Text = "radTreeView1";
            // 
            // ddlChartType
            // 
            this.ddlChartType.AllowShowFocusCues = false;
            this.ddlChartType.Location = new System.Drawing.Point(61, 12);
            this.ddlChartType.Name = "ddlChartType";
            this.ddlChartType.Size = new System.Drawing.Size(144, 20);
            this.ddlChartType.TabIndex = 4;
            this.ddlChartType.Text = "radDropDownList1";
            // 
            // FrmChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 401);
            this.Controls.Add(this.ddlChartType);
            this.Controls.Add(this.tvChart);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.txtFolName);
            this.Name = "FrmChart";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "FrmChart";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.FrmChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtFolName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlChartType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox txtFolName;
        private Telerik.WinControls.UI.RadCheckBox chkActive;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadTreeView tvChart;
        private Telerik.WinControls.UI.RadDropDownList ddlChartType;
    }
}
