using System;

namespace OnlineOrder
{
    public class Customer
    {
        private string _customerName;
        private Address _customerAddress;

        public Customer(string customerName, Address address)
        {
            _customerName = customerName;
            _customerAddress = address;
        }

        public string GetCustomerName()
        {
            return _customerName;
        }

        public string GetAddress()
        {
            _customerAddress = new Address(_customerAddress.GetStreet(), _customerAddress.GetCity(), _customerAddress.GetState(), _customerAddress.GetCountry());
            return _customerAddress.FormatAddress();
        }

        public bool IsAmericanCustomer()
        {
           return _customerAddress.InUSA();
        }
    }
}