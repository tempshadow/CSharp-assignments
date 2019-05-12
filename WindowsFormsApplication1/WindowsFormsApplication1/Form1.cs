using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    /**************************************************************************
     * This class will take in data from a user, use the data to calculate a 
     * total, then display it back to the user. 
     * Auther: Nigel Mansell
     * Completion Date: 1/22/2017
     *************************************************************************/
    public partial class Daily_Cost_Calculator : Form
    {
        // Global variables for each input from the user.
        private int totalMiles = 0;
        private int costPerGallon = 0;
        private double averageMPG = 0;
        private int parkingFees = 0;
        private int tollCost = 0;
        private double total = 0;

        /**************************
         * Constructor for class.
         *************************/
        public Daily_Cost_Calculator()
        {
            InitializeComponent();
        }

        /**********************************************************************
         * This method is the event handler that will take in information from
         * a text box, convert it to an int or a double, use math to calculate
         * the total, then convert back to a string and displays it for the 
         * user.
         *********************************************************************/
        private void totalButton_Click(object sender, EventArgs e)
        {
            // Converts the text from the user into an int or double.
            totalMiles = Convert.ToInt32(totalMilesText.Text);
            costPerGallon = Convert.ToInt32(costPerGallonText.Text);
            averageMPG = Convert.ToDouble(averageMPGText.Text);
            parkingFees = Convert.ToInt32(parkingFeesText.Text);
            tollCost = Convert.ToInt32(tollsCostText.Text);
            
            // Calculates the total.
            total = ((totalMiles * costPerGallon) / averageMPG) + parkingFees + tollCost;

            // Converts back to a string and is displayed to the user
            totalText.Text = Convert.ToString(total);
        }

        /********************
         * This method is an event handler for the program to close with the
         * "Exit" button.
         */
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
