using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{
    /// <summary>
    /// The parent class, that validates data, has a getter, and uses credit to
    /// add to balance and debit to subtract
    /// Author: Nigel Mansell
    /// Date: 2/12/17
    /// </summary>
    public class Account
    {
        // Field
        private decimal balance;

        /// <summary>
        /// The constructor, initializes the field
        /// </summary>
        public Account(decimal balance)
        {
            this.balance = balance;
        }

        /// <summary>
        /// Validates that the balance is not less than zero
        /// </summary>
        public decimal validate
        {
            get
            {
                if (balance < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return balance;
            }

        }

        /// <summary>
        /// Gets the balance
        /// </summary>
        public decimal getBalance
        {
            get
            {
                return balance;
            }
        }

        /// <summary>
        /// Checks if there was a withdrawl and makes sure the amount isnt more
        /// than the balance, then subtracts from balance
        /// </summary>
        public bool debit(decimal amount)
        {
            decimal tempBalance = balance;
            decimal change = tempBalance - amount;
            if (change < balance & change > 0)
            {
                balance -= amount;
                return true;
            }
            else
                return false;

        }

        /// <summary>
        /// Adds the amount to the balance
        /// </summary>
        public bool credit(decimal amount)
        {
            balance += amount;
            return false;
        }
    }
}
