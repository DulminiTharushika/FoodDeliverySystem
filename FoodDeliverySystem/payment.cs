using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FoodDeliverySystem
{
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
            //dataGridView1.DataSource = new ItemDB().Select_all();
        }

        private void payment_Load(object sender, EventArgs e)
        {

        }
        public void populateGrid(string Telephone_No)
        {
            MySqlConnection con = new DBConnection().ConnectDB();
            string query = "SELECT  customer.Customer_Name, customer.Address, food.Food_Name, food_order.Qty,  food.Price,  (food_order.Qty * food.Price) AS subtotal FROM food_order JOIN  food ON food_order.Food_ID = food.Food_ID JOIN  customer ON food_order.Telephone_No = customer.Telephone_No WHERE  food_order.Telephone_No = '1234567890'; ";
            MySqlCommand cmd = new MySqlCommand(query, con);
            con.Open();
            MySqlDataReader rdr =  cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(rdr);
           
            dataGridView1.DataSource = table;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DashBoard window= new DashBoard();
            window.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnCon_Click(object sender, EventArgs e)
        {
            //order o1=new order();
           // o1.Telephone_No = TxtTp.Text;
            //new payment().populateGrid(o1.Telephone_No);
        }

        private void TxtTp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
