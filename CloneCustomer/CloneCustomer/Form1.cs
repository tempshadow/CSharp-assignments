using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloneCustomer
{
    /// <summary>
    /// Modified by: Nigel Mansell
    /// Date: 2/18/2017
    /// </summary>
    public partial class Form1 : Form
    {

        /// <summary>
        /// Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        //Gobal variables
        private Customer customer;
        private List<Customer> customers;

        /// <summary>
        /// Creates an object of Custmer, the displays it in lblCustomer
        /// </summary>
        /// <param name="sender"> see System.Object </param>
        /// <param name="e"> see System.EventArgs </param>
        private void Form1_Load(object sender, System.EventArgs e)
        {
            customer = new Customer("John", "Mendez", "jmendez@msysco.com");
            lblCustomer.Text = customer.GetDisplayText();
        }

        /// <summary>
        /// Exits the program when clicked
        /// </summary>
        /// <param name="sender">see System.Object</param>
        /// <param name="e">see System.EvenArgs</param>
        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// This method creats an object of Customerlist, checks the text box
        /// info through two validators and if they both, creats a clone of 
        /// the Customer object a number of times depending on how many the 
        /// user asks for, stores them the Customerlist object, then displays.
        /// </summary>
        /// <param name="sender"> see the System.Object api </param>
        /// <param name="e"> see the System.EventArgs api </param>
        private void btnClone_Click(object sender, EventArgs e)
        {
            CustomerList cloneList = new CustomerList();
            
            if (Validator.IsPresent(txtCopies) == true & Validator.IsInt32(txtCopies) == true)
            {
                for (int i = 0; i < Convert.ToInt32(txtCopies.Text); i++)
                {
                    Customer clone = (Customer)customer.Clone();
                    cloneList.Add(clone);
                }

                foreach (Customer cloned in cloneList)
                {
                    lstCustomers.Items.Add(cloned.GetDisplayText());
                }

            }

            // This code is for the 15-1 portion. To test, 
            // comment out the above code and un-comment this code


            //customers = new List<Customer>();

            //if (Validator.IsPresent(txtCopies) == true & Validator.IsInt32(txtCopies) == true)
            //{
              //   for (int i = 0; i < Convert.ToInt32(txtCopies.Text); i++)
                //{
                //Customer test = (Customer)customer.Clone();
                 //customers.Add(test);
                //}

                //foreach (Customer test in customers)
                //{
                  //lstCustomers.Items.Add(test.GetDisplayText());

                //}
            //}








        }
    }
}