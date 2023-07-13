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

        public override void GetFullDetails()
        {
            Console.Clear();
            Console.WriteLine($"{GetEventDetails()}\nWeather Forecast: {_forecast}");
        }

    }
}