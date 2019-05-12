using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductMaintenance
{
    /// <summary>
    /// Form class, binding navigator
    /// Author: Nigel Mansell
    /// Date: 3/5/2017
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// The constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// validates first the checks if any information is wrong, if it is,
        /// throws error
        /// </summary>
        /// <param name="sender"> see System.object </param>
        /// <param name="e"> see Sstem.EvenArgs </param>
        private void productsBindingNavigatorSaveItem_Click_1(object sender,
            EventArgs e)
        {
            this.Validate();
            try
            {
                this.productsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.mMABooksDataSet);
                
            }
            // for concurrency
            catch (DBConcurrencyException)
            {
                MessageBox.Show("A concurrency error occured. " +
                    "Some rows were not updated.", "Concurrency Exception");
                this.productsTableAdapter.Fill(this.mMABooksDataSet.Products);
            }
            // all other issues
            catch (DataException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                productsBindingSource.CancelEdit();
            }

            
            
        }

        /// <summary>
        /// Loads the form, fills in info from the database
        /// </summary>
        /// <param name="sender"> see System.object </param>
        /// <param name="e"> see System.EvenArgs </param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMABooksDataSet.Products' table. You can move, or remove it, as needed.
            
            try
            {
                this.productsTableAdapter.Fill(this.mMABooksDataSet.Products);
            }
            // if there is a database error
            catch (SqlException ex)
            {
                MessageBox.Show("Database error # " + ex.Number +
                    ": " + ex.Message, ex.GetType().ToString());
            }
           
        }

        /// <summary>
        /// Checks for empty strings or invalid data
        /// </summary>
        /// <param name="sender"> See System.object</param>
        /// <param name="e"></param>
        private void productsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            int row = e.RowIndex + 1;
            String errorMessage = "A data error occured. \n" +
                "Row: " + row + "\n" +
                "Error: " + e.Exception.Message;
            MessageBox.Show(errorMessage, "Data Error");
        }
    }
}
