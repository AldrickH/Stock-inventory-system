using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stock_Library;

namespace Stock_inventory_system
{
    public partial class FrmItemData : Form
    {
        ItemDAO dao = null;

        public FrmItemData()
        {
            InitializeComponent();

            dao = new ItemDAO(Setting.GetConnectionString());
            this.dgvItemData.AutoGenerateColumns = false;
        }

        private void FrmItemData_Load(object sender, EventArgs e)
        {
            try
            {
                this.dgvItemData.DataSource = null;
                this.dgvItemData.DataSource = dao.GetAllItemData();
                this.dgvItemData.Columns[0].DataPropertyName = nameof(Item.itemID);
                this.dgvItemData.Columns[1].DataPropertyName = nameof(Item.itemName);
                this.dgvItemData.Columns[2].DataPropertyName = nameof(Item.qty);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            FrmItemDescription frm = new FrmItemDescription(dao, false);
            frm.ShowDialog();

            ReloadDGVData();
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            if (this.dgvItemData.Rows.Count >= 1)
            {
                FrmItemDescription frm = new FrmItemDescription(dao, true, dao.GetItemByID(dgvItemData.SelectedRows[0].Cells[0].Value.ToString()));
                frm.ShowDialog();

                ReloadDGVData();
            }
            else
            {
                MessageBox.Show("Maaf, masih tidak ada data.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (this.dgvItemData.Rows.Count >= 1)
            {
                if (MessageBox.Show("Delete this item ? \n Item Id : " + this.dgvItemData.SelectedRows[0].Cells[0].Value.ToString() + "\n Item Name : " + this.dgvItemData.SelectedRows[0].Cells[1].Value.ToString(), this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dao.DeleteItem(this.dgvItemData.SelectedRows[0].Cells[0].Value.ToString());

                    ReloadDGVData();
                }
            }
            else
            {
                MessageBox.Show("Maaf, masih tidak ada data.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmItemData_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure to save changes data ? ", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dao.UpdateAllItem();
            }
        }

        private void dgvItemData_Resize(object sender, EventArgs e)
        {
            this.dgvItemData.Columns[0].Width = 25 * this.dgvItemData.Width / 100;
            this.dgvItemData.Columns[1].Width = 40 * this.dgvItemData.Width / 100;
            this.dgvItemData.Columns[2].Width = 25 * this.dgvItemData.Width / 100;
        }

        private void ReloadDGVData()
        {
            this.dgvItemData.DataSource = null;
            this.dgvItemData.Rows.Clear();
            foreach (Item itm in dao.listData)
            {
                this.dgvItemData.Rows.Add(new string[] { itm.itemID, itm.itemName, itm.qty.ToString() });
            }
        }
    }
}
