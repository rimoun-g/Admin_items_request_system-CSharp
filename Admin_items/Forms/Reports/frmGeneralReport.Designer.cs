namespace Admin_items.Forms.Reports
{
    partial class frmGeneralReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeneralReport));
            this.grpbxGeneralReport = new System.Windows.Forms.GroupBox();
            this.dgGeneralReport = new System.Windows.Forms.DataGridView();
            this.btnExportToCSV = new System.Windows.Forms.Button();
            this.saveFdgExportToCSV = new System.Windows.Forms.SaveFileDialog();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.grpbxGeneralReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGeneralReport)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbxGeneralReport
            // 
            this.grpbxGeneralReport.Controls.Add(this.dgGeneralReport);
            this.grpbxGeneralReport.Location = new System.Drawing.Point(6, 88);
            this.grpbxGeneralReport.Name = "grpbxGeneralReport";
            this.grpbxGeneralReport.Size = new System.Drawing.Size(998, 445);
            this.grpbxGeneralReport.TabIndex = 0;
            this.grpbxGeneralReport.TabStop = false;
            this.grpbxGeneralReport.Text = "General Report";
            // 
            // dgGeneralReport
            // 
            this.dgGeneralReport.AllowUserToAddRows = false;
            this.dgGeneralReport.AllowUserToDeleteRows = false;
            this.dgGeneralReport.BackgroundColor = System.Drawing.Color.White;
            this.dgGeneralReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGeneralReport.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgGeneralReport.Location = new System.Drawing.Point(9, 26);
            this.dgGeneralReport.Name = "dgGeneralReport";
            this.dgGeneralReport.ReadOnly = true;
            this.dgGeneralReport.RowHeadersWidth = 45;
            this.dgGeneralReport.RowTemplate.Height = 24;
            this.dgGeneralReport.Size = new System.Drawing.Size(983, 408);
            this.dgGeneralReport.TabIndex = 0;
            // 
            // btnExportToCSV
            // 
            this.btnExportToCSV.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnExportToCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportToCSV.Location = new System.Drawing.Point(531, 29);
            this.btnExportToCSV.Name = "btnExportToCSV";
            this.btnExportToCSV.Size = new System.Drawing.Size(182, 36);
            this.btnExportToCSV.TabIndex = 1;
            this.btnExportToCSV.Text = "Export to CSV";
            this.btnExportToCSV.UseVisualStyleBackColor = false;
            this.btnExportToCSV.Click += new System.EventHandler(this.btnExportToCSV_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.Image = ((System.Drawing.Image)(resources.GetObject("btnStatistics.Image")));
            this.btnStatistics.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStatistics.Location = new System.Drawing.Point(790, 29);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(208, 36);
            this.btnStatistics.TabIndex = 2;
            this.btnStatistics.Text = "Calculate Statistics";
            this.btnStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistics.UseVisualStyleBackColor = false;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // frmGeneralReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1010, 539);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnExportToCSV);
            this.Controls.Add(this.grpbxGeneralReport);
            this.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmGeneralReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "General Report";
            this.Load += new System.EventHandler(this.frmGeneralReport_Load);
            this.grpbxGeneralReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgGeneralReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxGeneralReport;
        private System.Windows.Forms.DataGridView dgGeneralReport;
        private System.Windows.Forms.Button btnExportToCSV;
        private System.Windows.Forms.SaveFileDialog saveFdgExportToCSV;
        private System.Windows.Forms.Button btnStatistics;
    }
}