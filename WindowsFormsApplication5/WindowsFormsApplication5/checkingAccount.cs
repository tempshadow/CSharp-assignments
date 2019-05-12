using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{
    /// <summary>
    /// Child class inherits from Account. Overloads credit and debit,
    /// subtracts amount and fees.
    /// Author: Nigel Mansell
    /// Date: 2/12/17
    /// </summary>
    class checkingAccount : Account
    {
        // Field
        private decimal fee;

        /// <summary>
        /// Constructor, initializes field
        /// </summary>
        /// <param name="fee"> for field </param>
        /// <param name="balance"> for base </param>
        public checkingAccount(decimal fee, decimal balance) :
            base(balance)
        {
            this.fee = fee;
        }

        /// <summary>
        /// Overloads the base class credit method. Subtracts amount and fee
        /// </summary>
        /// <param name="amount"> amount to subtract </param>
        public void credit(decimal amount)
        {
            base.credit(amount);
            base.debit(fee);
            
        }

        /// <summary>
        /// Overloads the base class debit method. Subtracts amount and fee
        /// </summary>
        /// <param name="amount"> amount to subtract </param>
        public void debit( decimal amount)
        {
            if (base.debit(amount) == true)
            {
                base.debit(fee);
            }
        }
    }
}
