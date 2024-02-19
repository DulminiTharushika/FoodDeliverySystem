using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodDeliverySystem
{
    public partial class FoodOrder : Form
    {

        
        public FoodOrder()
        {
            InitializeComponent();

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        

        private void FoodOrder_Load(object sender, EventArgs e)
        {

            MySqlConnection con = new DBConnection().ConnectDB();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashBoard window = new DashBoard();
            window.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e) {

        }

        private void BtnPlace_Click(object sender, EventArgs e)
        {
            
            
                order o1 = new order();
                o1.Telephone_No = TxtContact.Text;
        
                o1.Food_name = CmbRice.SelectedItem.ToString();
                new Sel().select(o1.Food_name);
                o1.Qty = Convert.ToInt32(Txt1.Text);
                new orderEnter().FoodEnter(o1.Telephone_No, o1.Food_ID, o1.Food_name, o1.Qty);
            
            
            
                order o2 = new order();
                o2.Telephone_No = TxtContact.Text;
                 new Sel().select(o2.Food_name); ;
                o2.Food_name = CmbKottu.SelectedItem.ToString();
                o2.Qty = Convert.ToInt32(Txt2.Text);
                new orderEnter().FoodEnter(o2.Telephone_No, o2.Food_ID, o2.Food_name, o2.Qty);
            
            
            
                order o3 = new order();
                o3.Telephone_No = TxtContact.Text;
                new Sel().select(o3.Food_name); ;
                o3.Food_name = CmbSandwitch.SelectedItem.ToString();
                o3.Qty = Convert.ToInt32(Txt3.Text);
                new orderEnter().FoodEnter(o3.Telephone_No, o3.Food_ID, o3.Food_name, o3.Qty);
            
            
            
                order o4 = new order();
                o4.Telephone_No = TxtContact.Text;
                new Sel().select(o4.Food_name); 
                o4.Food_name = CmbKottu.SelectedItem.ToString();
                o4.Qty = Convert.ToInt32(Txt4.Text);
                new orderEnter().FoodEnter(o4.Telephone_No, o4.Food_ID, o4.Food_name, o4.Qty);
            
            
            
                order o5 = new order();
                o5.Telephone_No = TxtContact.Text;
                new Sel().select(o5.Food_name); 
                o5.Food_name = CmbKottu.SelectedItem.ToString();
                o5.Qty = Convert.ToInt32(Txt5.Text);
                new orderEnter().FoodEnter(o5.Telephone_No, o5.Food_ID, o5.Food_name, o5.Qty);
            
          
            
                order o6 = new order();
                o6.Telephone_No = TxtContact.Text;
                new Sel().select(o6.Food_name); 
                o6.Food_name = CmbKottu.SelectedItem.ToString();
                o6.Qty = Convert.ToInt32(Txt6.Text);
                new orderEnter().FoodEnter(o6.Telephone_No, o6.Food_ID, o6.Food_name, o6.Qty);
            
            
            
                order o7 = new order();
                o7.Telephone_No = TxtContact.Text;
                new Sel().select(o7.Food_name);
                o7.Food_name = CmbKottu.SelectedItem.ToString();
                o7.Qty = Convert.ToInt32(Txt2.Text);
                new orderEnter().FoodEnter(o7.Telephone_No, o7.Food_ID, o7.Food_name, o7.Qty);
            
        }
    }
}
