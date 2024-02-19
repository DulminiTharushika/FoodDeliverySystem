using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
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
    public partial class CustomerVerify : Form
    {
        public CustomerVerify()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustRegister window = new CustRegister();
            window.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
             string phoneNumber = TxtphoneNumber.Text.Trim();

             if (string.IsNullOrEmpty(phoneNumber))
             {
                 MessageBox.Show("Please enter a phone number.");
                 return;
             }

             MySqlConnection con = new DBConnection().ConnectDB();
             //string query = "SELECT COUNT(*) FROM customer WHERE Telephone_no = @phoneNumber";
             string query = "select Telephone_No from customer";
             MySqlCommand cmd = new MySqlCommand(query, con);
             cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);

             try
             {
                 con.Open();
                 int count = 10;
                 string countAsstring = count.ToString();
                 //int count = Convert.ToInt32(Convert.ToStringTostring)(cmd.ExecuteScalar());
                 //MessageBox.Show("Count: " + count);

                 if (count <= 10)
                 {
                     MessageBox.Show("PhoneNo already exists in the database.");
                 }
                 else{ MessageBox.Show("PhoneNo does not exist in the database."); }


             }
             catch (Exception ex)
             {
                 MessageBox.Show("An error occurred: " + ex.Message);
             }
             finally
             {
                 con.Close();
             }



         }


         private void button1_Click(object sender, EventArgs e)
         {
             DashBoard window = new DashBoard();
             window.Show();
             this.Hide();

         }

         private void CustomerVerify_Load(object sender, EventArgs e)
         {

         }

         private void TxtNo_TextChanged(object sender, EventArgs e)
         {

             }
           /* string userInput=TxtphoneNumber.Text;
            int result;
            try
            {
                result = int.Parse(userInput);

            }
            catch 
            {
                MessageBox.Show("Already Exist");
            }
            if (int.TryParse(userInput, out result))
            {
                MessageBox.Show("Phone No already Exist");

            }
            else
            {
                MessageBox.Show("Not in Database");
            }*/



    }



    
}




        