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
    public partial class FrmTransaction_IN : Form
    {
        ItemDAO _itemDAO = null;
        TransactionDAO _transDAO = null;

        public FrmTransaction_IN()
        {
            InitializeComponent();
            _itemDAO = new ItemDAO(Setting.GetConnectionString());
            _transDAO = new TransactionDAO(Setting.GetConnectionString());
            this.dgvItemData.AutoGenerateColumns = false;
        }

        private void FrmTransaction_IN_Load(object sender, EventArgs e)
        {
            try
            {
                this.dgvItemData.DataSource = null;
                this.dgvItemData.DataSource = _itemDAO.GetAllItemData();
                this.dgvItemData.Columns[0].DataPropertyName = nameof(Item.itemID);
                this.dgvItemData.Columns[1].DataPropertyName = nameof(Item.itemName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dgvItemData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!checkItemExist())
            {
                Item itm = _itemDAO.GetItemByID(this.dgvItemData.SelectedRows[0].Cells[0].Value.ToString());
                this.dgvTransaction.Rows.Add(new string[] { itm.itemID, itm.itemName, itm.qty.ToString() });

                int test = this.dgvTransaction.Rows.Count;
                this.dgvTransaction.CurrentCell = this.dgvTransaction.Rows[test - 1].Cells[3];
                this.dgvTransaction.BeginEdit(true);
            }
            else
            {
                foreach (DataGridViewRow row in this.dgvTransaction.Rows)
                {
                    if (this.dgvItemData.SelectedRows[0].Cells[0].Value.ToString() == row.Cells[0].Value.ToString())
                    {
                        this.dgvTransaction.CurrentCell = row.Cells[3];
                        this.dgvTransaction.BeginEdit(true);
                        break;
                    }
                }
            }
        }

        private bool checkItemExist()
        {
            if (this.dgvTransaction.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in this.dgvTransaction.Rows)
                {
                    if (this.dgvItemData.SelectedRows[0].Cells[0].Value.ToString() == row.Cells[0].Value.ToString())
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void dgvTransaction_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowNo = this.dgvTransaction.CurrentCell.RowIndex;
            this.dgvTransaction.Rows[rowNo].Cells[4].Value = Convert.ToInt32(this.dgvTransaction.Rows[rowNo].Cells[2].Value) + Convert.ToInt32(this.dgvTransaction.Rows[rowNo].Cells[3].Value);

            this.lbl_QuantityTotal.Text = GetQuantityTotal().ToString() + " pcs";
        }

        private void dgvTransaction_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvTransaction.Rows.Count > 0)
            {
                // 
                //int rowNo = this.dgvTransaction.CurrentCell.RowIndex;
                //if (Convert.ToInt32(this.dgvTransaction.Rows[rowNo].Cells[3].Value) > Convert.ToInt32(this.dgvTransaction.Rows[rowNo].Cells[2].Value))
                //{
                //    this.dgvTransaction.Rows[rowNo].Cells[3].Value = this.dgvTransaction.Rows[rowNo].Cells[2].Value;
                //}
            }
        }

        private void dgvTransaction_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Numeric_KeyPress);
            if (this.dgvTransaction.CurrentCell.ColumnIndex == 3) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Numeric_KeyPress);
                }
            }
        }

        private void Numeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private int GetQuantityTotal()
        {
            int result = 0;
            if (this.dgvTransaction.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in this.dgvTransaction.Rows)
                {
                    result += Convert.ToInt32(row.Cells[3].Value);
                }
            }
            return result;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to add this data ? ", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string transNumber = _transDAO.GetTransactionNumberNext();
                List<Transaction> listTrans = new List<Transaction>();
                foreach (DataGridViewRow row in this.dgvTransaction.Rows)
                {
                    listTrans.Add(new Transaction
                    {
                        transactionID = this.txtBox_TransID.Text,
                        transactionNumber = transNumber,
                        transactionDate = this.dtp_TransDate.Value.ToShortDateString(),
                        itemData = _itemDAO.GetItemByID(row.Cells[0].Value.ToString()),
                        qtyBefore = Convert.ToInt32(row.Cells[2].Value),
                        qtyAfter = Convert.ToInt32(row.Cells[4].Value),
                        qtyTrans_IN = Convert.ToInt32(row.Cells[3].Value),
                        qtyTrans_OUT = 0
                    });
                }
                _transDAO.AddTransaction(listTrans);

                this.Close();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
