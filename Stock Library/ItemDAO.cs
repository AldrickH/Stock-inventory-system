﻿using System;
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
            try
            {
                if (this.listData == null)
                {
                    using (SqlCommand cmd = new SqlCommand(@"select * from item order by itemID", _conn))
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

                using (SqlCommand cmd = new SqlCommand(@"delete Item where itemID = @itemID", _conn))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@itemID", _itemID);
                    cmd.ExecuteNonQuery();
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
                _trans = _conn.BeginTransaction();

                foreach (Item item in listData)
                {
                    if (!CheckItemByID(item.itemID))
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
                    else
                    {
                        using (SqlCommand cmd = new SqlCommand(@"update item set itemName = @itemName, qty = @qty where itemID = @itemID", _conn, _trans))
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@itemID", item.itemID);
                            cmd.Parameters.AddWithValue("@itemName", item.itemName);
                            cmd.Parameters.AddWithValue("@qty", item.qty);
                            cmd.ExecuteNonQuery();
                        }
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

        public void UpdateQuantity(string _itemID, int qtyAfter)
        {
            try
            {
                foreach (Item itm in listData)
                {
                    if (itm.itemID.Equals(_itemID))
                    {
                        itm.qty = qtyAfter;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string GetItemIDNext()
        {
            string result = "";
            try
            {
                if (listData.Count > 0)
                {
                    var res = this.listData.Last();
                    result = "BRG" + (Convert.ToInt32(res.itemID.Substring(3, 4)) + 1).ToString("0000");
                }
                else
                {
                    result = "BRG0001";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public bool CheckItemByID(string _itemID)
        {
            bool result = false;
            try
            {
                using (SqlCommand cmd = new SqlCommand(@"select * from item where itemID = @itemID", _conn, _trans))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@itemID", _itemID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                result = true;
                            }
                        }
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
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public void Dispose()
        {
            if (_conn != null) _conn.Close();
        }
    }
}
