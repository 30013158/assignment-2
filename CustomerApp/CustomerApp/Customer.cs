//Developer: Rajveer Kaur
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp
{
    class Customer
    {   
        //3-auto properties 
        public string FName { get; set; }
        public string LName { get; set; }
        public string Phone { get; set; }

        //constructor
        public Customer(string fn, string ln, string ph)
        {
            FName = fn;
            LName = ln;
            Phone = ph;
        }

        //method to return all the customer data with a tab in between
        public string GetCustomer()
        {
            return "";
        }

    }
}
