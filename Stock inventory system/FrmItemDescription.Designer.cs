namespace Stock_inventory_system
{
    partial class FrmItemDescription
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
            this.lbl_ItemID = new System.Windows.Forms.Label();
            this.txtBox_ItemID = new System.Windows.Forms.TextBox();
            this.txtBox_ItemName = new System.Windows.Forms.TextBox();
            this.lbl_ItemName = new System.Windows.Forms.Label();
            this.txtBox_Quantity = new System.Windows.Forms.TextBox();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ItemID
            // 
            this.lbl_ItemID.AutoSize = true;
            this.lbl_ItemID.Location = new System.Drawing.Point(100, 86);
            this.lbl_ItemID.Name = "lbl_ItemID";
            this.lbl_ItemID.Size = new System.Drawing.Size(51, 17);
            this.lbl_ItemID.TabIndex = 0;
            this.lbl_ItemID.Text = "Item ID";
            // 
            // txtBox_ItemID
            // 
            this.txtBox_ItemID.Enabled = false;
            this.txtBox_ItemID.Location = new System.Drawing.Point(262, 86);
            this.txtBox_ItemID.Name = "txtBox_ItemID";
            this.txtBox_ItemID.Size = new System.Drawing.Size(97, 22);
            this.txtBox_ItemID.TabIndex = 1;
            // 
            // txtBox_ItemName
            // 
            this.txtBox_ItemName.Location = new System.Drawing.Point(262, 132);
            this.txtBox_ItemName.Name = "txtBox_ItemName";
            this.txtBox_ItemName.Size = new System.Drawing.Size(169, 22);
            this.txtBox_ItemName.TabIndex = 3;
            // 
            // lbl_ItemName
            // 
            this.lbl_ItemName.AutoSize = true;
            this.lbl_ItemName.Location = new System.Drawing.Point(100, 137);
            this.lbl_ItemName.Name = "lbl_ItemName";
            this.lbl_ItemName.Size = new System.Drawing.Size(75, 17);
            this.lbl_ItemName.TabIndex = 2;
            this.lbl_ItemName.Text = "Item Name";
            // 
            // txtBox_Quantity
            // 
            this.txtBox_Quantity.Location = new System.Drawing.Point(262, 184);
            this.txtBox_Quantity.Name = "txtBox_Quantity";
            this.txtBox_Quantity.Size = new System.Drawing.Size(169, 22);
            this.txtBox_Quantity.TabIndex = 5;
            this.txtBox_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAngka_KeyPress);
            // 
            // lbl_Header
            // 
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(148, 19);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(211, 39);
            this.lbl_Header.TabIndex = 6;
            this.lbl_Header.Text = "Item Description";
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Location = new System.Drawing.Point(100, 189);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(61, 17);
            this.lbl_Quantity.TabIndex = 4;
            this.lbl_Quantity.Text = "Quantity";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(236, 251);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(342, 251);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmItemDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 317);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbl_Header);
            this.Controls.Add(this.txtBox_Quantity);
            this.Controls.Add(this.lbl_Quantity);
            this.Controls.Add(this.txtBox_ItemName);
            this.Controls.Add(this.lbl_ItemName);
            this.Controls.Add(this.txtBox_ItemID);
            this.Controls.Add(this.lbl_ItemID);
            this.Name = "FrmItemDescription";
            this.Text = "Item Description";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ItemID;
        private System.Windows.Forms.TextBox txtBox_ItemID;
        private System.Windows.Forms.TextBox txtBox_ItemName;
        private System.Windows.Forms.Label lbl_ItemName;
        private System.Windows.Forms.TextBox txtBox_Quantity;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}