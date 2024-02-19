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
    public partial class AddNew : Form
    {
        public AddNew()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashBoard window = new DashBoard();
            window.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)

        {
            try
            {
                
                    InsertFood ob1 = new InsertFood();
                    ob1.Food_ID1 = txtFoodId.Text;
                    ob1.Food_Name1 = txtFoodName.Text;
                    ob1.Price1 = Convert.ToInt32(txtPrice.Text);
                    new ItemDB().insert(ob1.Food_ID1, ob1.Food_Name1, ob1.Price1);
                
        
        
            
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid Inputs");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something went wrong!,please try again"+ex.Message);
            }
            double Price;
            if (double.TryParse(txtPrice.Text, out Price))
                    {
                MessageBox.Show("Price Should be numerical");
                txtPrice.Focus();return;
            }










        }

        private void AddNew_Load(object sender, EventArgs e)
        {

        }
    }      
        
}
    
    

