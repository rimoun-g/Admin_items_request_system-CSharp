namespace Admin_items.Forms.AdminToolsForms.subForms
{
    partial class frmUsers
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPw = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.txtUserLevel = new System.Windows.Forms.TextBox();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.txtRePw = new System.Windows.Forms.TextBox();
            this.lblRePw = new System.Windows.Forms.Label();
            this.lblLevelInformation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(56, 68);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(81, 21);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Username";
            // 
            // lblPw
            // 
            this.lblPw.AutoSize = true;
            this.lblPw.Location = new System.Drawing.Point(56, 106);
            this.lblPw.Name = "lblPw";
            this.lblPw.Size = new System.Drawing.Size(76, 21);
            this.lblPw.TabIndex = 1;
            this.lblPw.Text = "Password";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(56, 190);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(82, 21);
            this.lblLevel.TabIndex = 2;
            this.lblLevel.Text = "User Level";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(143, 65);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(269, 27);
            this.txtUserName.TabIndex = 3;
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            // 
            // txtPw
            // 
            this.txtPw.Location = new System.Drawing.Point(143, 106);
            this.txtPw.Name = "txtPw";
            this.txtPw.PasswordChar = '*';
            this.txtPw.Size = new System.Drawing.Size(269, 27);
            this.txtPw.TabIndex = 4;
            // 
            // txtUserLevel
            // 
            this.txtUserLevel.Location = new System.Drawing.Point(143, 190);
            this.txtUserLevel.Name = "txtUserLevel";
            this.txtUserLevel.Size = new System.Drawing.Size(269, 27);
            this.txtUserLevel.TabIndex = 5;
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSearchUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchUser.Location = new System.Drawing.Point(426, 64);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(70, 28);
            this.btnSearchUser.TabIndex = 6;
            this.btnSearchUser.Text = "Search";
            this.btnSearchUser.UseVisualStyleBackColor = false;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Location = new System.Drawing.Point(556, 66);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(154, 35);
            this.btnAddUser.TabIndex = 7;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.Location = new System.Drawing.Point(556, 121);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(154, 35);
            this.btnUpdateUser.TabIndex = 8;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Location = new System.Drawing.Point(556, 183);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(154, 35);
            this.btnDeleteUser.TabIndex = 9;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            // 
            // txtRePw
            // 
            this.txtRePw.Location = new System.Drawing.Point(143, 147);
            this.txtRePw.Name = "txtRePw";
            this.txtRePw.PasswordChar = '*';
            this.txtRePw.Size = new System.Drawing.Size(269, 27);
            this.txtRePw.TabIndex = 11;
            // 
            // lblRePw
            // 
            this.lblRePw.AutoSize = true;
            this.lblRePw.Location = new System.Drawing.Point(34, 150);
            this.lblRePw.Name = "lblRePw";
            this.lblRePw.Size = new System.Drawing.Size(98, 21);
            this.lblRePw.TabIndex = 10;
            this.lblRePw.Text = "Re-enter PW";
            // 
            // lblLevelInformation
            // 
            this.lblLevelInformation.AutoSize = true;
            this.lblLevelInformation.Location = new System.Drawing.Point(34, 238);
            this.lblLevelInformation.Name = "lblLevelInformation";
            this.lblLevelInformation.Size = new System.Drawing.Size(498, 21);
            this.lblLevelInformation.TabIndex = 12;
            this.lblLevelInformation.Text = "User Level: 1 = System administrator, 2 = Super user, 3 = Normal user";
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(755, 268);
            this.Controls.Add(this.lblLevelInformation);
            this.Controls.Add(this.txtRePw);
            this.Controls.Add(this.lblRePw);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnSearchUser);
            this.Controls.Add(this.txtUserLevel);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblPw);
            this.Controls.Add(this.lblUserName);
            this.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPw;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.TextBox txtUserLevel;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.TextBox txtRePw;
        private System.Windows.Forms.Label lblRePw;
        private System.Windows.Forms.Label lblLevelInformation;
    }
}