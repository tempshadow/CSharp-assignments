using System;

namespace CloneCustomer
{
    /// <summary>
    /// Modified by: Nigel Mansell
    /// Date: 2/18/2017
    /// </summary>
    public class Customer : ICloneable
	{
        // Global variables
		private string firstName;
		private string lastName;
		private string email;

        /// <summary>
        /// Blank constructor
        /// </summary>
		public Customer()
		{
		}

        /// <summary>
        /// Constructor for class
        /// </summary>
        /// <param name="firstName"> is for global variable </param>
        /// <param name="lastName"> is for global variable </param>
        /// <param name="email"> is for global variable </param>
		public Customer(string firstName, string lastName, string email)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Email = email;
		}

        /// <summary>
        /// getter and setter for the global varibale firstName
        /// </summary>
		public string FirstName
		{
			get
			{
				return firstName;
			}
			set
			{
				firstName = value;
			}
		}

        /// <summary>
        /// getter and setter for the global varibale lastName
        /// </summary>
		public string LastName
		{
			get
			{
				return lastName;
			}
			set
			{
				lastName = value;
			}
		}

        /// <summary>
        /// getter and setter for the global varibale Email
        /// </summary>
		public string Email
		{
			get
			{
				return email;
			}
			set
			{
				email = value;
			}
		}

        /// <summary>
        /// gets the global variables for the display
        /// </summary>
        /// <returns> the global variables for output </returns>
		public string GetDisplayText() =>
			firstName + " " + lastName + ", " + email;

        /// <summary>
        /// This method is of the ICloneable interface, 
        /// creats an object of the Customer class, calls the methods of
        /// the customer class and sets them accordingly, 
        /// then retuns the object
        /// </summary>
        /// <returns> The Customer object </returns>
        public object Clone()
        {
            Customer clone = new Customer();
            clone.FirstName = this.firstName;
            clone.LastName = this.lastName;
            clone.Email = this.email;
            return clone;
        }
    }
}
