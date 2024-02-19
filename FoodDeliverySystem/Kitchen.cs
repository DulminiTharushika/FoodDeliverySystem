using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodDeliverySystem
{
    public partial class Kitchen : Form
    {

        public Kitchen()
        {
            InitializeComponent();
            this.Load += populateGrid;


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Kitchen_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DashBoard window = new DashBoard();
            window.Show();
            this.Hide();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DashBoard window = new DashBoard();
            window.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void populateGrid(object sender ,EventArgs e)//string Telephone_No,string Customer_Name,String Food_ID,String Food_Name,int Qty
         {
             MySqlConnection con = new DBConnection().ConnectDB();


             string query = "SELECT food.Food_Name, food_order.Qty, customer.Customer_Name FROM food_order  INNER JOIN customer ON food_order.Telephone_No = customer.Telephone_No INNER JOIN food  ON food.Food_ID = food.Food_ID; ";
             MySqlCommand cmd = new MySqlCommand(query, con);
             con.Open();
             MySqlDataReader rdr = cmd.ExecuteReader();
             //SqlDataAdapter adapter = new SqlDataAdapter();
             DataTable table = new DataTable();
             //adapter.Fill(table);
             table.Load(rdr);



             dataGridView1.DataSource = table;
         }

        /*public void populateGrid(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new DBConnection().ConnectDB();
                string query = "SELECT food.Food_Name, food_order.Qty, customer.Customer_Name FROM food_order JOIN customer ON food_order.Telephone_No = customer.Telephone_No JOIN food ON food.Food_ID = food_order.Food_ID; ";

                // Use MySqlDataAdapter to fill the DataTable
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                DataTable table = new DataTable();
                adapter.Fill(table);

                con.Close(); // Close the connection

                // Check if DataTable has data
                if (table.Rows.Count > 0)
                {
                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = table;
                }
                else
                {
                    // No data retrieved
                    MessageBox.Show("No data retrieved from the database.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }*/


        }   
                
}

