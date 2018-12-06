namespace Stock_inventory_system
{
    partial class FrmTransaction
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
            this.lbl_TransID = new System.Windows.Forms.Label();
            this.txtBox_TransID = new System.Windows.Forms.TextBox();
            this.lbl_TransDate = new System.Windows.Forms.Label();
            this.dtp_TransDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.cBoxID = new System.Windows.Forms.ComboBox();
            this.lbl_GenerateName = new System.Windows.Forms.Label();
            this.dgvItemData = new System.Windows.Forms.DataGridView();
            this.Item_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_ItemData = new System.Windows.Forms.Label();
            this.lbl_TransactionGrid = new System.Windows.Forms.Label();
            this.dgvTransaction = new System.Windows.Forms.DataGridView();
            this.Trans_ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trans_ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IN_Ammount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity_After = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_QuantityTotal = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_Company = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TransID
            // 
            this.lbl_TransID.AutoSize = true;
            this.lbl_TransID.Location = new System.Drawing.Point(24, 60);
            this.lbl_TransID.Name = "lbl_TransID";
            this.lbl_TransID.Size = new System.Drawing.Size(100, 17);
            this.lbl_TransID.TabIndex = 0;
            this.lbl_TransID.Text = "Transaction ID";
            // 
            // txtBox_TransID
            // 
            this.txtBox_TransID.Enabled = false;
            this.txtBox_TransID.Location = new System.Drawing.Point(186, 57);
            this.txtBox_TransID.Name = "txtBox_TransID";
            this.txtBox_TransID.ReadOnly = true;
            this.txtBox_TransID.Size = new System.Drawing.Size(142, 22);
            this.txtBox_TransID.TabIndex = 1;
            // 
            // lbl_TransDate
            // 
            this.lbl_TransDate.AutoSize = true;
            this.lbl_TransDate.Location = new System.Drawing.Point(24, 99);
            this.lbl_TransDate.Name = "lbl_TransDate";
            this.lbl_TransDate.Size = new System.Drawing.Size(38, 17);
            this.lbl_TransDate.TabIndex = 2;
            this.lbl_TransDate.Text = "Date";
            // 
            // dtp_TransDate
            // 
            this.dtp_TransDate.Location = new System.Drawing.Point(186, 99);
            this.dtp_TransDate.Name = "dtp_TransDate";
            this.dtp_TransDate.Size = new System.Drawing.Size(142, 22);
            this.dtp_TransDate.TabIndex = 3;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(357, 60);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(51, 17);
            this.lbl_ID.TabIndex = 4;
            this.lbl_ID.Text = "{ ID ? }";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(357, 104);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(75, 17);
            this.lbl_Name.TabIndex = 5;
            this.lbl_Name.Text = "{ Name ? }";
            // 
            // cBoxID
            // 
            this.cBoxID.FormattingEnabled = true;
            this.cBoxID.Location = new System.Drawing.Point(482, 57);
            this.cBoxID.Name = "cBoxID";
            this.cBoxID.Size = new System.Drawing.Size(121, 24);
            this.cBoxID.TabIndex = 6;
            this.cBoxID.SelectedValueChanged += new System.EventHandler(this.cBoxID_SelectedValueChanged);
            // 
            // lbl_GenerateName
            // 
            this.lbl_GenerateName.AutoSize = true;
            this.lbl_GenerateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GenerateName.Location = new System.Drawing.Point(479, 104);
            this.lbl_GenerateName.Name = "lbl_GenerateName";
            this.lbl_GenerateName.Size = new System.Drawing.Size(71, 17);
            this.lbl_GenerateName.TabIndex = 7;
            this.lbl_GenerateName.Text = "{ Name }";
            // 
            // dgvItemData
            // 
            this.dgvItemData.AllowUserToAddRows = false;
            this.dgvItemData.AllowUserToDeleteRows = false;
            this.dgvItemData.AllowUserToResizeColumns = false;
            this.dgvItemData.AllowUserToResizeRows = false;
            this.dgvItemData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item_ID,
            this.Item_Name});
            this.dgvItemData.Location = new System.Drawing.Point(12, 186);
            this.dgvItemData.Name = "dgvItemData";
            this.dgvItemData.ReadOnly = true;
            this.dgvItemData.RowHeadersVisible = false;
            this.dgvItemData.RowTemplate.Height = 24;
            this.dgvItemData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemData.Size = new System.Drawing.Size(271, 327);
            this.dgvItemData.TabIndex = 8;
            this.dgvItemData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemData_CellClick);
            // 
            // Item_ID
            // 
            this.Item_ID.HeaderText = "Item_ID";
            this.Item_ID.Name = "Item_ID";
            this.Item_ID.ReadOnly = true;
            this.Item_ID.Width = 80;
            // 
            // Item_Name
            // 
            this.Item_Name.HeaderText = "Item_Name";
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.ReadOnly = true;
            this.Item_Name.Width = 120;
            // 
            // lbl_ItemData
            // 
            this.lbl_ItemData.AutoSize = true;
            this.lbl_ItemData.Location = new System.Drawing.Point(12, 166);
            this.lbl_ItemData.Name = "lbl_ItemData";
            this.lbl_ItemData.Size = new System.Drawing.Size(68, 17);
            this.lbl_ItemData.TabIndex = 9;
            this.lbl_ItemData.Text = "Item Data";
            // 
            // lbl_TransactionGrid
            // 
            this.lbl_TransactionGrid.AutoSize = true;
            this.lbl_TransactionGrid.Location = new System.Drawing.Point(286, 166);
            this.lbl_TransactionGrid.Name = "lbl_TransactionGrid";
            this.lbl_TransactionGrid.Size = new System.Drawing.Size(114, 17);
            this.lbl_TransactionGrid.TabIndex = 11;
            this.lbl_TransactionGrid.Text = "Transaction Grid";
            // 
            // dgvTransaction
            // 
            this.dgvTransaction.AllowUserToAddRows = false;
            this.dgvTransaction.AllowUserToDeleteRows = false;
            this.dgvTransaction.AllowUserToResizeColumns = false;
            this.dgvTransaction.AllowUserToResizeRows = false;
            this.dgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Trans_ItemID,
            this.Trans_ItemName,
            this.Quantity,
            this.IN_Ammount,
            this.Quantity_After});
            this.dgvTransaction.Location = new System.Drawing.Point(289, 186);
            this.dgvTransaction.Name = "dgvTransaction";
            this.dgvTransaction.RowHeadersVisible = false;
            this.dgvTransaction.RowTemplate.Height = 24;
            this.dgvTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTransaction.Size = new System.Drawing.Size(673, 230);
            this.dgvTransaction.TabIndex = 10;
            this.dgvTransaction.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransaction_CellEndEdit);
            this.dgvTransaction.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransaction_CellValueChanged);
            this.dgvTransaction.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvTransaction_EditingControlShowing);
            // 
            // Trans_ItemID
            // 
            this.Trans_ItemID.HeaderText = "Item_ID";
            this.Trans_ItemID.Name = "Trans_ItemID";
            this.Trans_ItemID.ReadOnly = true;
            // 
            // Trans_ItemName
            // 
            this.Trans_ItemName.HeaderText = "Item_Name";
            this.Trans_ItemName.Name = "Trans_ItemName";
            this.Trans_ItemName.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // IN_Ammount
            // 
            this.IN_Ammount.HeaderText = "IN_Ammount";
            this.IN_Ammount.Name = "IN_Ammount";
            // 
            // Quantity_After
            // 
            this.Quantity_After.HeaderText = "Quantity_After";
            this.Quantity_After.Name = "Quantity_After";
            this.Quantity_After.ReadOnly = true;
            // 
            // lbl_QuantityTotal
            // 
            this.lbl_QuantityTotal.AutoSize = true;
            this.lbl_QuantityTotal.Location = new System.Drawing.Point(783, 436);
            this.lbl_QuantityTotal.Name = "lbl_QuantityTotal";
            this.lbl_QuantityTotal.Size = new System.Drawing.Size(58, 17);
            this.lbl_QuantityTotal.TabIndex = 12;
            this.lbl_QuantityTotal.Text = "{ Total }";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(697, 436);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(40, 17);
            this.lbl_Total.TabIndex = 13;
            this.lbl_Total.Text = "Total";
            // 
            // lbl_Company
            // 
            this.lbl_Company.AutoSize = true;
            this.lbl_Company.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Company.Location = new System.Drawing.Point(393, 9);
            this.lbl_Company.Name = "lbl_Company";
            this.lbl_Company.Size = new System.Drawing.Size(127, 29);
            this.lbl_Company.TabIndex = 14;
            this.lbl_Company.Text = "PT. 17TI1";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(726, 473);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(115, 41);
            this.btn_Save.TabIndex = 15;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(847, 472);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(115, 41);
            this.btn_Cancel.TabIndex = 16;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // FrmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 525);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lbl_Company);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_QuantityTotal);
            this.Controls.Add(this.lbl_TransactionGrid);
            this.Controls.Add(this.dgvTransaction);
            this.Controls.Add(this.lbl_ItemData);
            this.Controls.Add(this.dgvItemData);
            this.Controls.Add(this.lbl_GenerateName);
            this.Controls.Add(this.cBoxID);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.dtp_TransDate);
            this.Controls.Add(this.lbl_TransDate);
            this.Controls.Add(this.txtBox_TransID);
            this.Controls.Add(this.lbl_TransID);
            this.Name = "FrmTransaction";
            this.Text = "FrmTransaction";
            this.Load += new System.EventHandler(this.FrmTransaction_IN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TransID;
        private System.Windows.Forms.TextBox txtBox_TransID;
        private System.Windows.Forms.Label lbl_TransDate;
        private System.Windows.Forms.DateTimePicker dtp_TransDate;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.ComboBox cBoxID;
        private System.Windows.Forms.Label lbl_GenerateName;
        private System.Windows.Forms.DataGridView dgvItemData;
        private System.Windows.Forms.Label lbl_ItemData;
        private System.Windows.Forms.Label lbl_TransactionGrid;
        private System.Windows.Forms.DataGridView dgvTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trans_ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trans_ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn IN_Ammount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_After;
        private System.Windows.Forms.Label lbl_QuantityTotal;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_Company;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
    }
}