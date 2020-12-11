using System;
using System.Collections.Generic;
using System.Linq;
using People.Models;
using SQLite;

namespace People
{
    public class TShirtRepository
    {
        public string StatusMessage { get; set; }

        private SQLiteConnection conn;
        public TShirtRepository(string dbPath)
        {
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<tshirt>();
        }

        public void AddNewTShirt(string name, string gender, string tshirt_size,string date_of_order, string tshirt_color, string shipping_address)
        {
            int result = 0;
            try
            {
                
                if (string.IsNullOrEmpty(name))
                    throw new Exception("Valid name required");

                    result = conn.Insert(new tshirt { Names = name, Genders = gender, TShirtSizes= tshirt_size, DateOfOrders = date_of_order, TShirtColors = tshirt_color, Shipping_Addresses = shipping_address });

                StatusMessage = string.Format("{0} record(s) added [Name: {1})", result, name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to add {0}. Error: {1}", name, ex.Message);
            }

        }

        public List<tshirt> GetProductInfo()
        {
           
            try
            {
                return conn.Table<tshirt>().ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            return new List<tshirt>();
        }
    }
}