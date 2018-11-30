﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_inventory_system
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnIN_Click(object sender, EventArgs e)
        {
            FrmTransaction_IN frm = new FrmTransaction_IN();
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            FrmItemData frm = new FrmItemData();
            frm.ShowDialog();
        }
    }
}
