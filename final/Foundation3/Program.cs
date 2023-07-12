using System;

namespace EventPlanning
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            List<Event> events = new List<Event>();
            Console.WriteLine("Welcome to Event Information Display.");

            Address add1 = new Address("Civic Center", "Victoria Island", "Lagos", "Nigeria");
            Address add2 = new Address("Muson Center", "Onikan", "Lagos", "Nigeria");
            Address add3 = new Address("Corniche Beach", "Abu Dhabi", "Abu Dhabi Emirate", "UAE");


            Lecture lecture = new Lecture("John Doe", 500, "Family and Society", "How family can help build a better society", "20th July, 2023", "12:00 PM", add1);
            events.Add(lecture);
            Reception reception = new Reception("mgr@event.com", "Fund Raising", "Raising fund to build a center for autistic children", "31st July, 2023", "4:30 PM", add2);
            events.Add(reception);
            Outdoor outdoor = new Outdoor("Clear Weather, 75F", "WOMAD 2023", "World Music Festival, Abu Dhabi", "16th November, 2023", "7:00PM - 11::00 PM", add3);
            events.Add(outdoor);

            foreach (Event item in events)
            {
                item.EventSummary();
                item.EventDetails();
                item.GetFullDetails();
                Console.WriteLine();
            }

            
        }
    }
}