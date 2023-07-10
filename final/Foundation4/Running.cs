using System;

namespace ExerciseTracker
{
    public class Running : Activity
    {
        private float _distance;

        public Running(float distance, string date, int time) : base(date, time)
        {
            _distance = distance;
            _activityName = "Running";
        }

        public override double GetDistance()
        {
            return _distance;
        }

        public override double GetSpeed()
        {
            return ((_distance / _activityDuration) * 60);
        }

        public override double GetPace()
        {
           return (_activityDuration / _distance);
        }
    }
}