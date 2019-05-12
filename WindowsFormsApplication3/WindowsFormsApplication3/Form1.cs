using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    /****************************
     * This class takes in a 1 or a 2 from the user and assigns a seat 
     * according to availability within a boolean array.
     * Author: Nigel Mansell
     * Completion Date: 1/29/17
     ***************************/ 
    public partial class Form1 : Form
    {
        // Global varibales
        private int firstClassCounter = 0;
        private int economyCounter = 5;
        private bool[] seatArray = new bool[10];


        /***********************
         * Constructor for class
         **********************/
        public Form1()
        {
            InitializeComponent();
        }

        /**********************************************************************
         * This method is the event handler that checks if the user inters an 1
         * or a 2. Assigns accordingly and displays messages for when seats are
         * full in a section of the array and when the entire array is full.
         *********************************************************************/
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (userInput.Text != "1" & userInput.Text != "2")
            {
                String error = "Please enter 1 or 2.";
                MessageBox.Show(error, "ERROR!");
                
            }

            // Displays a message when all elements of the array are True.
            if (firstClassCounter > 4 & economyCounter > 9)
            {
                String nextFlight = "Next flight leaves in 3 hours.";

                MessageBox.Show(nextFlight, "All Seats Are Full!");
            }

            // Sets element 0-4 to True for each time 1 is pressed
            else if (userInput.Text.Equals("1") & firstClassCounter < 5)
            {
                seatArray[firstClassCounter] = true;
                firstClassCounter++;
                display1.Text = Convert.ToString(firstClassCounter + " out of 5");

            }

            // Displays a message for when 0-4 elements of the array are all
            // true, then if user answers yes, changes elements 5-9.
            else if (userInput.Text.Equals("1") & firstClassCounter > 4)
            {
                DialogResult dialogResult = MessageBox.Show("Would you like a seat in the Economy section?", "Seating Is Full!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    seatArray[economyCounter] = true;
                    economyCounter++;
                    display2.Text = Convert.ToString(economyCounter + " out of 10");
                }

                else if (dialogResult == DialogResult.No)
                {
                    string noSelection = "Next flight leaves in 3 hours.";
                    MessageBox.Show(noSelection, "Thank You!");

                }

            }

            // Sets element 0-4 to True for each time 1 is pressed
            else if (userInput.Text.Equals("2") & economyCounter < 10)
            {
                seatArray[economyCounter] = true;
                economyCounter++;
                display2.Text = Convert.ToString(economyCounter + " out of 10");

            }

            // Displays a message for when 5-9 elements of the array are all
            // true, then if user answers yes, changes elements 0-4.
            else if (userInput.Text.Equals("2") & economyCounter > 9)
            {
                DialogResult dialogResult = MessageBox.Show("Would you like a seat in the first class section?", "Seating Is Full", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    seatArray[firstClassCounter] = true;
                    firstClassCounter++;
                    display1.Text = Convert.ToString(firstClassCounter + " out of 5");
                }

                else if (dialogResult == DialogResult.No)
                {
                    string noSelection = "Next flight leaves in 3 hours.";
                    MessageBox.Show(noSelection, "Thank You!");

                }

            }
        }
    }
}
