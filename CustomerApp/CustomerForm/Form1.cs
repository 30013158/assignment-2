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
         static List<Customer> CustomerDB = new List<Customer>();

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
                string findName = txtBoxSearch.Text;  //storing data from search textbox in string variable
                txtBoxSearch.Clear(); //clears search text box
                ClearDisplay();  //calls clear display method to clear the listbox

                for (int i = 0; i <= CustomerDB.Count; i++)
                {
                    if (CustomerDB[i].FName == findName)
                    { int index = i;
                        listBox1.Items.Add(CustomerDB[i].GetCustomer());
                    }
                    else
                    {
                        MessageBox.Show("Customer not found, please try again");
                        txtBoxSearch.Focus();
                    }

                }
                 
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

        //
        private void btnclearList_Click(object sender, EventArgs e)
        {
            ClearDisplay();
            txtBoxSearch.Focus();
            btnadd.Enabled = true; 
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtBoxFName.Text == "" || txtBoxLName.Text == "" || txtBoxPhone.Text == "")
            {
                MessageBox.Show("All textboxes must be filled to continue.");
            }
            else
            {
                CustomerDB.Add(new Customer(txtBoxFName.Text, txtBoxLName.Text,txtBoxPhone.Text));
                ClearBoxes();
                ClearDisplay();
                DisplayCustomers();
                MessageBox.Show("New Customer has been added.");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            //if statement to see if an item is selected
            string selection = listBox1.SelectedItem.ToString();
             if( selection == "")
            {
                MessageBox.Show("Please select a customer to delete.");
                ClearDisplay();
                ClearBoxes();
            }
            else
            {

            }

            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnadd.Enabled = false;   //disables the add button when an item is selected
            //string[] selectedCustomer = { listBox1.SelectedItem.ToString(), };
            //string[] selectedCustomer = {listBox1.SelectedItem.FName, listBox1.SelectedItem.LName, listBox1.SelectedItem.Phone}
            // selectedCustomer[0] = txtBoxFName.Text;


        }
    }
}
