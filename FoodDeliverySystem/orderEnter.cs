using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodDeliverySystem
{
    public class orderEnter
    {
        public void FoodEnter(String Telephone_No, string Food_ID, String Food_Name,int Qty)
        {
            MySqlConnection Connection = new DBConnection().ConnectDB();
            string sql = "insert into food_order (Telephone_No,Food_ID,Food_Name,Qty)" +
                " values('" + Telephone_No + "','" + Food_ID + "','" + Food_Name + "',"+Qty+")";
            MySqlCommand cmd = new MySqlCommand(sql, Connection);
            Connection.Open();
            int res = cmd.ExecuteNonQuery();
            if (res < 1)
            {
                MessageBox.Show("Error in inserting");
            }
            else
            {
                MessageBox.Show("Insert Succussfully");
            }
        }
    }
}
