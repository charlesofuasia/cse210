using System;

namespace EventPlanning
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Welcome to Event Information Display.");

            Address add1 = new Address("Civic Center", "Victoria Island", "Lagos", "Nigeria");
            Address add2 = new Address("Muson Center", "Onikan", "Lagos", "Nigeria");
            Address add3 = new Address("Corniche Beach", "Abu Dhabi", "Abu Dhabi Emirate", "UAE");

            Lecture lecture = new Lecture("John Doe", 500, "Family and Society", "How family can help build a better society", "20th July, 2023", "12:00 PM", add1);
            Reception reception = new Reception("mgr@event.com", "Fund Raising", "Raising fund to build a center for autistic children", "31st July, 2023", "4:30 PM", add2);
            Outdoor outdoor = new Outdoor("Clear Weather, 75F", "WOMAD 2023", "World Music Festival, Abu Dhabi", "16th November, 2023", "7:00PM - 11::00 PM", add3);


            Console.WriteLine("\nWhich event are you interested in?");
            Console.WriteLine("Choose any of 1 - 4\n1. Lecture.\n2. Reception.\n3. Outdoor\n4. Exit");
            string eventType = Console.ReadLine();

            switch (eventType)
            {
                case "1":
                    Console.WriteLine("How do you want the lecture information displayed?");
                    Console.WriteLine("Choose any of 1-3:\n1. Summarized\n2. Details \n3.Full Information");
                    string lectureFormat = Console.ReadLine();
                    switch (lectureFormat)
                    {
                        case "1":
                            lecture.EventSummary();
                            break;

                        case "2":
                            lecture.EventDetails();
                            break;

                        case "3":
                            lecture.GetLectureDetails();
                            break;

                        default:
                            Console.WriteLine("Wrong entry. Choose 1 - 3");
                            break;
                    }
                    break;

                case "2":
                    Console.WriteLine("How do you want the reception information displayed?");
                    Console.WriteLine("Choose any of 1-3:\n1. Summarized \n2. Details \n 3.Full Information");
                    string receptionFormat = Console.ReadLine();
                    switch (receptionFormat)
                    {
                        case "1":
                            reception.EventSummary();
                            break;

                        case "2":
                            reception.EventDetails();
                            break;

                        case "3":
                            reception.GetReceptionDetails();
                            break;

                        default:
                            Console.WriteLine("Wrong entry. Choose 1 - 3");
                            break;

                    }
                    break;

                case "3":
                    Console.WriteLine("How do you want the outdoor information displayed?");
                    Console.WriteLine("Choose any of 1-3:\n1. Summarized \n2. Details \n 3.Full Information");
                    string outdoorFormat = Console.ReadLine();
                    switch (outdoorFormat)
                    {
                        case "1":
                            outdoor.EventSummary();
                            break;

                        case "2":
                            outdoor.EventDetails();
                            break;

                        case "3":
                            outdoor.GetOutdoorDetails();
                            break;

                        default:
                            Console.WriteLine("Wrong Entry. Choose 1 - 3");
                            break;
                    }
                    break;

                case "4":
                    break;

                default:
                    Console.WriteLine("Wrong entry. Choose 1 - 3");
                    break;


            }
        }
    }
}