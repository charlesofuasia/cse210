using System;

namespace EventPlanning
{
    public class Lecture : Event
    {
        private string _speaker;
        private int _capacity;

        public Lecture(string speaker, int capacity, string title, string desciption, string date, string time, Address address) : base(title, desciption, date, time, address)
        {
            _speaker = speaker;
            _capacity = capacity;
            _type = "Lecture";
        }

        public void GetLectureDetails()
        {
            Console.Clear();
            Console.WriteLine($"\t --{_type}--\nTitle: {_title}\nSpeaker: {_speaker}\n{_description}\nDate: {_date}\nTime: {_time}\n  ***** \n{_address.GetAddress()}");
        }
    }
}