namespace Stock_inventory_system
{
    partial class FrmItemData
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
            this.dgvItemData = new System.Windows.Forms.DataGridView();
            this.Item_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemData)).BeginInit();
            this.SuspendLayout();
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
            this.Item_Name,
            this.Quantity});
            this.dgvItemData.Location = new System.Drawing.Point(12, 145);
            this.dgvItemData.Name = "dgvItemData";
            this.dgvItemData.ReadOnly = true;
            this.dgvItemData.RowHeadersVisible = false;
            this.dgvItemData.RowTemplate.Height = 24;
            this.dgvItemData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemData.Size = new System.Drawing.Size(776, 293);
            this.dgvItemData.TabIndex = 0;
            this.dgvItemData.Resize += new System.EventHandler(this.dgvItemData_Resize);
            // 
            // Item_ID
            // 
            this.Item_ID.HeaderText = "Item_ID";
            this.Item_ID.Name = "Item_ID";
            this.Item_ID.ReadOnly = true;
            // 
            // Item_Name
            // 
            this.Item_Name.HeaderText = "Item_Name";
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(12, 12);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(155, 61);
            this.btnAddItem.TabIndex = 1;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnEditItem
            // 
            this.btnEditItem.Location = new System.Drawing.Point(173, 12);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(155, 61);
            this.btnEditItem.TabIndex = 2;
            this.btnEditItem.Text = "Edit Item";
            this.btnEditItem.UseVisualStyleBackColor = true;
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(334, 12);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(155, 61);
            this.btnDeleteItem.TabIndex = 3;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // FrmItemData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnEditItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.dgvItemData);
            this.Name = "FrmItemData";
            this.Text = "FrmItemData";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmItemData_FormClosing);
            this.Load += new System.EventHandler(this.FrmItemData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItemData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnEditItem;
        private System.Windows.Forms.Button btnDeleteItem;
    }
}