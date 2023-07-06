using System;

namespace EventPlanning
{
    public class Reception : Event
    {
        private string _rsvp;

        public Reception(string rsvp, string title, string desciption, string date, string time) :base(title, desciption, date, time)
        {
            _rsvp = rsvp;
            _type = "Reception";
        }

        public string GetReceptionDetails()
        {
            return $"\t --{_type}--\nTitle: {_title}\n{_description}\nDate: {_date}\nTime: {_time}\nRSVP: {_rsvp}";
        }
    }
}