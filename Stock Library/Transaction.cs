using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Library
{
    public class Transaction
    {
        public string transactionNumber { get; set; }
        public string transactionID { get; set; }
        public string transactionDate { get; set; }
        public Item itemData { get; set; }
        public Supplier suppData { get; set; }
        public Customer custData { get; set; }
        public int qtyBefore { get; set; }
        public int qtyTrans_IN { get; set; }
        public int qtyTrans_OUT { get; set; }
        public int qtyAfter { get; set; }
    }
}
