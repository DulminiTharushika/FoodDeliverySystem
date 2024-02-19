using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliverySystem
{
    public class order
    {
        private string Telephone_no;
        private string food_ID;
        private int qty;
        private string food_name;

        public string Telephone_No { get => Telephone_no; set => Telephone_no = value; }
        public string Food_ID { get => food_ID; set => food_ID = value; }
        public int Qty { get => qty; set => qty = value; }
        public string Food_name { get => food_name; set => food_name = value; }
    }

    
}
