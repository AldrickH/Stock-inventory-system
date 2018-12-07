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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItemData));
            this.dgvItemData = new System.Windows.Forms.DataGridView();
            this.Item_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.gBoxClose = new System.Windows.Forms.GroupBox();
            this.toolStripClose = new System.Windows.Forms.ToolStrip();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.gBoxAction = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemData)).BeginInit();
            this.gBoxClose.SuspendLayout();
            this.toolStripClose.SuspendLayout();
            this.gBoxAction.SuspendLayout();
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
            this.dgvItemData.Location = new System.Drawing.Point(12, 117);
            this.dgvItemData.Name = "dgvItemData";
            this.dgvItemData.ReadOnly = true;
            this.dgvItemData.RowHeadersVisible = false;
            this.dgvItemData.RowTemplate.Height = 24;
            this.dgvItemData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemData.Size = new System.Drawing.Size(776, 321);
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
            this.btnAddItem.Location = new System.Drawing.Point(6, 24);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(155, 61);
            this.btnAddItem.TabIndex = 1;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnEditItem
            // 
            this.btnEditItem.Location = new System.Drawing.Point(167, 24);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(155, 61);
            this.btnEditItem.TabIndex = 2;
            this.btnEditItem.Text = "Edit Item";
            this.btnEditItem.UseVisualStyleBackColor = true;
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(328, 24);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(155, 61);
            this.btnDeleteItem.TabIndex = 3;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // gBoxClose
            // 
            this.gBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxClose.Controls.Add(this.toolStripClose);
            this.gBoxClose.Location = new System.Drawing.Point(682, 12);
            this.gBoxClose.Name = "gBoxClose";
            this.gBoxClose.Size = new System.Drawing.Size(106, 99);
            this.gBoxClose.TabIndex = 6;
            this.gBoxClose.TabStop = false;
            this.gBoxClose.Text = "Close";
            // 
            // toolStripClose
            // 
            this.toolStripClose.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripClose.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripClose.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripClose.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClose});
            this.toolStripClose.Location = new System.Drawing.Point(3, 18);
            this.toolStripClose.Name = "toolStripClose";
            this.toolStripClose.Size = new System.Drawing.Size(78, 63);
            this.toolStripClose.TabIndex = 0;
            this.toolStripClose.Text = "toolStrip1";
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = false;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 60);
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gBoxAction
            // 
            this.gBoxAction.Controls.Add(this.btnAddItem);
            this.gBoxAction.Controls.Add(this.btnEditItem);
            this.gBoxAction.Controls.Add(this.btnDeleteItem);
            this.gBoxAction.Location = new System.Drawing.Point(12, 12);
            this.gBoxAction.Name = "gBoxAction";
            this.gBoxAction.Size = new System.Drawing.Size(493, 99);
            this.gBoxAction.TabIndex = 14;
            this.gBoxAction.TabStop = false;
            this.gBoxAction.Text = "Action";
            // 
            // FrmItemData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gBoxAction);
            this.Controls.Add(this.gBoxClose);
            this.Controls.Add(this.dgvItemData);
            this.Name = "FrmItemData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmItemData";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmItemData_FormClosing);
            this.Load += new System.EventHandler(this.FrmItemData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemData)).EndInit();
            this.gBoxClose.ResumeLayout(false);
            this.gBoxClose.PerformLayout();
            this.toolStripClose.ResumeLayout(false);
            this.toolStripClose.PerformLayout();
            this.gBoxAction.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox gBoxClose;
        private System.Windows.Forms.ToolStrip toolStripClose;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.GroupBox gBoxAction;
    }
}