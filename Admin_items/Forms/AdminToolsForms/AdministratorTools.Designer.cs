namespace Admin_items.Forms
{
    partial class AdministratorTools
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
            this.SuspendLayout();
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUsers.Location = new System.Drawing.Point(45, 132);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(234, 198);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = false;
            // 
            // btnItems
            // 
            this.btnItems.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnItems.Location = new System.Drawing.Point(334, 132);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(234, 198);
            this.btnItems.TabIndex = 1;
            this.btnItems.Text = "Items";
            this.btnItems.UseVisualStyleBackColor = false;
            // 
            // AdministratorTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1097, 366);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.btnUsers);
            this.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "AdministratorTools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator Tools";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnItems;
    }
}