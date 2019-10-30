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
        static int currentIndex = 0;
        static bool selected = false;

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
            bool check = false;
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

                for (int i = 0; i < CustomerDB.Count; i++)
                {
                    if (CustomerDB[i].FName == findName)
                    {
                        currentIndex = i;
                        listBox1.Items.Add(CustomerDB[i].GetCustomer());
                        check = true;
                    }
                }
                if(check == false)
                 {
                    MessageBox.Show("Customer not found, please try again");
                    txtBoxSearch.Focus();
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

        //Update button
        private void btnupdate_Click(object sender, EventArgs e)
        {
            if(selected != true)
            {
                MessageBox.Show("Please select a customer to update.");
                ClearDisplay();
                DisplayCustomers();
                selected = false;
            }
            else
            {
                if (txtBoxFName.Text == "" || txtBoxLName.Text == "" || txtBoxPhone.Text == "")
                {
                    MessageBox.Show("All textboxes must be filled to continue.");

                   
                }
                else
                {
                    CustomerDB[listBox1.SelectedIndex].FName = txtBoxFName.Text;
                    CustomerDB[listBox1.SelectedIndex].LName = txtBoxLName.Text;
                    CustomerDB[listBox1.SelectedIndex].Phone = txtBoxPhone.Text;
                    ClearBoxes();
                    ClearDisplay();
                    DisplayCustomers();
                    MessageBox.Show("Customer Details Updated");
                    btnadd.Enabled = true;
                }
                
            }
            
        }

        //Add button first check to see if all the textboxes for new customer details
        // are filled out and then adds the new customer to the customer DB list

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

        //Delete button
        //i used the foolowing links to search for message buttons and removing selected items
        /* https://www.c-sharpcorner.com/UploadFile/mahesh/understanding-message-box-in-windows-forms-using-C-Sharp */
        /*https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.listbox.selectedindex?view=netframework-4.8*/


        private void btndelete_Click(object sender, EventArgs e)
        {
            //if statement to see if an item is selected

            if (selected != true)
            {
                MessageBox.Show("Please select a customer to delete.");
                ClearDisplay();
                DisplayCustomers();
                selected = false;
            }
            else
            {
                

                string message = "Are you sure you want to delete this customer?";
                string title = "Delete Customer";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);

                if (result == DialogResult.Yes)
                {
                    listBox1.Items.RemoveAt(currentIndex);
                    ClearBoxes();
                    ClearDisplay();
                    DisplayCustomers();
                    MessageBox.Show("The customer has been deleted.");
                }
                else
                {
                    MessageBox.Show("Operation cancelled.");
                }
            }
               
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnadd.Enabled = false;   //disables the add button when an item is selected
            selected = true;
            string[] selectedCustomer = new string[3];
            selectedCustomer = listBox1.SelectedItem.ToString().Split();
            

           txtBoxFName.Text = selectedCustomer[0];
            txtBoxLName.Text = selectedCustomer[1];
            txtBoxPhone.Text = selectedCustomer[2];

            foreach(Customer c in CustomerDB)
            {
                if (c.FName == selectedCustomer[0])
                { currentIndex = CustomerDB.IndexOf(c); }
            }
        }
    }
}
