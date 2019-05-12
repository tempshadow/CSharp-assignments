using System;
using System.Collections;
using System.Collections.Generic;

namespace CloneCustomer
{
    /// <summary>
    /// Modified by: Nigel Mansell
    /// Date: 2/18/2017
    /// </summary>
    public class CustomerList : IEnumerable<Customer>
	{
        // creates a list
        private List<Customer> customers = new List<Customer>();

        /// <summary>
        /// count method
        /// </summary>
		public int Count => customers.Count;
        
		public Customer this[int i] => customers[i];

        /// <summary>
        /// Add method
        /// </summary>
        /// <param name="customer"> an object of Customer class </param>
		public void Add(Customer customer) => customers.Add(customer);

        /// <summary>
        /// This method is for the IEnumerable interface, allows foreach loop 
        /// on the generic collection that I defined as Customer
        /// </summary>
        /// <returns> object customer </returns>
        public IEnumerator<Customer> GetEnumerator()
        {
            foreach (Customer customer in customers)
            {
                yield return customer;
            }
        }

        /// <summary>
        /// required for the IEnumerable interface
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
