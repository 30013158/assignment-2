using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerApp;

namespace CustomerForm
{
    public partial class Form1 : Form
    {
        //Creating a list of Customer objects
         List<Customer> CustomerDB = new List<Customer>();

        //LoadDB method adds 4 new Customer objects to the CustomerDB List
        public void LoadDB()
        {
            CustomerDB.Add(new Customer("Jim", "Smith", "346-2514"));
            CustomerDB.Add(new Customer("Jo", "Baker", "346-1263"));
            CustomerDB.Add(new Customer("Aimee", "Ellery", "346-3658"));
            CustomerDB.Add(new Customer("Sam", "Herewini", "346-9898"));
        }

        //ClearBoxes method clears the first name, last name and phone textboxes.
        public void ClearBoxes()
        {
            txtBoxFName.Clear();
            txtBoxLName.Clear();
            txtBoxPhone.Clear();
        }

        //ClearDisplay method clears the listbox
        public void ClearDisplay()
        {
            listBox1.Text = "";
            listBox1.Items.Clear();
        }

        //DisplayCustomers method adds each customer in CustomerDB to listbox
        public void DisplayCustomers()
        {
            foreach(Customer x in CustomerDB)
            {
                listBox1.Items.Add(x.GetCustomer());
            }
        }


        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtBoxSearch.Text == "")
            {
              MessageBox.Show("You must enter a customer name.");
              txtBoxSearch.Focus();
            }
            else
            {
                txtBoxSearch.Clear();

                //if
                
            }
        }

        /*List Customers Button first clears all the items in the listbox and 
        then display the customers in CustomerDB to listbox*/
        private void btnlistCust_Click(object sender, EventArgs e)
        {
           ClearDisplay();
           DisplayCustomers();
        }

        //Form1_Load event is used to call the LoadDB method to populate the CustomerDB list
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDB();
        }


        private void btnclearList_Click(object sender, EventArgs e)
        {
            ClearDisplay();
            txtBoxSearch.Focus();
        }
    }
}
