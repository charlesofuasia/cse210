using System;

namespace EventPlanning
{
    public class Outdoor : Event
    {
        private string _forecast;

        public Outdoor(string forecast, string title, string desciption, string date, string time, Address address) : base(title, desciption, date, time, address)
        {
            _forecast = forecast;
            _type = "Outdoor Event";
        }

        public void GetOutdoorDetails()
        {
            Console.Clear();
            Console.WriteLine($"\t --{_type}--\nTitle: {_title}\n{_description}\nDate: {_date}\nTime: {_time}\nWeather Forecast: {_forecast}\n\t *****  \n{_address.GetAddress()}");
        }

    }
}