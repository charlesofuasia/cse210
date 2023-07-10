using System;

namespace ExerciseTracker
{
    public abstract class Activity
    {
        protected string _activityName;
        protected string _activityDate;
        protected int _activityDuration;

        public Activity(string date, int time)
        {
            _activityDate = date;
            _activityDuration = time;
        }

        public string GetActivity()
        {
            return _activityName;
        }

        public string GetDate()
        {
            return _activityDate;
        }

        public int GetDuration()
        {
            return _activityDuration;
        }

        public abstract double GetSpeed();
        public abstract double GetDistance();
        public abstract double GetPace();
        public string GetSummary()
        {
            return $"{GetDate()}: {GetActivity()} ({GetDuration()} mins)- {Math.Round(GetDistance(), 2)} km, {Math.Round(GetSpeed(), 2)} kph, {Math.Round(GetPace(), 2)} min/km";
        }

    }
}