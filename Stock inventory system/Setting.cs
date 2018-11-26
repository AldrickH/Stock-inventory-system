using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_inventory_system
{
    public static class Setting
    {
        public static string GetConnectionString()
        {
            return @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = DB_Stock_Inventory_System; Integrated Security = True;";
        }
    }
}
