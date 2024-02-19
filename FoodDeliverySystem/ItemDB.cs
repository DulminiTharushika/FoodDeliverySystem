using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodDeliverySystem
{
    public class ItemDB
    {
        public void insert(string Food_ID, string Food_Name, double Price)
        {
            MySqlConnection con = new DBConnection().ConnectDB();
            string sql = "insert into food(Food_ID,Food_Name,Price)" +
                "values ('" + Food_ID + "','" + Food_Name + "','" + Price + "')";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Inserted Successfully ");
        }

        /*public DataTable Select_all()
        {
            MySqlConnection con = new DBConnection().ConnectDB();
            string query = "select*from food_order";
            MySqlCommand cmd = new MySqlCommand(query, con);
            con.Open();
            MySqlDataReader rdr = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(rdr);
            return table;
        }
        */
    }
}
