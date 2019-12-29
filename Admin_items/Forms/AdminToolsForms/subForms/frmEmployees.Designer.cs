namespace Admin_items.Forms.AdminToolsForms.subForms
{
    partial class frmEmployees
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
            this.lblCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.lblSection = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtEmpNum = new System.Windows.Forms.NumericUpDown();
            this.cmbxEmpJob = new System.Windows.Forms.ComboBox();
            this.cmbxDepartment = new System.Windows.Forms.ComboBox();
            this.cmbxSection = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpNum)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(38, 45);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(140, 21);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Employee Number";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(38, 95);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 21);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Location = new System.Drawing.Point(38, 155);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(65, 21);
            this.lblJob.TabIndex = 2;
            this.lblJob.Text = "Position";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(38, 206);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(93, 21);
            this.lblDept.TabIndex = 3;
            this.lblDept.Text = "Department";
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Location = new System.Drawing.Point(38, 259);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(61, 21);
            this.lblSection.TabIndex = 4;
            this.lblSection.Text = "Section";
            // 
            // txtEmpName
            // 
            this.txtEmpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpName.Location = new System.Drawing.Point(199, 92);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(521, 27);
            this.txtEmpName.TabIndex = 5;
            // 
            // txtEmpNum
            // 
            this.txtEmpNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpNum.Location = new System.Drawing.Point(199, 43);
            this.txtEmpNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtEmpNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtEmpNum.Name = "txtEmpNum";
            this.txtEmpNum.Size = new System.Drawing.Size(156, 27);
            this.txtEmpNum.TabIndex = 6;
            this.txtEmpNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbxEmpJob
            // 
            this.cmbxEmpJob.BackColor = System.Drawing.Color.Moccasin;
            this.cmbxEmpJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxEmpJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxEmpJob.FormattingEnabled = true;
            this.cmbxEmpJob.Location = new System.Drawing.Point(199, 148);
            this.cmbxEmpJob.Name = "cmbxEmpJob";
            this.cmbxEmpJob.Size = new System.Drawing.Size(521, 28);
            this.cmbxEmpJob.TabIndex = 7;
            // 
            // cmbxDepartment
            // 
            this.cmbxDepartment.BackColor = System.Drawing.Color.Moccasin;
            this.cmbxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxDepartment.FormattingEnabled = true;
            this.cmbxDepartment.Location = new System.Drawing.Point(199, 203);
            this.cmbxDepartment.Name = "cmbxDepartment";
            this.cmbxDepartment.Size = new System.Drawing.Size(521, 28);
            this.cmbxDepartment.TabIndex = 8;
            // 
            // cmbxSection
            // 
            this.cmbxSection.BackColor = System.Drawing.Color.Moccasin;
            this.cmbxSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxSection.FormattingEnabled = true;
            this.cmbxSection.Location = new System.Drawing.Point(199, 256);
            this.cmbxSection.Name = "cmbxSection";
            this.cmbxSection.Size = new System.Drawing.Size(521, 28);
            this.cmbxSection.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(220, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(316, 47);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add Employee";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(758, 398);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbxSection);
            this.Controls.Add(this.cmbxDepartment);
            this.Controls.Add(this.cmbxEmpJob);
            this.Controls.Add(this.txtEmpNum);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.lblSection);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCode);
            this.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEployees";
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.NumericUpDown txtEmpNum;
        private System.Windows.Forms.ComboBox cmbxEmpJob;
        private System.Windows.Forms.ComboBox cmbxDepartment;
        private System.Windows.Forms.ComboBox cmbxSection;
        private System.Windows.Forms.Button button1;
    }
}