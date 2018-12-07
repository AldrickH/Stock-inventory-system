namespace Stock_inventory_system
{
    partial class FrmSuppData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSuppData));
            this.btnDeleteSupp = new System.Windows.Forms.Button();
            this.btnEditSupp = new System.Windows.Forms.Button();
            this.btnAddSupp = new System.Windows.Forms.Button();
            this.dgvSuppData = new System.Windows.Forms.DataGridView();
            this.Supplier_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBoxClose = new System.Windows.Forms.GroupBox();
            this.toolStripClose = new System.Windows.Forms.ToolStrip();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.gBoxAction = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppData)).BeginInit();
            this.gBoxClose.SuspendLayout();
            this.toolStripClose.SuspendLayout();
            this.gBoxAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteSupp
            // 
            this.btnDeleteSupp.Location = new System.Drawing.Point(328, 21);
            this.btnDeleteSupp.Name = "btnDeleteSupp";
            this.btnDeleteSupp.Size = new System.Drawing.Size(155, 61);
            this.btnDeleteSupp.TabIndex = 7;
            this.btnDeleteSupp.Text = "Delete Supplier";
            this.btnDeleteSupp.UseVisualStyleBackColor = true;
            this.btnDeleteSupp.Click += new System.EventHandler(this.btnDeleteSupp_Click);
            // 
            // btnEditSupp
            // 
            this.btnEditSupp.Location = new System.Drawing.Point(167, 21);
            this.btnEditSupp.Name = "btnEditSupp";
            this.btnEditSupp.Size = new System.Drawing.Size(155, 61);
            this.btnEditSupp.TabIndex = 6;
            this.btnEditSupp.Text = "Edit Supplier";
            this.btnEditSupp.UseVisualStyleBackColor = true;
            this.btnEditSupp.Click += new System.EventHandler(this.btnEditSupp_Click);
            // 
            // btnAddSupp
            // 
            this.btnAddSupp.Location = new System.Drawing.Point(6, 21);
            this.btnAddSupp.Name = "btnAddSupp";
            this.btnAddSupp.Size = new System.Drawing.Size(155, 61);
            this.btnAddSupp.TabIndex = 5;
            this.btnAddSupp.Text = "Add Supplier";
            this.btnAddSupp.UseVisualStyleBackColor = true;
            this.btnAddSupp.Click += new System.EventHandler(this.btnAddSupp_Click);
            // 
            // dgvSuppData
            // 
            this.dgvSuppData.AllowUserToAddRows = false;
            this.dgvSuppData.AllowUserToDeleteRows = false;
            this.dgvSuppData.AllowUserToResizeColumns = false;
            this.dgvSuppData.AllowUserToResizeRows = false;
            this.dgvSuppData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Supplier_ID,
            this.Supplier_Name,
            this.Supplier_Address});
            this.dgvSuppData.Location = new System.Drawing.Point(12, 117);
            this.dgvSuppData.Name = "dgvSuppData";
            this.dgvSuppData.ReadOnly = true;
            this.dgvSuppData.RowHeadersVisible = false;
            this.dgvSuppData.RowTemplate.Height = 24;
            this.dgvSuppData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuppData.Size = new System.Drawing.Size(776, 321);
            this.dgvSuppData.TabIndex = 4;
            this.dgvSuppData.Resize += new System.EventHandler(this.dgvSuppData_Resize);
            // 
            // Supplier_ID
            // 
            this.Supplier_ID.HeaderText = "Supplier_ID";
            this.Supplier_ID.Name = "Supplier_ID";
            this.Supplier_ID.ReadOnly = true;
            // 
            // Supplier_Name
            // 
            this.Supplier_Name.HeaderText = "Supplier_Name";
            this.Supplier_Name.Name = "Supplier_Name";
            this.Supplier_Name.ReadOnly = true;
            this.Supplier_Name.Width = 150;
            // 
            // Supplier_Address
            // 
            this.Supplier_Address.HeaderText = "Supplier_Address";
            this.Supplier_Address.Name = "Supplier_Address";
            this.Supplier_Address.ReadOnly = true;
            this.Supplier_Address.Width = 200;
            // 
            // gBoxClose
            // 
            this.gBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxClose.Controls.Add(this.toolStripClose);
            this.gBoxClose.Location = new System.Drawing.Point(682, 12);
            this.gBoxClose.Name = "gBoxClose";
            this.gBoxClose.Size = new System.Drawing.Size(106, 99);
            this.gBoxClose.TabIndex = 8;
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
            this.gBoxAction.Controls.Add(this.btnAddSupp);
            this.gBoxAction.Controls.Add(this.btnEditSupp);
            this.gBoxAction.Controls.Add(this.btnDeleteSupp);
            this.gBoxAction.Location = new System.Drawing.Point(12, 12);
            this.gBoxAction.Name = "gBoxAction";
            this.gBoxAction.Size = new System.Drawing.Size(492, 99);
            this.gBoxAction.TabIndex = 14;
            this.gBoxAction.TabStop = false;
            this.gBoxAction.Text = "Action";
            // 
            // FrmSuppData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gBoxAction);
            this.Controls.Add(this.gBoxClose);
            this.Controls.Add(this.dgvSuppData);
            this.Name = "FrmSuppData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSuppData";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSuppData_FormClosing);
            this.Load += new System.EventHandler(this.FrmSuppData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppData)).EndInit();
            this.gBoxClose.ResumeLayout(false);
            this.gBoxClose.PerformLayout();
            this.toolStripClose.ResumeLayout(false);
            this.toolStripClose.PerformLayout();
            this.gBoxAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteSupp;
        private System.Windows.Forms.Button btnEditSupp;
        private System.Windows.Forms.Button btnAddSupp;
        private System.Windows.Forms.DataGridView dgvSuppData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier_Address;
        private System.Windows.Forms.GroupBox gBoxClose;
        private System.Windows.Forms.ToolStrip toolStripClose;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.GroupBox gBoxAction;
    }
}