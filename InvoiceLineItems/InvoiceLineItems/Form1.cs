using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceLineItems
{

    /// <summary>
    /// The form class uses a form loader to take in information from a 
    /// database and displays it to the user.
    /// Completed by: Nigel Mansell
    /// Date: 4/7/2017
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// creates to list objects and sets them equal to static LineItemDB
        /// list and static InvoiceDB list. Uses LINQ to join them, loops through 
        /// checking for duplicate IDs, then adds each correct element to a
        /// listView.
        /// </summary>
        /// <param name="sender"> see system.objet class </param>
        /// <param name="e"> see system.eventargs class </param>
        private void Form1_Load(object sender, EventArgs e)
        {
            List<LineItem> lineItemList = LineItemDB.GetLineItems();
            List<Invoice> invoiceList = InvoiceDB.GetInvoices();

            // Uses LINQ to join the lists above
            var items = from lineItem in lineItemList
                        join invoice in invoiceList
                        on lineItem.InvoiceID equals invoice.InvoiceID
                        orderby lineItem.InvoiceID, invoice.InvoiceDate descending
                        select new
                        { lineItem.InvoiceID,invoice.InvoiceDate,
                          invoice.InvoiceTotal, lineItem.ProductCode,
                          lineItem.UnitPrice, lineItem.Quantity,
                          lineItem.ItemTotal };

            // loops through the LINQ and check for duplicates before adding
            // to the listView. Duplicates will be replaced with white space.
            string invoiceID = "";
            int i = 0;
            foreach (var item in items)
            {
                if (item.InvoiceID.ToString() != invoiceID)
                {
                    listView1.Items.Add(item.InvoiceID.ToString());
                    listView1.Items[i].SubItems.Add(Convert.ToDateTime(item.InvoiceDate).ToShortDateString());
                    listView1.Items[i].SubItems.Add(item.InvoiceTotal.ToString("c"));
                    invoiceID = item.InvoiceID.ToString();

                }
                else
                {
                    listView1.Items.Add("");
                    listView1.Items[i].SubItems.Add("");
                    listView1.Items[i].SubItems.Add("");
                }
                listView1.Items[i].SubItems.Add(item.ProductCode.ToString());
                listView1.Items[i].SubItems.Add(item.UnitPrice.ToString("c"));
                listView1.Items[i].SubItems.Add(item.Quantity.ToString());
                listView1.Items[i].SubItems.Add(item.ItemTotal.ToString("c"));
                
                i += 1;
            }
        }
    }
}
