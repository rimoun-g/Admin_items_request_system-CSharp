namespace Admin_items.Forms.Reports
{
    partial class frmCustomizedReport
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
            this.grpbxFilter = new System.Windows.Forms.GroupBox();
            this.btnCalculateStatistics = new System.Windows.Forms.Button();
            this.btnExportToCSV = new System.Windows.Forms.Button();
            this.lblSearchData = new System.Windows.Forms.Label();
            this.txtSearchData = new System.Windows.Forms.TextBox();
            this.grpbxResults = new System.Windows.Forms.GroupBox();
            this.dgReportResults = new System.Windows.Forms.DataGridView();
            this.saveFdgExportToCSV = new System.Windows.Forms.SaveFileDialog();
            this.cmbxYear = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cmbxMonth = new System.Windows.Forms.ComboBox();
            this.grpbxFilter.SuspendLayout();
            this.grpbxResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReportResults)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbxFilter
            // 
            this.grpbxFilter.Controls.Add(this.lblMonth);
            this.grpbxFilter.Controls.Add(this.cmbxMonth);
            this.grpbxFilter.Controls.Add(this.btnCalculateStatistics);
            this.grpbxFilter.Controls.Add(this.btnExportToCSV);
            this.grpbxFilter.Controls.Add(this.lblSearchData);
            this.grpbxFilter.Controls.Add(this.txtSearchData);
            this.grpbxFilter.Controls.Add(this.lblYear);
            this.grpbxFilter.Controls.Add(this.cmbxYear);
            this.grpbxFilter.Location = new System.Drawing.Point(20, 12);
            this.grpbxFilter.Name = "grpbxFilter";
            this.grpbxFilter.Size = new System.Drawing.Size(972, 171);
            this.grpbxFilter.TabIndex = 2;
            this.grpbxFilter.TabStop = false;
            this.grpbxFilter.Text = "Search Transactions By";
            // 
            // btnCalculateStatistics
            // 
            this.btnCalculateStatistics.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCalculateStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateStatistics.Location = new System.Drawing.Point(770, 25);
            this.btnCalculateStatistics.Name = "btnCalculateStatistics";
            this.btnCalculateStatistics.Size = new System.Drawing.Size(196, 33);
            this.btnCalculateStatistics.TabIndex = 5;
            this.btnCalculateStatistics.Text = "Calculate Statistics";
            this.btnCalculateStatistics.UseVisualStyleBackColor = false;
            this.btnCalculateStatistics.Click += new System.EventHandler(this.btnCalculateStatistics_Click);
            // 
            // btnExportToCSV
            // 
            this.btnExportToCSV.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnExportToCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportToCSV.Location = new System.Drawing.Point(770, 75);
            this.btnExportToCSV.Name = "btnExportToCSV";
            this.btnExportToCSV.Size = new System.Drawing.Size(196, 33);
            this.btnExportToCSV.TabIndex = 4;
            this.btnExportToCSV.Text = "Export to CSV";
            this.btnExportToCSV.UseVisualStyleBackColor = false;
            this.btnExportToCSV.Click += new System.EventHandler(this.btnExportToCSV_Click);
            // 
            // lblSearchData
            // 
            this.lblSearchData.AutoSize = true;
            this.lblSearchData.Location = new System.Drawing.Point(225, 129);
            this.lblSearchData.Name = "lblSearchData";
            this.lblSearchData.Size = new System.Drawing.Size(57, 21);
            this.lblSearchData.TabIndex = 3;
            this.lblSearchData.Text = "Search";
            // 
            // txtSearchData
            // 
            this.txtSearchData.Location = new System.Drawing.Point(305, 126);
            this.txtSearchData.Name = "txtSearchData";
            this.txtSearchData.Size = new System.Drawing.Size(373, 27);
            this.txtSearchData.TabIndex = 2;
            this.txtSearchData.TextChanged += new System.EventHandler(this.txtSearchData_TextChanged);
            // 
            // grpbxResults
            // 
            this.grpbxResults.Controls.Add(this.dgReportResults);
            this.grpbxResults.Location = new System.Drawing.Point(20, 189);
            this.grpbxResults.Name = "grpbxResults";
            this.grpbxResults.Size = new System.Drawing.Size(972, 408);
            this.grpbxResults.TabIndex = 3;
            this.grpbxResults.TabStop = false;
            this.grpbxResults.Text = "Results";
            // 
            // dgReportResults
            // 
            this.dgReportResults.AllowUserToAddRows = false;
            this.dgReportResults.AllowUserToDeleteRows = false;
            this.dgReportResults.AllowUserToOrderColumns = true;
            this.dgReportResults.BackgroundColor = System.Drawing.Color.White;
            this.dgReportResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgReportResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReportResults.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgReportResults.Location = new System.Drawing.Point(6, 26);
            this.dgReportResults.Name = "dgReportResults";
            this.dgReportResults.ReadOnly = true;
            this.dgReportResults.RowHeadersWidth = 45;
            this.dgReportResults.RowTemplate.Height = 24;
            this.dgReportResults.Size = new System.Drawing.Size(960, 426);
            this.dgReportResults.TabIndex = 0;
            // 
            // cmbxYear
            // 
            this.cmbxYear.BackColor = System.Drawing.SystemColors.Control;
            this.cmbxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxYear.FormattingEnabled = true;
            this.cmbxYear.Location = new System.Drawing.Point(305, 28);
            this.cmbxYear.Name = "cmbxYear";
            this.cmbxYear.Size = new System.Drawing.Size(373, 28);
            this.cmbxYear.TabIndex = 0;
            this.cmbxYear.SelectedIndexChanged += new System.EventHandler(this.cmbxYear_SelectedIndexChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(225, 31);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(40, 21);
            this.lblYear.TabIndex = 1;
            this.lblYear.Text = "Year";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(225, 78);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(56, 21);
            this.lblMonth.TabIndex = 7;
            this.lblMonth.Text = "Month";
            // 
            // cmbxMonth
            // 
            this.cmbxMonth.BackColor = System.Drawing.SystemColors.Control;
            this.cmbxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxMonth.FormattingEnabled = true;
            this.cmbxMonth.Location = new System.Drawing.Point(305, 75);
            this.cmbxMonth.Name = "cmbxMonth";
            this.cmbxMonth.Size = new System.Drawing.Size(373, 28);
            this.cmbxMonth.TabIndex = 6;
            this.cmbxMonth.SelectedIndexChanged += new System.EventHandler(this.cmbxMonth_SelectedIndexChanged);
            // 
            // frmCustomizedReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1004, 614);
            this.Controls.Add(this.grpbxResults);
            this.Controls.Add(this.grpbxFilter);
            this.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmCustomizedReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customized Reports";
            this.Load += new System.EventHandler(this.frmCustomizedReport_Load);
            this.grpbxFilter.ResumeLayout(false);
            this.grpbxFilter.PerformLayout();
            this.grpbxResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgReportResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpbxFilter;
        private System.Windows.Forms.GroupBox grpbxResults;
        private System.Windows.Forms.DataGridView dgReportResults;
        private System.Windows.Forms.TextBox txtSearchData;
        private System.Windows.Forms.Label lblSearchData;
        private System.Windows.Forms.Button btnExportToCSV;
        private System.Windows.Forms.SaveFileDialog saveFdgExportToCSV;
        private System.Windows.Forms.Button btnCalculateStatistics;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cmbxMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cmbxYear;
    }
}