using System;

namespace EventPlanning
{
    public class Reception : Event
    {
        private string _rsvp;

        public Reception(string rsvp, string title, string desciption, string date, string time, Address address) : base(title, desciption, date, time, address)
        {
            _rsvp = rsvp;
            _type = "Reception";
        }

        public override void GetFullDetails()
        {
            Console.Clear();
            Console.WriteLine($"{GetEventDetails()}\nRSVP: {_rsvp}");
        }
    }
}