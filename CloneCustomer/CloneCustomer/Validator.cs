using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloneCustomer
{
    /// <summary>
    /// Validator class has methods that has methods for validating inputs from
    /// the user
    /// </summary>
    public static class Validator
	{
        // Global variable
		private static string title = "Entry Error";

        /// <summary>
        /// Getter and setter for title
        /// </summary>
		public static string Title
		{
			get
			{
				return title;
			}
			set
			{
				title = value;
			}
		}

        /// <summary>
        /// Checks that the textbox isnt empty
        /// </summary>
        /// <param name="textBox"> a textbox </param>
        /// <returns> true of false </returns>
		public static bool IsPresent(TextBox textBox)
		{
			if (textBox.Text == "")
			{
				MessageBox.Show(textBox.Tag + " is a required field.", Title);
				textBox.Focus();
				return false;
			}
			return true;
		}

        /// <summary>
        /// Checks that the inbox contains decimals
        /// </summary>
        /// <param name="textBox"> a textbox</param>
        /// <returns> true of false </returns>
        public static bool IsDecimal(TextBox textBox)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be a decimal value.", Title);
                textBox.Focus();
                return false;
            }
        }

        /// <summary>
        /// Checks that the inbox contains integers
        /// </summary>
        /// <param name="textBox"> a textbox </param>
        /// <returns> true of false </returns>
        public static bool IsInt32(TextBox textBox)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be an integer.", Title);
                textBox.Focus();
                return false;
            }
        }

        /// <summary>
        /// Checks that the inbox input is within a range
        /// </summary>
        /// <param name="textBox"> a textbox </param>
        /// <param name="min">min value</param>
        /// <param name="max">max value</param>
        /// <returns>true of false</returns>
		public static bool IsWithinRange(TextBox textBox, decimal min, decimal max)
		{
			decimal number = Convert.ToDecimal(textBox.Text);
			if (number < min || number > max)
			{
				MessageBox.Show(textBox.Tag + " must be between " + min
					+ " and " + max + ".", Title);
				textBox.Focus();
				return false;
			}
			return true;
		}

        /// <summary>
        /// Checks that the inbox is a valid email
        /// </summary>
        /// <param name="textBox"> a textbox </param>
        /// <returns>true of false</returns>
        public static bool IsValidEmail(TextBox textBox)
        {
            if (textBox.Text.IndexOf("@") == -1 ||
                 textBox.Text.IndexOf(".") == -1)
            {
                MessageBox.Show(textBox.Tag + " must be a valid email address.",
                    Title);
                textBox.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
