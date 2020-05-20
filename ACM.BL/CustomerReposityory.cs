using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerReposityory
    {
        public CustomerReposityory()
        {
          addressRepository = new AddressRepository();
        }
        //Customer repo ile Address Repo arasındaki ilişkiyi oluşturduk.
        private AddressRepository addressRepository { get; set; }
        public Customer Retrieve (int customerId)
        {
            Customer customer = new Customer(customerId);

            if(customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }

            return customer;
        }


        public bool Save()

        {
            return true;
        }
    }
}
