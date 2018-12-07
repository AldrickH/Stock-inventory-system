namespace Stock_inventory_system
{
    partial class FrmCustData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustData));
            this.btnDeleteCust = new System.Windows.Forms.Button();
            this.btnEditCust = new System.Windows.Forms.Button();
            this.btnAddCust = new System.Windows.Forms.Button();
            this.dgvCustData = new System.Windows.Forms.DataGridView();
            this.Customer_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBoxClose = new System.Windows.Forms.GroupBox();
            this.toolStripClose = new System.Windows.Forms.ToolStrip();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.gBoxAction = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustData)).BeginInit();
            this.gBoxClose.SuspendLayout();
            this.toolStripClose.SuspendLayout();
            this.gBoxAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteCust
            // 
            this.btnDeleteCust.Location = new System.Drawing.Point(337, 21);
            this.btnDeleteCust.Name = "btnDeleteCust";
            this.btnDeleteCust.Size = new System.Drawing.Size(155, 61);
            this.btnDeleteCust.TabIndex = 11;
            this.btnDeleteCust.Text = "Delete Customer";
            this.btnDeleteCust.UseVisualStyleBackColor = true;
            this.btnDeleteCust.Click += new System.EventHandler(this.btnDeleteCust_Click);
            // 
            // btnEditCust
            // 
            this.btnEditCust.Location = new System.Drawing.Point(176, 21);
            this.btnEditCust.Name = "btnEditCust";
            this.btnEditCust.Size = new System.Drawing.Size(155, 61);
            this.btnEditCust.TabIndex = 10;
            this.btnEditCust.Text = "Edit Customer";
            this.btnEditCust.UseVisualStyleBackColor = true;
            this.btnEditCust.Click += new System.EventHandler(this.btnEditCust_Click);
            // 
            // btnAddCust
            // 
            this.btnAddCust.Location = new System.Drawing.Point(15, 21);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(155, 61);
            this.btnAddCust.TabIndex = 9;
            this.btnAddCust.Text = "Add Customer";
            this.btnAddCust.UseVisualStyleBackColor = true;
            this.btnAddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // dgvCustData
            // 
            this.dgvCustData.AllowUserToAddRows = false;
            this.dgvCustData.AllowUserToDeleteRows = false;
            this.dgvCustData.AllowUserToResizeColumns = false;
            this.dgvCustData.AllowUserToResizeRows = false;
            this.dgvCustData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customer_ID,
            this.Customer_Name,
            this.Customer_Address});
            this.dgvCustData.Location = new System.Drawing.Point(12, 117);
            this.dgvCustData.Name = "dgvCustData";
            this.dgvCustData.ReadOnly = true;
            this.dgvCustData.RowHeadersVisible = false;
            this.dgvCustData.RowTemplate.Height = 24;
            this.dgvCustData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustData.Size = new System.Drawing.Size(776, 321);
            this.dgvCustData.TabIndex = 8;
            this.dgvCustData.Resize += new System.EventHandler(this.dgvCustData_Resize);
            // 
            // Customer_ID
            // 
            this.Customer_ID.HeaderText = "Customer_ID";
            this.Customer_ID.Name = "Customer_ID";
            this.Customer_ID.ReadOnly = true;
            // 
            // Customer_Name
            // 
            this.Customer_Name.HeaderText = "Customer_Name";
            this.Customer_Name.Name = "Customer_Name";
            this.Customer_Name.ReadOnly = true;
            this.Customer_Name.Width = 150;
            // 
            // Customer_Address
            // 
            this.Customer_Address.HeaderText = "Customer_Address";
            this.Customer_Address.Name = "Customer_Address";
            this.Customer_Address.ReadOnly = true;
            this.Customer_Address.Width = 150;
            // 
            // gBoxClose
            // 
            this.gBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxClose.Controls.Add(this.toolStripClose);
            this.gBoxClose.Location = new System.Drawing.Point(682, 12);
            this.gBoxClose.Name = "gBoxClose";
            this.gBoxClose.Size = new System.Drawing.Size(106, 99);
            this.gBoxClose.TabIndex = 12;
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
            this.gBoxAction.Controls.Add(this.btnAddCust);
            this.gBoxAction.Controls.Add(this.btnEditCust);
            this.gBoxAction.Controls.Add(this.btnDeleteCust);
            this.gBoxAction.Location = new System.Drawing.Point(12, 12);
            this.gBoxAction.Name = "gBoxAction";
            this.gBoxAction.Size = new System.Drawing.Size(503, 99);
            this.gBoxAction.TabIndex = 13;
            this.gBoxAction.TabStop = false;
            this.gBoxAction.Text = "Action";
            // 
            // FrmCustData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gBoxAction);
            this.Controls.Add(this.gBoxClose);
            this.Controls.Add(this.dgvCustData);
            this.Name = "FrmCustData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCustData";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCustData_FormClosing);
            this.Load += new System.EventHandler(this.FrmCustData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustData)).EndInit();
            this.gBoxClose.ResumeLayout(false);
            this.gBoxClose.PerformLayout();
            this.toolStripClose.ResumeLayout(false);
            this.toolStripClose.PerformLayout();
            this.gBoxAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteCust;
        private System.Windows.Forms.Button btnEditCust;
        private System.Windows.Forms.Button btnAddCust;
        private System.Windows.Forms.DataGridView dgvCustData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Address;
        private System.Windows.Forms.GroupBox gBoxClose;
        private System.Windows.Forms.ToolStrip toolStripClose;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.GroupBox gBoxAction;
    }
}