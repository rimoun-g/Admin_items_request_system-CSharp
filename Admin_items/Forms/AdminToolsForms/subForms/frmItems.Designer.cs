namespace Admin_items.Forms.AdminToolsForms.subForms
{
    partial class frmItems
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
            this.lblAddItem = new System.Windows.Forms.Label();
            this.txtAddItem = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.cmbxDeleteItem = new System.Windows.Forms.ComboBox();
            this.lblDeleteItem = new System.Windows.Forms.Label();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnUndeleteItem = new System.Windows.Forms.Button();
            this.btnUpdateItem = new System.Windows.Forms.Button();
            this.txtUpdateItem = new System.Windows.Forms.TextBox();
            this.lblUpdateItem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAddItem
            // 
            this.lblAddItem.AutoSize = true;
            this.lblAddItem.Location = new System.Drawing.Point(23, 69);
            this.lblAddItem.Name = "lblAddItem";
            this.lblAddItem.Size = new System.Drawing.Size(73, 21);
            this.lblAddItem.TabIndex = 0;
            this.lblAddItem.Text = "Add Item";
            // 
            // txtAddItem
            // 
            this.txtAddItem.Location = new System.Drawing.Point(132, 69);
            this.txtAddItem.Name = "txtAddItem";
            this.txtAddItem.Size = new System.Drawing.Size(493, 27);
            this.txtAddItem.TabIndex = 1;
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Location = new System.Drawing.Point(659, 62);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(159, 40);
            this.btnAddItem.TabIndex = 2;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // cmbxDeleteItem
            // 
            this.cmbxDeleteItem.BackColor = System.Drawing.SystemColors.Control;
            this.cmbxDeleteItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxDeleteItem.FormattingEnabled = true;
            this.cmbxDeleteItem.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cmbxDeleteItem.Location = new System.Drawing.Point(132, 145);
            this.cmbxDeleteItem.Name = "cmbxDeleteItem";
            this.cmbxDeleteItem.Size = new System.Drawing.Size(493, 28);
            this.cmbxDeleteItem.TabIndex = 3;
            this.cmbxDeleteItem.SelectedIndexChanged += new System.EventHandler(this.cmbxDeleteItem_SelectedIndexChanged);
            // 
            // lblDeleteItem
            // 
            this.lblDeleteItem.AutoSize = true;
            this.lblDeleteItem.Location = new System.Drawing.Point(23, 148);
            this.lblDeleteItem.Name = "lblDeleteItem";
            this.lblDeleteItem.Size = new System.Drawing.Size(73, 21);
            this.lblDeleteItem.TabIndex = 4;
            this.lblDeleteItem.Text = "Add Item";
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteItem.Location = new System.Drawing.Point(659, 138);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(159, 40);
            this.btnDeleteItem.TabIndex = 5;
            this.btnDeleteItem.Text = "Delete Selected Item";
            this.btnDeleteItem.UseVisualStyleBackColor = false;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnUndeleteItem
            // 
            this.btnUndeleteItem.BackColor = System.Drawing.SystemColors.Control;
            this.btnUndeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUndeleteItem.Location = new System.Drawing.Point(659, 194);
            this.btnUndeleteItem.Name = "btnUndeleteItem";
            this.btnUndeleteItem.Size = new System.Drawing.Size(159, 40);
            this.btnUndeleteItem.TabIndex = 6;
            this.btnUndeleteItem.Text = "Undo deleted Item";
            this.btnUndeleteItem.UseVisualStyleBackColor = false;
            this.btnUndeleteItem.Click += new System.EventHandler(this.btnUndeleteItem_Click);
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdateItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateItem.Location = new System.Drawing.Point(644, 271);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(186, 40);
            this.btnUpdateItem.TabIndex = 9;
            this.btnUpdateItem.Text = "Update Selected Item";
            this.btnUpdateItem.UseVisualStyleBackColor = false;
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click);
            // 
            // txtUpdateItem
            // 
            this.txtUpdateItem.Location = new System.Drawing.Point(132, 278);
            this.txtUpdateItem.Name = "txtUpdateItem";
            this.txtUpdateItem.Size = new System.Drawing.Size(493, 27);
            this.txtUpdateItem.TabIndex = 8;
            // 
            // lblUpdateItem
            // 
            this.lblUpdateItem.AutoSize = true;
            this.lblUpdateItem.Location = new System.Drawing.Point(23, 278);
            this.lblUpdateItem.Name = "lblUpdateItem";
            this.lblUpdateItem.Size = new System.Drawing.Size(95, 21);
            this.lblUpdateItem.TabIndex = 7;
            this.lblUpdateItem.Text = "Update Item";
            // 
            // frmItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(855, 383);
            this.Controls.Add(this.btnUpdateItem);
            this.Controls.Add(this.txtUpdateItem);
            this.Controls.Add(this.lblUpdateItem);
            this.Controls.Add(this.btnUndeleteItem);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.lblDeleteItem);
            this.Controls.Add(this.cmbxDeleteItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.txtAddItem);
            this.Controls.Add(this.lblAddItem);
            this.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmItems";
            this.Load += new System.EventHandler(this.frmItems_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddItem;
        private System.Windows.Forms.TextBox txtAddItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ComboBox cmbxDeleteItem;
        private System.Windows.Forms.Label lblDeleteItem;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnUndeleteItem;
        private System.Windows.Forms.Button btnUpdateItem;
        private System.Windows.Forms.TextBox txtUpdateItem;
        private System.Windows.Forms.Label lblUpdateItem;
    }
}