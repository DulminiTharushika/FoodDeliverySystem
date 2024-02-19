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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DashBoard window = new DashBoard();
            window.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DashBoard window = new DashBoard();
            window.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
             try
            {

                DeleteFood ob1 = new DeleteFood();
                ob1.Food_ID1 = txtFoodId.Text;
                ob1.Food_Name1 = txtFoodName.Text;
                ob1.Price1 = Convert.ToDouble(txtPrice.Text);
                new DeleteDB().Delete(ob1.Food_ID1);




            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid Inputs");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong!,please try again" + ex.Message);
            }
            Double Price;
            if (Double.TryParse(txtPrice.Text, out Price))
            {
                MessageBox.Show("Price Should be numerical");
                txtPrice.Focus(); return;
            }
        }
    }
}
