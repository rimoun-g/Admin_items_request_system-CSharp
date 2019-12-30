namespace Admin_items.Forms
{
    partial class frmAdministratorTools
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
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.btnSubcats = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUsers.Location = new System.Drawing.Point(30, 125);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(241, 87);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnItems
            // 
            this.btnItems.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnItems.Location = new System.Drawing.Point(30, 245);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(241, 87);
            this.btnItems.TabIndex = 1;
            this.btnItems.Text = "Items";
            this.btnItems.UseVisualStyleBackColor = false;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnSubcats
            // 
            this.btnSubcats.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSubcats.Location = new System.Drawing.Point(294, 245);
            this.btnSubcats.Name = "btnSubcats";
            this.btnSubcats.Size = new System.Drawing.Size(234, 87);
            this.btnSubcats.TabIndex = 2;
            this.btnSubcats.Text = "Subcategories";
            this.btnSubcats.UseVisualStyleBackColor = false;
            this.btnSubcats.Click += new System.EventHandler(this.btnSubcats_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEmployees.Location = new System.Drawing.Point(294, 125);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(234, 87);
            this.btnEmployees.TabIndex = 3;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = false;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // frmAdministratorTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(564, 356);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnSubcats);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.btnUsers);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmAdministratorTools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator Tools";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.Button btnSubcats;
        private System.Windows.Forms.Button btnEmployees;
    }
}