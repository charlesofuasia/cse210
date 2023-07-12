using System;

namespace EventPlanning
{
    public class Address
    {
        private string _venue;
        private string _city;
        private string _state;
        private string _country;

        public Address(string venue, string city, string state, string country)
        {
            _venue = venue;
            _city = city;
            _state = state;
            _country = country;
        }

        public string GetVenue()
        {
            return _venue;
        }
        public string GetCity()
        {
            return _city;
        }
        public string GetCountry()
        {
            return _country;
        }
        public string GetState()
        {
            return _state;
        }

        public string GetAddress()
        {
            return $"Venue: {GetVenue()} - {GetCity()}\n{GetState()} - {GetCountry()}";
        }
    }
}