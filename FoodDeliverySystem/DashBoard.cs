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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Form1 window = new Form1();
            window.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerVerify window = new CustomerVerify();
            window.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FoodOrder window = new FoodOrder();
            window.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddNew window = new AddNew();
            window.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Delete window = new Delete();
            window.Show();
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            payment window = new payment();
            window.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Kitchen window = new Kitchen();
            window.Show();
            this.Hide();
        }
    }
}
