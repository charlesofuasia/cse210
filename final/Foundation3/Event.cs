using System;

namespace EventPlanning
{
    public class Event
    {
        protected string _title;
        protected string _type;
        protected string _description;
        protected string _date;
        protected string _time;

        public Event( string title, string desciption, string date, string time)
        {
            _title = title;
            _description = desciption;
            _date = date;
            _time = time;
        }

        protected string EventSummary()
        {
            return $"\t {_type}\n{_title}\n{_date}\n{_time}";
        }

        protected string EventDetails()
        {
            return $"\t {_title}\n{_description}\n{_date}\n{_time}";
        }

    }
}