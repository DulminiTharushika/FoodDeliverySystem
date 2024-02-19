using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodDeliverySystem
{
    internal class DeleteDB
    {
        public void Delete(string Food_ID)
        {
            MySqlConnection con = new DBConnection().ConnectDB();
            string sql = "DELETE FROM food WHERE Food_ID = @Food_ID";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete Successfully ");
        }
    }
}
