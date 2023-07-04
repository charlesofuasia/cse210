using System;

namespace OnlineOrder
{
    public class Customer
    {
        private string _customerName;
        private Address _customerAddress;

        public string GetCustomerName()
        {
            return _customerName;
        }

        public Address GetAddress(string street, string city, string state, string country)
        {
            Address address = new Address(street, city, state, country);
            return address;
        }

        public bool IsAmericanCustomer()
        {
           return _customerAddress.InUSA();
        }
    }
}