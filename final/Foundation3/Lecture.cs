using System;

namespace EventPlanning
{
    public class Lecture : Event
    {
        private string _speaker;
        private int _capacity;

        public Lecture(string speaker, int capacity, string title, string desciption, string date, string time) :base(title, desciption, date, time)
        {
            _speaker = speaker;
            _capacity = capacity;
            _type = "Lecture";
        }

        public string GetLectureDetails()
        {
            return $"\t --{_type}--\nTitle: {_title}\nSpeaker: {_speaker}\n{_description}\nDate: {_date}\nTime: {_time}";
        }
    }
}