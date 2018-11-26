using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Stock_Library
{
    public class ItemDAO : IDisposable
    {
        SqlConnection _conn = null;
        SqlTransaction _trans = null;

        public List<Item> listData { get; set; }

        public ItemDAO(string connectionString)
        {
            try
            {
                _conn = new SqlConnection(connectionString);
                _conn.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Item> GetAllItemData()
        {
            string sqlString = @"select * from item order by itemID";

            try
            {
                if (this.listData == null)
                {
                    using (SqlCommand cmd = new SqlCommand(sqlString, _conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            listData = new List<Item>();
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    listData.Add(new Item
                                    {
                                        itemID = reader["itemID"].ToString(),
                                        itemName = reader["itemName"].ToString(),
                                        qty = Convert.ToInt32(reader["qty"])
                                    });
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listData;
        }

        public void AddNewItem(Item _item)
        {
            try
            {
                listData.Add(_item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EditItem(Item _item_NEW, Item _item_OLD)
        {
            try
            {
                foreach (Item itm in listData)
                {
                    if (itm.itemID.Equals(_item_OLD.itemID))
                    {
                        itm.itemID = _item_NEW.itemID;
                        itm.itemName = _item_NEW.itemName;
                        itm.qty = _item_NEW.qty;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteItem(string _itemID)
        {
            try
            {
                foreach (Item itm in listData)
                {
                    if (itm.itemID.Equals(_itemID))
                    {
                        listData.Remove(itm);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateAllItem()
        {
            try
            {
                RemoveAllItem();

                _trans = _conn.BeginTransaction();

                foreach (Item item in listData)
                {
                    using (SqlCommand cmd = new SqlCommand(@"insert into item values (@itemID, @itemName, @qty)", _conn, _trans))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@itemID", item.itemID);
                        cmd.Parameters.AddWithValue("@itemName", item.itemName);
                        cmd.Parameters.AddWithValue("@qty", item.qty);
                        cmd.ExecuteNonQuery();
                    }
                }

                _trans.Commit();
            }
            catch (Exception ex)
            {
                if (_trans != null) _trans.Rollback();
                throw ex;
            }
            finally
            {
                if (_trans != null) _trans.Dispose();
            }
        }

        public bool CheckItemByID(string _itemID)
        {
            bool result = false;
            try
            {
                foreach (Item itm in listData)
                {
                    if (itm.itemID.Equals(_itemID))
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public Item GetItemByID(string _itemID)
        {
            Item result = null;
            try
            {
                foreach (Item itm in listData)
                {
                    if (itm.itemID.Equals(_itemID))
                    {
                        result = itm;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public string GetKodeBarangBerikutnya()
        {
            string result = "";
            try
            {
                result = "BRG" + (this.listData.Count + 1).ToString("0000");
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }

        private void RemoveAllItem()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand(@"delete from item", _conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Dispose()
        {
            if (_conn != null) _conn.Close();
        }
    }
}
