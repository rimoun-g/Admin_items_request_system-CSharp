namespace Admin_items.Forms.DataEntry
{
    partial class frmDataEntry
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
            this.grpbxEntryTools = new System.Windows.Forms.GroupBox();
            this.cmbxSubCats = new System.Windows.Forms.ComboBox();
            this.cmbxItems = new System.Windows.Forms.ComboBox();
            this.txtValue = new System.Windows.Forms.NumericUpDown();
            this.txtEmpNumber = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblEmployeeNumber = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblSubCats = new System.Windows.Forms.Label();
            this.lblItems = new System.Windows.Forms.Label();
            this.grpbxEmployeeRecord = new System.Windows.Forms.GroupBox();
            this.dgEmployeeRecord = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEmployeeInfo = new System.Windows.Forms.Label();
            this.grpbxEntryTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).BeginInit();
            this.grpbxEmployeeRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployeeRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbxEntryTools
            // 
            this.grpbxEntryTools.Controls.Add(this.cmbxSubCats);
            this.grpbxEntryTools.Controls.Add(this.cmbxItems);
            this.grpbxEntryTools.Controls.Add(this.txtValue);
            this.grpbxEntryTools.Controls.Add(this.txtEmpNumber);
            this.grpbxEntryTools.Controls.Add(this.txtQuantity);
            this.grpbxEntryTools.Controls.Add(this.lblQuantity);
            this.grpbxEntryTools.Controls.Add(this.lblEmployeeNumber);
            this.grpbxEntryTools.Controls.Add(this.lblValue);
            this.grpbxEntryTools.Controls.Add(this.lblSubCats);
            this.grpbxEntryTools.Controls.Add(this.lblItems);
            this.grpbxEntryTools.Location = new System.Drawing.Point(12, 25);
            this.grpbxEntryTools.Name = "grpbxEntryTools";
            this.grpbxEntryTools.Size = new System.Drawing.Size(810, 372);
            this.grpbxEntryTools.TabIndex = 0;
            this.grpbxEntryTools.TabStop = false;
            this.grpbxEntryTools.Text = "Entry Tools";
            // 
            // cmbxSubCats
            // 
            this.cmbxSubCats.BackColor = System.Drawing.SystemColors.Control;
            this.cmbxSubCats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxSubCats.FormattingEnabled = true;
            this.cmbxSubCats.Location = new System.Drawing.Point(129, 181);
            this.cmbxSubCats.Name = "cmbxSubCats";
            this.cmbxSubCats.Size = new System.Drawing.Size(483, 28);
            this.cmbxSubCats.TabIndex = 3;
            // 
            // cmbxItems
            // 
            this.cmbxItems.BackColor = System.Drawing.SystemColors.Control;
            this.cmbxItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxItems.FormattingEnabled = true;
            this.cmbxItems.Location = new System.Drawing.Point(129, 127);
            this.cmbxItems.Name = "cmbxItems";
            this.cmbxItems.Size = new System.Drawing.Size(483, 28);
            this.cmbxItems.TabIndex = 2;
            this.cmbxItems.SelectedIndexChanged += new System.EventHandler(this.cmbxItems_SelectedIndexChanged);
            // 
            // txtValue
            // 
            this.txtValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValue.DecimalPlaces = 2;
            this.txtValue.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtValue.Location = new System.Drawing.Point(129, 236);
            this.txtValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(120, 27);
            this.txtValue.TabIndex = 4;
            this.txtValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtEmpNumber
            // 
            this.txtEmpNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtEmpNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpNumber.Location = new System.Drawing.Point(225, 59);
            this.txtEmpNumber.Name = "txtEmpNumber";
            this.txtEmpNumber.Size = new System.Drawing.Size(320, 27);
            this.txtEmpNumber.TabIndex = 1;
            this.txtEmpNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmpNumber_KeyDown);
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Location = new System.Drawing.Point(129, 291);
            this.txtQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(120, 27);
            this.txtQuantity.TabIndex = 5;
            this.txtQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(19, 293);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(70, 21);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblEmployeeNumber
            // 
            this.lblEmployeeNumber.AutoSize = true;
            this.lblEmployeeNumber.Location = new System.Drawing.Point(29, 61);
            this.lblEmployeeNumber.Name = "lblEmployeeNumber";
            this.lblEmployeeNumber.Size = new System.Drawing.Size(179, 21);
            this.lblEmployeeNumber.TabIndex = 3;
            this.lblEmployeeNumber.Text = "Emplotyee Code - Name";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(19, 238);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(48, 21);
            this.lblValue.TabIndex = 2;
            this.lblValue.Text = "Value";
            // 
            // lblSubCats
            // 
            this.lblSubCats.AutoSize = true;
            this.lblSubCats.Location = new System.Drawing.Point(19, 184);
            this.lblSubCats.Name = "lblSubCats";
            this.lblSubCats.Size = new System.Drawing.Size(97, 21);
            this.lblSubCats.TabIndex = 1;
            this.lblSubCats.Text = "Subcategory";
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Location = new System.Drawing.Point(19, 130);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(48, 21);
            this.lblItems.TabIndex = 0;
            this.lblItems.Text = "Items";
            // 
            // grpbxEmployeeRecord
            // 
            this.grpbxEmployeeRecord.Controls.Add(this.dgEmployeeRecord);
            this.grpbxEmployeeRecord.Controls.Add(this.lblEmployeeInfo);
            this.grpbxEmployeeRecord.Location = new System.Drawing.Point(12, 417);
            this.grpbxEmployeeRecord.Name = "grpbxEmployeeRecord";
            this.grpbxEmployeeRecord.Size = new System.Drawing.Size(810, 386);
            this.grpbxEmployeeRecord.TabIndex = 1;
            this.grpbxEmployeeRecord.TabStop = false;
            this.grpbxEmployeeRecord.Text = "Employee Record";
            // 
            // dgEmployeeRecord
            // 
            this.dgEmployeeRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployeeRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.item,
            this.sub_item,
            this.value,
            this.quantity,
            this.date});
            this.dgEmployeeRecord.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgEmployeeRecord.Location = new System.Drawing.Point(19, 80);
            this.dgEmployeeRecord.Name = "dgEmployeeRecord";
            this.dgEmployeeRecord.ReadOnly = true;
            this.dgEmployeeRecord.RowHeadersWidth = 45;
            this.dgEmployeeRecord.RowTemplate.Height = 24;
            this.dgEmployeeRecord.Size = new System.Drawing.Size(780, 300);
            this.dgEmployeeRecord.TabIndex = 1;
            // 
            // id
            // 
            this.id.Frozen = true;
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 110;
            // 
            // item
            // 
            this.item.Frozen = true;
            this.item.HeaderText = "item";
            this.item.MinimumWidth = 6;
            this.item.Name = "item";
            this.item.ReadOnly = true;
            this.item.Width = 110;
            // 
            // sub_item
            // 
            this.sub_item.Frozen = true;
            this.sub_item.HeaderText = "Sub Item";
            this.sub_item.MinimumWidth = 6;
            this.sub_item.Name = "sub_item";
            this.sub_item.ReadOnly = true;
            this.sub_item.Width = 110;
            // 
            // value
            // 
            this.value.Frozen = true;
            this.value.HeaderText = "Value";
            this.value.MinimumWidth = 6;
            this.value.Name = "value";
            this.value.ReadOnly = true;
            this.value.Width = 110;
            // 
            // quantity
            // 
            this.quantity.Frozen = true;
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 110;
            // 
            // date
            // 
            this.date.Frozen = true;
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 110;
            // 
            // lblEmployeeInfo
            // 
            this.lblEmployeeInfo.AutoSize = true;
            this.lblEmployeeInfo.Location = new System.Drawing.Point(15, 42);
            this.lblEmployeeInfo.Name = "lblEmployeeInfo";
            this.lblEmployeeInfo.Size = new System.Drawing.Size(112, 21);
            this.lblEmployeeInfo.TabIndex = 0;
            this.lblEmployeeInfo.Text = "Employee Info:";
            // 
            // frmDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(837, 814);
            this.Controls.Add(this.grpbxEmployeeRecord);
            this.Controls.Add(this.grpbxEntryTools);
            this.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmDataEntry";
            this.Text = "Data Entry";
            this.grpbxEntryTools.ResumeLayout(false);
            this.grpbxEntryTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).EndInit();
            this.grpbxEmployeeRecord.ResumeLayout(false);
            this.grpbxEmployeeRecord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployeeRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxEntryTools;
        private System.Windows.Forms.Label lblEmployeeNumber;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblSubCats;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.GroupBox grpbxEmployeeRecord;
        private System.Windows.Forms.NumericUpDown txtValue;
        private System.Windows.Forms.TextBox txtEmpNumber;
        private System.Windows.Forms.NumericUpDown txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ComboBox cmbxSubCats;
        private System.Windows.Forms.ComboBox cmbxItems;
        private System.Windows.Forms.DataGridView dgEmployeeRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn sub_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.Label lblEmployeeInfo;
    }
}