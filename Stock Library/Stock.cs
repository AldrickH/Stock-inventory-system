using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Library
{
    public class Stock
    {
        public string transactionID { get; set; }
        public DateTime transactionDate { get; set; }
        public Item itemData { get; set; }
        public int qtyBefore { get; set; }
        public int qtyAfter { get; set; }
        public int itemIN { get; set; }
        public int itemOUT { get; set; }
    }
}
