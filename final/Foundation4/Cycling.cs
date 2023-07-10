using System;

namespace ExerciseTracker
{
    public class Cycling : Activity
    {
        private float _speed;

        public Cycling(float speed, string date, int time) : base(date, time)
        {
            _speed = speed;
            _activityName = "Cycling";
        }

        public override double GetSpeed()
        {
            return _speed;
        }

        public override double GetDistance()
        {
            return ((_speed * _activityDuration) / 60);
        }

        public override double GetPace()
        {
            return (_activityDuration / GetDistance());
        }
    }
}