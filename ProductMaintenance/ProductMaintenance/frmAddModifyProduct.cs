using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductMaintenance
{
    /// <summary>
    /// Modified by Nigel Mansell 3/20/17
    /// </summary>
    public partial class frmAddModifyProduct : Form
    {
        public frmAddModifyProduct()
        {
            InitializeComponent();
        }

        public bool addProduct;
        public Product product;

        private void frmAddModifyProduct_Load(object sender, EventArgs e)
        {
            if (addProduct)
            {
                this.Text = "Add Product";
                txtCode.ReadOnly = false;
                txtCode.TabStop = true;
                txtCode.Focus();
            }
            else
            {
                this.Text = "Modify Product";
                txtCode.ReadOnly = true;
                txtCode.TabStop = false;
                txtDescription.Focus();
                this.DisplayProduct();
            }
        }

        private void DisplayProduct()
        {
            txtCode.Text = product.Code;
            txtDescription.Text = product.Description;
            txtPrice.Text = product.Price.ToString();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            
            if (IsValidData())
            {
                if (addProduct)
                {
                    product = new Product();
                    this.PutProductData(product);
                    try
                    {
                        // Calls the AddProduct method of the ProductDB class.
                        // if false, displays a message to user, if true, adds.
                        if (! ProductDB.AddProduct(product))
                        {
                            MessageBox.Show("Another product with the same" +
                            " code already exists.", "Database Error");
                        this.DialogResult = DialogResult.Retry;

                        }
                        else
                        {
                          
                            this.DialogResult = DialogResult.OK;
                        }
                         

                    }
                    catch (Exception ex)
                    {
                        
                        
                       MessageBox.Show(ex.Message, ex.GetType().ToString());
                       
                        
                    }
                }
                else
                {
                    Product newProduct = new Product();
                    newProduct.Code = product.Code;
                    this.PutProductData(newProduct);
                    try
                    {
                        // Calls the UpdateProduct method of the ProductDB class.
                        // if false, displays a message to user, if true, updates.
                        if (! ProductDB.UpdateProduct(product, newProduct))
                        {
                            MessageBox.Show("Another user has updated or " +
                                "deleted that product.", "Database Error");
                            this.DialogResult = DialogResult.Retry;
                        }
                        else
                        {
                            product = newProduct;
                            this.DialogResult = DialogResult.OK;
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
            }
        }

        private bool IsValidData()
        {
            return
                Validator.IsPresent(txtCode) &&
                Validator.IsPresent(txtDescription) &&
                Validator.IsPresent(txtPrice) &&
                Validator.IsDecimal(txtPrice);
        }

        private void PutProductData(Product product)
        {
            product.Code = txtCode.Text;
            product.Description = txtDescription.Text;
            product.Price = Convert.ToDecimal(txtPrice.Text);
        }
    }
}
