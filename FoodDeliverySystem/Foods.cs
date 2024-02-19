using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodDeliverySystem
{
    public class Foods
    {
        public void insert(string Telephone_No,string Customer_Name,string Address)
        { 
            MySqlConnection Connection = new DBConnection().ConnectDB();
            string sql = "insert into customer (Telephone_No,Customer_Name,Address)" +
                " values('"+Telephone_No+"','" + Customer_Name+"','"+Address+"')";
            MySqlCommand cmd = new MySqlCommand(sql,Connection);
            Connection.Open();
            int res= cmd.ExecuteNonQuery();
            if (res < 1)
            {
                MessageBox.Show("Error in inserting");
            }
            else {
                MessageBox.Show("Insert Succussfully");
            }

        }
    }
}
