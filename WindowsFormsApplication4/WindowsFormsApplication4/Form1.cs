using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    /**************************************************************************
     * This class allows the user to select a main course and add ons for that
     * course. Adds the prices accordingly and then adds tax for the total.
     * Author: Nigel Mansell
     * Date: 2/5/17
     *************************************************************************/
    public partial class Form1 : Form
    {
        // Global variables for calculation
        private double hamburger = 6.95;
        private double pizza = 5.95;
        private double salad = 4.95;
        private double addOnItem1 = 0.0;
        private double addOnItem2 = 0.0;
        private double addOnItem3 = 0.0;
        private double addOnTotal = 0.0;
        private double subtotal = 0.0;
        private double tax = 0.0775;
        private double total = 0.0;
        private double subTax = 0.0;

        /************
         * Constructor
         ***********/
        public Form1()
        {
            InitializeComponent();
        }

        /**************************************************************
         * Clears out each of the boxs within the Order Total group box
         *************************************************************/
        public void ClearTotals()
        {
            textBoxSubtotal.Text = "$0.00";
            textBoxTax.Text = "$0.00";
            textBoxTotal.Text = "$0.00";
        }

        /**********************************
         * un-checks each check box
         *********************************/
        public void ClearAddOns()
        {
            addOn1.Checked = false;
            addOn2.Checked = false;
            addOn3.Checked = false;
        }

        /**********************************************************************
         * the first radio button that will clear the Order total and un-check
         * all boxes. Changes the text for groupBoxAddonItems and all the check
         * boxs
         *********************************************************************/
        private void radioButtonHamburger_CheckedChanged(object sender, EventArgs e)
        {
            ClearAddOns();
            ClearTotals();
            addOnTotal = 0.0;

            if (radioButtonHamburger.Checked == true)
            {
                groupBoxAddOnItems.Text = "Add-on items ($.75/each)";
                addOn1.Text = "Lettuce, tomato, and onions";
                addOn2.Text = "Ketchup, mustard, and mayo";
                addOn3.Text = "French fries";
                
            }
        }

        /**********************************************************************
         * the second radio button that will clear the Order total and un-check
         * all boxes. Changes the text for groupBoxAddonItems and all the check
         * boxs
         *********************************************************************/
        private void radioButtonPizza_CheckedChanged(object sender, EventArgs e)
        {
            ClearAddOns();
            ClearTotals();
            addOnTotal = 0.0;

            if (radioButtonPizza.Checked == true)
            {
                groupBoxAddOnItems.Text = "Add-on items ($.50/each)";
                addOn1.Text = "Pepperoni";
                addOn2.Text = "Sausage";
                addOn3.Text = "Olives";
                
            }

        }

        /**********************************************************************
         * the third radio button that will clear the Order total and un-check
         * all boxes. Changes the text for groupBoxAddonItems and all the check
         * boxs
         *********************************************************************/
        private void radioButtonSalad_CheckedChanged(object sender, EventArgs e)
        {
            ClearAddOns();
            ClearTotals();
            addOnTotal = 0.0;

            if (radioButtonSalad.Checked == true)
            {
                groupBoxAddOnItems.Text = "Add-on items ($.25/each)";
                addOn1.Text = "Croutons";
                addOn2.Text = "Bacon bits";
                addOn3.Text = "Bread sticks";
                
            }

        }

        /**********************************************************************
         * The first check box. Clears the totals and adds or subtracts
         * its cost to the global variable "addOnTotal" for later calculations
         *********************************************************************/
        private void addOn1_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();
            
            // if it is checked, item is changed to match the correct price,
            // then is added to addOnTotal
            if (addOn1.Checked == true)
            {
                if (radioButtonHamburger.Checked == true)
                {
                    addOnItem1 = .75;
                    addOnTotal += addOnItem1;
                }

                else if (radioButtonPizza.Checked == true)
                {
                    addOnItem1 = .50;
                    addOnTotal += addOnItem1;
                }

                else if (radioButtonSalad.Checked == true)
                {
                    addOnItem1 = .25;
                    addOnTotal += addOnItem1;
                }
            }

            // if it is un-checked, item is changed to match the correct price,
            // then is subtracted from addOnTotal
            if (addOn1.Checked == false)
            {
                if (radioButtonHamburger.Checked == true)
                {
                    addOnItem1 = .75;
                    addOnTotal -= addOnItem1;
                }

                else if (radioButtonPizza.Checked == true)
                {
                    addOnItem1 = .50;
                    addOnTotal -= addOnItem1;
                }

                else if (radioButtonSalad.Checked == true)
                {
                    addOnItem1 = .25;
                    addOnTotal -= addOnItem1;
                }

            }

        }

        /**********************************************************************
         * The second check box. Clears the totals and adds or subtracts
         * its cost to the global variable "addOnTotal" for later calculations
         *********************************************************************/
        private void addOn2_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();

            // if it is checked, item is changed to match the correct price,
            // then is added to addOnTotal
            if (addOn2.Checked == true)
            {
                if (radioButtonHamburger.Checked == true)
                {
                    addOnItem2 = .75;
                    addOnTotal += addOnItem2;
                }

                else if (radioButtonPizza.Checked == true)
                {
                    addOnItem2 = .50;
                    addOnTotal += addOnItem2;
                }

                else if (radioButtonSalad.Checked == true)
                {
                    addOnItem2 = .25;
                    addOnTotal += addOnItem2;
                }
            }

            // if it is un-checked, item is changed to match the correct price,
            // then is subtracted from addOnTotal
            if (addOn2.Checked == false)
            {
                if (radioButtonHamburger.Checked == true)
                {
                    addOnItem2 = .75;
                    addOnTotal -= addOnItem2;
                }

                else if (radioButtonPizza.Checked == true)
                {
                    addOnItem2 = .50;
                    addOnTotal -= addOnItem2;
                }

                else if (radioButtonSalad.Checked == true)
                {
                    addOnItem2 = .25;
                    addOnTotal -= addOnItem2;
                }

            }


        }

        /**********************************************************************
         * The third check box. Clears the totals and adds or subtracts
         * its cost to the global variable "addOnTotal" for later calculations
         *********************************************************************/
        private void addOn3_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();

            // if it is checked, item is changed to match the correct price,
            // then is added to addOnTotal
            if (addOn3.Checked == true)
            {
                if (radioButtonHamburger.Checked == true)
                {
                    addOnItem3 = .75;
                    addOnTotal += addOnItem3;
                }

                else if (radioButtonPizza.Checked == true)
                {
                    addOnItem3 = .50;
                    addOnTotal += addOnItem3;
                }

                else if (radioButtonSalad.Checked == true)
                {
                    addOnItem3 = .25;
                    addOnTotal += addOnItem3;
                }
            }

            // if it is un-checked, item is changed to match the correct price,
            // then is subracted from addOnTotal
            if (addOn3.Checked == false)
            {
                if (radioButtonHamburger.Checked == true)
                {
                    addOnItem3 = .75;
                    addOnTotal -= addOnItem3;
                }

                else if (radioButtonPizza.Checked == true)
                {
                    addOnItem3 = .50;
                    addOnTotal -= addOnItem3;
                }

                else if (radioButtonSalad.Checked == true)
                {
                    addOnItem3 = .25;
                    addOnTotal -= addOnItem3;
                }

            }


        }
        
        /**********************************************************************
         * Calculates the subtotal, tax, and total. Displays each to the user
         *********************************************************************/
        private void calculate_Click(object sender, EventArgs e)
        {

            if (radioButtonHamburger.Checked == true)
            {
                subtotal = hamburger + addOnTotal;
                textBoxSubtotal.Text = subtotal.ToString("c");
                taxCalculation();
                textBoxTax.Text = subTax.ToString("c");
                total = subtotal + subTax;
                textBoxTotal.Text = total.ToString("c");
            }

            else if (radioButtonPizza.Checked == true)
            {
                subtotal = pizza + addOnTotal;
                textBoxSubtotal.Text = subtotal.ToString("c");
                taxCalculation();
                textBoxTax.Text = subTax.ToString("c");
                total = subtotal + subTax;
                textBoxTotal.Text = total.ToString("c");
            }

            else if (radioButtonSalad.Checked == true)
            {
                subtotal = salad + addOnTotal;
                textBoxSubtotal.Text = subtotal.ToString("c");
                taxCalculation();
                textBoxTax.Text = subTax.ToString("c");
                total = subtotal + subTax;
                textBoxTotal.Text = total.ToString("c");
            }
        }

        /*****************************
         * Calculates the tax
         ****************************/
        private void taxCalculation()
        {
            subTax = (subtotal * tax);
        }

        /*********************************
         * Exits the application on click
         ********************************/
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
