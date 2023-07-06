using System;

namespace EventPlanning
{
    public class Outdoor : Event
    {
        private string _forecast;

        public Outdoor(string forecast, string title, string desciption, string date, string time) :base(title, desciption, date, time)
        {
            _forecast = forecast;
            _type = "Outdoor Event";
        }

        public string GetOutdoorDetails()
        {
            return $"\t --{_type}--\nTitle: {_title}\n{_description}\nDate: {_date}\nTime: {_time}\nWeather Forecast: {_forecast}";
        }

    }
}