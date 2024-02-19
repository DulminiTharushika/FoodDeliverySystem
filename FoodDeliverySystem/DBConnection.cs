using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliverySystem
{
    public class DBConnection
    {
        private MySqlConnection Connection;
        public MySqlConnection ConnectDB()
        {
            string Con_String = "Server=localhost;uid=root;pwd=;database=happy_tummy";
            Connection= new MySqlConnection(Con_String);
            return Connection;
        }
    }
}
