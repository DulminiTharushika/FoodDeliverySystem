using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodDeliverySystem
{
    public partial class CustRegister : Form
    {
        public CustRegister()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try

            {
                customer c1 = new customer();
                c1.CustomerName = TxtName.Text;
                c1.CustomerAddress = TxtAddress.Text;
                c1.CustomerContactNo = TxtContact.Text;
                new Foods ().insert(c1.CustomerName,c1.CustomerAddress,c1.CustomerContactNo);
               
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid Inputs");
                Console.WriteLine(ex.StackTrace);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Something went wrong!,Please try agin ...." + ex.Message);
            }
          /* if (TxtName.Text == "" || TxtName.Text == null)
            {
                MessageBox.Show("Customer Name cannot be empty ! ");
                TxtName.Focus();
                return;
            }
            if (TxtContact.Text == "" || TxtContact.Text == null)
            {
                MessageBox.Show("Contact NO cannot be empty ! ");
                TxtContact.Focus();
                return;
            }
            if (TxtAddress.Text == "" || TxtAddress.Text == null)
            {
                MessageBox.Show("Customer Address cannot be empty ! ");
                TxtAddress.Focus();
                return;
            }*/
           
        }

        private void CustRegister_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DashBoard window = new DashBoard();
            window.Show();
            this.Hide();
        }
    }
}
