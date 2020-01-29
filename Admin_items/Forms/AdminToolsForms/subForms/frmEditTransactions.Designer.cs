namespace Admin_items.Forms.AdminToolsForms.subForms
{
    partial class frmEditTransactions
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
            this.chklstbxTransactions = new System.Windows.Forms.CheckedListBox();
            this.lstbxTransID = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chklstbxTransactions
            // 
            this.chklstbxTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chklstbxTransactions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chklstbxTransactions.FormattingEnabled = true;
            this.chklstbxTransactions.HorizontalScrollbar = true;
            this.chklstbxTransactions.Location = new System.Drawing.Point(12, 21);
            this.chklstbxTransactions.Name = "chklstbxTransactions";
            this.chklstbxTransactions.Size = new System.Drawing.Size(943, 376);
            this.chklstbxTransactions.TabIndex = 0;
            // 
            // lstbxTransID
            // 
            this.lstbxTransID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstbxTransID.FormattingEnabled = true;
            this.lstbxTransID.ItemHeight = 20;
            this.lstbxTransID.Location = new System.Drawing.Point(12, 21);
            this.lstbxTransID.Name = "lstbxTransID";
            this.lstbxTransID.Size = new System.Drawing.Size(46, 442);
            this.lstbxTransID.TabIndex = 1;
            this.lstbxTransID.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(317, 415);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(323, 48);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmEditTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(969, 479);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lstbxTransID);
            this.Controls.Add(this.chklstbxTransactions);
            this.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmEditTransactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Transactions";
            this.Load += new System.EventHandler(this.frmEditTransactions_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chklstbxTransactions;
        private System.Windows.Forms.ListBox lstbxTransID;
        private System.Windows.Forms.Button btnDelete;
    }
}