using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Raktarkezelo.DataBase;

namespace Raktarkezelo.Shops
{
    public class Shop
    {
        public string shop_id;
        public string shop_name;
        public string shop_sort_name;
        public string shop_cim;
        public string shop_tel;
        public Shop(string id,string name,string sort_name,string cim,string tel)
        {
            shop_id = id;
            shop_name = name;
            shop_sort_name = sort_name;
            shop_cim = cim;
            shop_tel = tel;
        
        }
        public void Insert()
        {
            try
            {
                string query = "INSERT INTO shop VALUES('','" + shop_name + "','" + shop_sort_name + "','" + shop_cim + "','" + shop_tel + "',NOW(),NOW(),0)";
                MySQLDB conn = new MySQLDB();
                conn.Insert(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        
        }
        public void Update()
        {
            string query = "UPDATE shop SET shop_name='" + shop_name + "', shop_sort_name='" + shop_sort_name + "', shop_cim='" + shop_cim + "', shop_telefon='" + shop_tel + "',shop_lastup= NOW() WHERE shop_id='"+shop_id+"'";
            MySQLDB conn = new MySQLDB();
            conn.Update(query);

        }

    }
}
