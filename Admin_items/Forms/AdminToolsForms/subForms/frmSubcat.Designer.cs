namespace Admin_items.Forms.AdminToolsForms.subForms
{
    partial class frmSubcat
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
            this.lblItems = new System.Windows.Forms.Label();
            this.cmbxItems = new System.Windows.Forms.ComboBox();
            this.lblAddUpdateSubCat = new System.Windows.Forms.Label();
            this.txtAddUpdateSubCat = new System.Windows.Forms.TextBox();
            this.cmbxSubCats = new System.Windows.Forms.ComboBox();
            this.lblItemSubCat = new System.Windows.Forms.Label();
            this.btnAddSubCat = new System.Windows.Forms.Button();
            this.btnUpdateSubCat = new System.Windows.Forms.Button();
            this.btnDeleteSubCat = new System.Windows.Forms.Button();
            this.btnUndeleteSubCat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Location = new System.Drawing.Point(116, 52);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(48, 21);
            this.lblItems.TabIndex = 0;
            this.lblItems.Text = "Items";
            // 
            // cmbxItems
            // 
            this.cmbxItems.BackColor = System.Drawing.SystemColors.Control;
            this.cmbxItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxItems.FormattingEnabled = true;
            this.cmbxItems.Location = new System.Drawing.Point(181, 49);
            this.cmbxItems.Name = "cmbxItems";
            this.cmbxItems.Size = new System.Drawing.Size(508, 28);
            this.cmbxItems.TabIndex = 1;
            this.cmbxItems.SelectedIndexChanged += new System.EventHandler(this.cmbxItems_SelectedIndexChanged);
            // 
            // lblAddUpdateSubCat
            // 
            this.lblAddUpdateSubCat.AutoSize = true;
            this.lblAddUpdateSubCat.Location = new System.Drawing.Point(37, 227);
            this.lblAddUpdateSubCat.Name = "lblAddUpdateSubCat";
            this.lblAddUpdateSubCat.Size = new System.Drawing.Size(202, 21);
            this.lblAddUpdateSubCat.TabIndex = 2;
            this.lblAddUpdateSubCat.Text = "Add / Update Sub-Category";
            // 
            // txtAddUpdateSubCat
            // 
            this.txtAddUpdateSubCat.Location = new System.Drawing.Point(245, 224);
            this.txtAddUpdateSubCat.Name = "txtAddUpdateSubCat";
            this.txtAddUpdateSubCat.Size = new System.Drawing.Size(444, 27);
            this.txtAddUpdateSubCat.TabIndex = 3;
            // 
            // cmbxSubCats
            // 
            this.cmbxSubCats.BackColor = System.Drawing.SystemColors.Control;
            this.cmbxSubCats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSubCats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxSubCats.FormattingEnabled = true;
            this.cmbxSubCats.Location = new System.Drawing.Point(181, 96);
            this.cmbxSubCats.Name = "cmbxSubCats";
            this.cmbxSubCats.Size = new System.Drawing.Size(508, 28);
            this.cmbxSubCats.TabIndex = 4;
            this.cmbxSubCats.SelectedIndexChanged += new System.EventHandler(this.cmbxSubCats_SelectedIndexChanged);
            // 
            // lblItemSubCat
            // 
            this.lblItemSubCat.AutoSize = true;
            this.lblItemSubCat.Location = new System.Drawing.Point(58, 103);
            this.lblItemSubCat.Name = "lblItemSubCat";
            this.lblItemSubCat.Size = new System.Drawing.Size(106, 21);
            this.lblItemSubCat.TabIndex = 5;
            this.lblItemSubCat.Text = "Sub-Category";
            // 
            // btnAddSubCat
            // 
            this.btnAddSubCat.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddSubCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSubCat.Location = new System.Drawing.Point(245, 278);
            this.btnAddSubCat.Name = "btnAddSubCat";
            this.btnAddSubCat.Size = new System.Drawing.Size(203, 38);
            this.btnAddSubCat.TabIndex = 6;
            this.btnAddSubCat.Text = "Add Sub. Category";
            this.btnAddSubCat.UseVisualStyleBackColor = false;
            this.btnAddSubCat.Click += new System.EventHandler(this.btnAddSubCat_Click);
            // 
            // btnUpdateSubCat
            // 
            this.btnUpdateSubCat.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdateSubCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSubCat.Location = new System.Drawing.Point(469, 278);
            this.btnUpdateSubCat.Name = "btnUpdateSubCat";
            this.btnUpdateSubCat.Size = new System.Drawing.Size(220, 38);
            this.btnUpdateSubCat.TabIndex = 7;
            this.btnUpdateSubCat.Text = "Update Sub. Category";
            this.btnUpdateSubCat.UseVisualStyleBackColor = false;
            this.btnUpdateSubCat.Click += new System.EventHandler(this.btnUpdateSubCat_Click);
            // 
            // btnDeleteSubCat
            // 
            this.btnDeleteSubCat.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDeleteSubCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSubCat.Location = new System.Drawing.Point(245, 150);
            this.btnDeleteSubCat.Name = "btnDeleteSubCat";
            this.btnDeleteSubCat.Size = new System.Drawing.Size(203, 38);
            this.btnDeleteSubCat.TabIndex = 8;
            this.btnDeleteSubCat.Text = "Delete Sub. Category";
            this.btnDeleteSubCat.UseVisualStyleBackColor = false;
            this.btnDeleteSubCat.Click += new System.EventHandler(this.btnDeleteSubCat_Click);
            // 
            // btnUndeleteSubCat
            // 
            this.btnUndeleteSubCat.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUndeleteSubCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUndeleteSubCat.Location = new System.Drawing.Point(469, 150);
            this.btnUndeleteSubCat.Name = "btnUndeleteSubCat";
            this.btnUndeleteSubCat.Size = new System.Drawing.Size(220, 38);
            this.btnUndeleteSubCat.TabIndex = 9;
            this.btnUndeleteSubCat.Text = "Undo Delete Sub. Category";
            this.btnUndeleteSubCat.UseVisualStyleBackColor = false;
            this.btnUndeleteSubCat.Click += new System.EventHandler(this.btnUndeleteSubCat_Click);
            // 
            // frmSubcat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(772, 363);
            this.Controls.Add(this.btnUndeleteSubCat);
            this.Controls.Add(this.btnDeleteSubCat);
            this.Controls.Add(this.btnUpdateSubCat);
            this.Controls.Add(this.btnAddSubCat);
            this.Controls.Add(this.lblItemSubCat);
            this.Controls.Add(this.cmbxSubCats);
            this.Controls.Add(this.txtAddUpdateSubCat);
            this.Controls.Add(this.lblAddUpdateSubCat);
            this.Controls.Add(this.cmbxItems);
            this.Controls.Add(this.lblItems);
            this.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmSubcat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Items Subcategories";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.ComboBox cmbxItems;
        private System.Windows.Forms.Label lblAddUpdateSubCat;
        private System.Windows.Forms.TextBox txtAddUpdateSubCat;
        private System.Windows.Forms.ComboBox cmbxSubCats;
        private System.Windows.Forms.Label lblItemSubCat;
        private System.Windows.Forms.Button btnAddSubCat;
        private System.Windows.Forms.Button btnUpdateSubCat;
        private System.Windows.Forms.Button btnDeleteSubCat;
        private System.Windows.Forms.Button btnUndeleteSubCat;
    }
}