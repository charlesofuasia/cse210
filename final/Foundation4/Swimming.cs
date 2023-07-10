using System;

namespace ExerciseTracker
{
    public class Swimming : Activity
    {
        private int _laps;

        public Swimming(int laps, string date, int time) :base(date, time)
        {
            _laps = laps;
            _activityName = "Swimming";
        }

        public override double GetDistance()
        {
           return (_laps * 0.05);
        }

        public override double GetSpeed()
        {
           return ((GetDistance() / _activityDuration) * 60);
        }

        public override double GetPace()
        {
           return (_activityDuration/ GetDistance());
        }
    }
}