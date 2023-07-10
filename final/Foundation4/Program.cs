using System;

namespace ExerciseTracker
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            List<Activity> activities = new List<Activity>();

            Running running = new Running(1.25f, "10th July, 2023", 45);
            activities.Add(running);

            Cycling cycling = new Cycling(20.15f, "10th July, 2023", 55);
            activities.Add(cycling);

            Swimming swimming = new Swimming(8, "10th July, 2023", 30);
            activities.Add(swimming);


            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}