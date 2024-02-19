using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliverySystem
{
    public class Sel
    {
        public void select(string Food_Name)
        {
            MySqlConnection Connection = new DBConnection().ConnectDB();
            string sql = "select food.Food_ID from food  where food.Food_Name=food_order.Food_Name and food.Food_Name=@;Food_Name";
            MySqlCommand cmd = new MySqlCommand(sql, Connection);
            cmd.Parameters.AddWithValue("@Food_Name", Food_Name);
            Connection.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
