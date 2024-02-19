using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliverySystem
{
    public class customer
    {
        private string Customer_Name;
        private String Address;
        private String Telephone_No;


        public String CustomerName {

            get { return Customer_Name; }
            set { Customer_Name = value; }
        
        }

        public String CustomerAddress {

            get { return Address; }
            set { Address = value; }
        
        }
         
        public String CustomerContactNo { 

            get { return Telephone_No; }
            set { Telephone_No = value; }
        
        
        }


    }
}
