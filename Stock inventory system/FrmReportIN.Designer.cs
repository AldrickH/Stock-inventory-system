namespace Stock_inventory_system
{
    partial class FrmReportIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportIN));
            this.gBoxSupp = new System.Windows.Forms.GroupBox();
            this.listBoxSuppID = new System.Windows.Forms.ListBox();
            this.gBoxTransID = new System.Windows.Forms.GroupBox();
            this.listBoxTransID = new System.Windows.Forms.ListBox();
            this.RptViewerIN = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.gBoxClose = new System.Windows.Forms.GroupBox();
            this.toolStripClose = new System.Windows.Forms.ToolStrip();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.gBoxSupp.SuspendLayout();
            this.gBoxTransID.SuspendLayout();
            this.gBoxClose.SuspendLayout();
            this.toolStripClose.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxSupp
            // 
            this.gBoxSupp.Controls.Add(this.listBoxSuppID);
            this.gBoxSupp.Location = new System.Drawing.Point(233, 6);
            this.gBoxSupp.Name = "gBoxSupp";
            this.gBoxSupp.Size = new System.Drawing.Size(215, 115);
            this.gBoxSupp.TabIndex = 7;
            this.gBoxSupp.TabStop = false;
            this.gBoxSupp.Text = "Supplier ID";
            // 
            // listBoxSuppID
            // 
            this.listBoxSuppID.FormattingEnabled = true;
            this.listBoxSuppID.ItemHeight = 16;
            this.listBoxSuppID.Location = new System.Drawing.Point(6, 21);
            this.listBoxSuppID.Name = "listBoxSuppID";
            this.listBoxSuppID.ScrollAlwaysVisible = true;
            this.listBoxSuppID.Size = new System.Drawing.Size(203, 84);
            this.listBoxSuppID.TabIndex = 2;
            // 
            // gBoxTransID
            // 
            this.gBoxTransID.Controls.Add(this.listBoxTransID);
            this.gBoxTransID.Location = new System.Drawing.Point(12, 6);
            this.gBoxTransID.Name = "gBoxTransID";
            this.gBoxTransID.Size = new System.Drawing.Size(215, 115);
            this.gBoxTransID.TabIndex = 6;
            this.gBoxTransID.TabStop = false;
            this.gBoxTransID.Text = "Transaction ID";
            // 
            // listBoxTransID
            // 
            this.listBoxTransID.FormattingEnabled = true;
            this.listBoxTransID.ItemHeight = 16;
            this.listBoxTransID.Location = new System.Drawing.Point(6, 21);
            this.listBoxTransID.Name = "listBoxTransID";
            this.listBoxTransID.ScrollAlwaysVisible = true;
            this.listBoxTransID.Size = new System.Drawing.Size(203, 84);
            this.listBoxTransID.TabIndex = 2;
            // 
            // RptViewerIN
            // 
            this.RptViewerIN.ActiveViewIndex = -1;
            this.RptViewerIN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RptViewerIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RptViewerIN.Cursor = System.Windows.Forms.Cursors.Default;
            this.RptViewerIN.Location = new System.Drawing.Point(0, 127);
            this.RptViewerIN.Name = "RptViewerIN";
            this.RptViewerIN.Size = new System.Drawing.Size(798, 315);
            this.RptViewerIN.TabIndex = 5;
            this.RptViewerIN.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // gBoxClose
            // 
            this.gBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxClose.Controls.Add(this.toolStripClose);
            this.gBoxClose.Location = new System.Drawing.Point(680, 12);
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
            this.toolStripClose.Size = new System.Drawing.Size(117, 63);
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
            // FrmReportIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 448);
            this.Controls.Add(this.gBoxClose);
            this.Controls.Add(this.gBoxSupp);
            this.Controls.Add(this.gBoxTransID);
            this.Controls.Add(this.RptViewerIN);
            this.Name = "FrmReportIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReportIN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReportIN_Load);
            this.gBoxSupp.ResumeLayout(false);
            this.gBoxTransID.ResumeLayout(false);
            this.gBoxClose.ResumeLayout(false);
            this.gBoxClose.PerformLayout();
            this.toolStripClose.ResumeLayout(false);
            this.toolStripClose.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxSupp;
        private System.Windows.Forms.ListBox listBoxSuppID;
        private System.Windows.Forms.GroupBox gBoxTransID;
        private System.Windows.Forms.ListBox listBoxTransID;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer RptViewerIN;
        private System.Windows.Forms.GroupBox gBoxClose;
        private System.Windows.Forms.ToolStrip toolStripClose;
        private System.Windows.Forms.ToolStripButton btnClose;
    }
}