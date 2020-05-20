using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public Customer(): this(0) // Contrustor chaning
        {
                
        }
        public Customer(int customerid)
        {
            CustomerId = customerid;
            AddressList = new List<Address>();
        }
        
        public List<Address> AddressList{ get; set; }
        //public Address WorkAddress { get; set; }
        //public Address HomeAddress { get; set; }
        //using snippets =>  Edit -> Intellisense _> Insert Snippet
        public int CustomerId { get; private set; } // private set because customer ID will set from DB.
        public int CustomerType { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; } //  short define getter settter 
        private string _lastName; // long define getter settter
        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                _lastName = value;
            }
        }
        //FullName attributes in bottom, unit tests re FullNameFirstNameEmpy and FullNameLastNameEmpty faiil. 
        //public string FullName
        //{
        //    get
        //    {
        //        return LastName + ", " + FirstName;
        //    }
        //}

        //Updating FullName codes like in bottom
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                   
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
        public static int InstanceCount { get; set; } // static keyword is useful for tracking information shared between all instances all class.

        // Validates the customer data.

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
                

        }

        // We create CustomerRepository and Retrieve and Save method in there. So delete in here.
        //// Retrieve functions that is example for overloading , they have same name but different parameters 
        //public Customer Retrieve(int customerId)
        //{
        //    // Code that retrieves the defined  customer
        //    return new Customer();
        //}

        //public List<Customer> Retrieve()
        //{
        //    // Code that retrieves all of  the customers
        //    return new List<Customer>();
        //}
    }

   
}

