using System;

namespace OnlineOrder
{
    public class Address
    {
        private string _street;
        private string _city;
        private string _state;
        private string _country;

        public Address(string street, string city, string state, string country)
        {
            _street = street;
            _city = city;
            _state = state;
            _country = country;
        }

        public string GetCountry()
        {
            return _country;
        }

        public string GetStreet()
        {
            return _street;
        }

        public string GetCity()
        {
            return _city;
        }

        public string GetState()
        {
            return _state;
        }

        public bool InUSA()
        {
            if (_country == "USA")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string FormatAddress()
        {
            return $"{GetStreet()}\n{GetCity()}\n{GetState()}\n{GetCountry()}";
        }

    }
}