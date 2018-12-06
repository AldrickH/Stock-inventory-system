namespace Stock_inventory_system
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.gBoxClose = new System.Windows.Forms.GroupBox();
            this.toolStripClose = new System.Windows.Forms.ToolStrip();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.gBoxReport = new System.Windows.Forms.GroupBox();
            this.toolStripReport = new System.Windows.Forms.ToolStrip();
            this.btnReport_IN = new System.Windows.Forms.ToolStripButton();
            this.btnReport_OUT = new System.Windows.Forms.ToolStripButton();
            this.btnReport_Stock = new System.Windows.Forms.ToolStripButton();
            this.gBoxData = new System.Windows.Forms.GroupBox();
            this.toolStripData = new System.Windows.Forms.ToolStrip();
            this.btnCust = new System.Windows.Forms.ToolStripButton();
            this.btnSupp = new System.Windows.Forms.ToolStripButton();
            this.btnItem = new System.Windows.Forms.ToolStripButton();
            this.gBoxTransaction = new System.Windows.Forms.GroupBox();
            this.toolStripTransaction = new System.Windows.Forms.ToolStrip();
            this.btnIN = new System.Windows.Forms.ToolStripButton();
            this.btnOUT = new System.Windows.Forms.ToolStripButton();
            this.lbl_header = new System.Windows.Forms.Label();
            this.gBoxClose.SuspendLayout();
            this.toolStripClose.SuspendLayout();
            this.gBoxReport.SuspendLayout();
            this.toolStripReport.SuspendLayout();
            this.gBoxData.SuspendLayout();
            this.toolStripData.SuspendLayout();
            this.gBoxTransaction.SuspendLayout();
            this.toolStripTransaction.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxClose
            // 
            this.gBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxClose.Controls.Add(this.toolStripClose);
            this.gBoxClose.Location = new System.Drawing.Point(1112, 72);
            this.gBoxClose.Name = "gBoxClose";
            this.gBoxClose.Size = new System.Drawing.Size(106, 99);
            this.gBoxClose.TabIndex = 5;
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
            // gBoxReport
            // 
            this.gBoxReport.Controls.Add(this.toolStripReport);
            this.gBoxReport.Location = new System.Drawing.Point(561, 72);
            this.gBoxReport.Name = "gBoxReport";
            this.gBoxReport.Size = new System.Drawing.Size(315, 99);
            this.gBoxReport.TabIndex = 7;
            this.gBoxReport.TabStop = false;
            this.gBoxReport.Text = "Report";
            // 
            // toolStripReport
            // 
            this.toolStripReport.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripReport.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripReport.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripReport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReport_IN,
            this.btnReport_OUT,
            this.btnReport_Stock});
            this.toolStripReport.Location = new System.Drawing.Point(3, 18);
            this.toolStripReport.Name = "toolStripReport";
            this.toolStripReport.Size = new System.Drawing.Size(238, 63);
            this.toolStripReport.TabIndex = 0;
            this.toolStripReport.Text = "toolStrip1";
            // 
            // btnReport_IN
            // 
            this.btnReport_IN.AutoSize = false;
            this.btnReport_IN.Image = ((System.Drawing.Image)(resources.GetObject("btnReport_IN.Image")));
            this.btnReport_IN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReport_IN.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnReport_IN.Name = "btnReport_IN";
            this.btnReport_IN.Size = new System.Drawing.Size(75, 60);
            this.btnReport_IN.Text = "IN";
            this.btnReport_IN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnReport_OUT
            // 
            this.btnReport_OUT.AutoSize = false;
            this.btnReport_OUT.Image = ((System.Drawing.Image)(resources.GetObject("btnReport_OUT.Image")));
            this.btnReport_OUT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReport_OUT.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnReport_OUT.Name = "btnReport_OUT";
            this.btnReport_OUT.Size = new System.Drawing.Size(75, 60);
            this.btnReport_OUT.Text = "OUT";
            this.btnReport_OUT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnReport_Stock
            // 
            this.btnReport_Stock.AutoSize = false;
            this.btnReport_Stock.Image = ((System.Drawing.Image)(resources.GetObject("btnReport_Stock.Image")));
            this.btnReport_Stock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReport_Stock.Name = "btnReport_Stock";
            this.btnReport_Stock.Size = new System.Drawing.Size(75, 60);
            this.btnReport_Stock.Text = "Stock";
            this.btnReport_Stock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // gBoxData
            // 
            this.gBoxData.Controls.Add(this.toolStripData);
            this.gBoxData.Location = new System.Drawing.Point(14, 72);
            this.gBoxData.Name = "gBoxData";
            this.gBoxData.Size = new System.Drawing.Size(320, 99);
            this.gBoxData.TabIndex = 4;
            this.gBoxData.TabStop = false;
            this.gBoxData.Text = "Database";
            // 
            // toolStripData
            // 
            this.toolStripData.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripData.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripData.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCust,
            this.btnSupp,
            this.btnItem});
            this.toolStripData.Location = new System.Drawing.Point(3, 18);
            this.toolStripData.Name = "toolStripData";
            this.toolStripData.Size = new System.Drawing.Size(238, 63);
            this.toolStripData.TabIndex = 0;
            this.toolStripData.Text = "toolStrip1";
            // 
            // btnCust
            // 
            this.btnCust.AutoSize = false;
            this.btnCust.Image = ((System.Drawing.Image)(resources.GetObject("btnCust.Image")));
            this.btnCust.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCust.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnCust.Name = "btnCust";
            this.btnCust.Size = new System.Drawing.Size(75, 60);
            this.btnCust.Text = "Customer";
            this.btnCust.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCust.Click += new System.EventHandler(this.btnCust_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.AutoSize = false;
            this.btnSupp.Image = ((System.Drawing.Image)(resources.GetObject("btnSupp.Image")));
            this.btnSupp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSupp.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(75, 60);
            this.btnSupp.Text = "Supplier";
            this.btnSupp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // btnItem
            // 
            this.btnItem.AutoSize = false;
            this.btnItem.Image = ((System.Drawing.Image)(resources.GetObject("btnItem.Image")));
            this.btnItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(75, 60);
            this.btnItem.Text = "Item";
            this.btnItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // gBoxTransaction
            // 
            this.gBoxTransaction.Controls.Add(this.toolStripTransaction);
            this.gBoxTransaction.Location = new System.Drawing.Point(340, 72);
            this.gBoxTransaction.Name = "gBoxTransaction";
            this.gBoxTransaction.Size = new System.Drawing.Size(215, 99);
            this.gBoxTransaction.TabIndex = 6;
            this.gBoxTransaction.TabStop = false;
            this.gBoxTransaction.Text = "Item Transaction";
            // 
            // toolStripTransaction
            // 
            this.toolStripTransaction.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripTransaction.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripTransaction.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripTransaction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnIN,
            this.btnOUT});
            this.toolStripTransaction.Location = new System.Drawing.Point(3, 18);
            this.toolStripTransaction.Name = "toolStripTransaction";
            this.toolStripTransaction.Size = new System.Drawing.Size(158, 63);
            this.toolStripTransaction.TabIndex = 0;
            this.toolStripTransaction.Text = "toolStrip1";
            // 
            // btnIN
            // 
            this.btnIN.AutoSize = false;
            this.btnIN.Image = ((System.Drawing.Image)(resources.GetObject("btnIN.Image")));
            this.btnIN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIN.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnIN.Name = "btnIN";
            this.btnIN.Size = new System.Drawing.Size(75, 60);
            this.btnIN.Text = "IN";
            this.btnIN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIN.Click += new System.EventHandler(this.btnIN_Click);
            // 
            // btnOUT
            // 
            this.btnOUT.AutoSize = false;
            this.btnOUT.Image = ((System.Drawing.Image)(resources.GetObject("btnOUT.Image")));
            this.btnOUT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOUT.Name = "btnOUT";
            this.btnOUT.Size = new System.Drawing.Size(75, 60);
            this.btnOUT.Text = "OUT";
            this.btnOUT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOUT.Click += new System.EventHandler(this.btnOUT_Click);
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.Location = new System.Drawing.Point(364, 18);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(508, 36);
            this.lbl_header.TabIndex = 8;
            this.lbl_header.Text = "Stock Inventory System - PT 17TI1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 491);
            this.Controls.Add(this.lbl_header);
            this.Controls.Add(this.gBoxClose);
            this.Controls.Add(this.gBoxReport);
            this.Controls.Add(this.gBoxData);
            this.Controls.Add(this.gBoxTransaction);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.gBoxClose.ResumeLayout(false);
            this.gBoxClose.PerformLayout();
            this.toolStripClose.ResumeLayout(false);
            this.toolStripClose.PerformLayout();
            this.gBoxReport.ResumeLayout(false);
            this.gBoxReport.PerformLayout();
            this.toolStripReport.ResumeLayout(false);
            this.toolStripReport.PerformLayout();
            this.gBoxData.ResumeLayout(false);
            this.gBoxData.PerformLayout();
            this.toolStripData.ResumeLayout(false);
            this.toolStripData.PerformLayout();
            this.gBoxTransaction.ResumeLayout(false);
            this.gBoxTransaction.PerformLayout();
            this.toolStripTransaction.ResumeLayout(false);
            this.toolStripTransaction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxClose;
        private System.Windows.Forms.ToolStrip toolStripClose;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.GroupBox gBoxReport;
        private System.Windows.Forms.ToolStrip toolStripReport;
        private System.Windows.Forms.ToolStripButton btnReport_IN;
        private System.Windows.Forms.ToolStripButton btnReport_OUT;
        private System.Windows.Forms.ToolStripButton btnReport_Stock;
        private System.Windows.Forms.GroupBox gBoxData;
        private System.Windows.Forms.ToolStrip toolStripData;
        private System.Windows.Forms.ToolStripButton btnItem;
        private System.Windows.Forms.GroupBox gBoxTransaction;
        private System.Windows.Forms.ToolStrip toolStripTransaction;
        private System.Windows.Forms.ToolStripButton btnIN;
        private System.Windows.Forms.ToolStripButton btnOUT;
        private System.Windows.Forms.ToolStripButton btnSupp;
        private System.Windows.Forms.ToolStripButton btnCust;
        private System.Windows.Forms.Label lbl_header;
    }
}