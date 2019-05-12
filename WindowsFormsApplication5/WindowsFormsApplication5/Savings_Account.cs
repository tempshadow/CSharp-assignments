using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{
    /// <summary>
    /// Child class, inherits from Account. Adds interest to balance
    /// Authror: Nigel Mansell
    /// Date: 2/12/17
    /// </summary>
   public class savingsAccount : Account
    {
        // Field 
        private decimal interestRate;

        /// <summary>
        /// Constructor, initializes the field
        /// </summary>
        /// <param name="interestRate"> for field </param>
        /// <param name="balance"> for base class </param>
        public savingsAccount(decimal interestRate , decimal balance) :
            base(balance)
        {
            this.interestRate = interestRate;
        }

        /// <summary>
        /// Calculates the interest
        /// </summary>
        /// <returns> the balance after interest </returns>
        public decimal calculateInterest()
        {
            return base.getBalance * interestRate;
        }
    }
}
