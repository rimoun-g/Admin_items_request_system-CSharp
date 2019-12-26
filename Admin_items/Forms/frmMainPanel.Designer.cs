namespace Admin_items.Forms
{
    partial class frmMainPanel
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
            this.btnAddTransactionsForm = new System.Windows.Forms.Button();
            this.btnAdminToolsForm = new System.Windows.Forms.Button();
            this.btnReportsForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddTransactionsForm
            // 
            this.btnAddTransactionsForm.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAddTransactionsForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddTransactionsForm.Location = new System.Drawing.Point(98, 132);
            this.btnAddTransactionsForm.Name = "btnAddTransactionsForm";
            this.btnAddTransactionsForm.Size = new System.Drawing.Size(210, 163);
            this.btnAddTransactionsForm.TabIndex = 0;
            this.btnAddTransactionsForm.Text = "Add Transactions";
            this.btnAddTransactionsForm.UseVisualStyleBackColor = false;
            this.btnAddTransactionsForm.Click += new System.EventHandler(this.btnAddTransactionsForm_Click);
            // 
            // btnAdminToolsForm
            // 
            this.btnAdminToolsForm.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAdminToolsForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdminToolsForm.Location = new System.Drawing.Point(420, 131);
            this.btnAdminToolsForm.Name = "btnAdminToolsForm";
            this.btnAdminToolsForm.Size = new System.Drawing.Size(210, 163);
            this.btnAdminToolsForm.TabIndex = 1;
            this.btnAdminToolsForm.Text = "Admin Tools";
            this.btnAdminToolsForm.UseVisualStyleBackColor = false;
            this.btnAdminToolsForm.Click += new System.EventHandler(this.btnAdminToolsForm_Click);
            // 
            // btnReportsForm
            // 
            this.btnReportsForm.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnReportsForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReportsForm.Location = new System.Drawing.Point(739, 132);
            this.btnReportsForm.Name = "btnReportsForm";
            this.btnReportsForm.Size = new System.Drawing.Size(210, 163);
            this.btnReportsForm.TabIndex = 2;
            this.btnReportsForm.Text = "Reports";
            this.btnReportsForm.UseVisualStyleBackColor = false;
            // 
            // frmMainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 424);
            this.Controls.Add(this.btnReportsForm);
            this.Controls.Add(this.btnAdminToolsForm);
            this.Controls.Add(this.btnAddTransactionsForm);
            this.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmMainPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainPanel_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddTransactionsForm;
        private System.Windows.Forms.Button btnAdminToolsForm;
        private System.Windows.Forms.Button btnReportsForm;
    }
}