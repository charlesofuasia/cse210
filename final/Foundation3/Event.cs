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
        protected Address _address;

        public Event(string title, string desciption, string date, string time, Address address)
        {
            _title = title;
            _description = desciption;
            _date = date;
            _time = time;
            _address = address;
        }

        public void EventSummary()
        {
            Console.Clear();
            Console.WriteLine($"\t {_type}\n{_title}\n{_date}\n{_time}");
        }

        public void EventDetails()
        {
            Console.Clear();
            Console.WriteLine($"\t {_title}\n{_description}\n{_date}\n{_time}\n\t  *****\n{_address.GetAddress()}");
        }

    }
}