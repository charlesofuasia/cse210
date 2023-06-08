using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
    {
        _activityName = "Breathing Activity";
        _activityDescription = "This activity will help you to release stress by breathing deeply and intently";
        _activityEndMessage = "Congratulations! You have completed the Breathing activity exercise. What was your experience after completing this exercise? ";
        _activityInstruction = "At the prompt, keep inhaling until the countdown reaches 0 and then, using the same prompt, exhale";

    }
    public void RunBreathingActivity()
    {
        Console.Clear();
        Activity activity = new Activity();
        DisplayStartMessage();
        Console.WriteLine();
        _activityDuration = GetDuration();
        Console.WriteLine(_activityInstruction);
        DateTime start = DateTime.Now;
        DateTime stop = start.AddSeconds(_activityDuration);
        Console.Write("Ready in 5 seconds......");
        ActivateActivityTimer(5);
        Console.WriteLine();
        Console.WriteLine("Start!");
        ActivatePause(5); 
        
        while(DateTime.Now < stop)
        {   
        
        Console.Clear();
        
        Console.WriteLine();
        
        Console.Write("Breathe in ......");
        ActivateActivityTimer(9);
        Console.WriteLine();
        Console.Write("Breathe out.....");
        ActivateActivityTimer(6);
        }

        Console.WriteLine();
        Console.WriteLine("Complete");
        Console.WriteLine();
        ActivatePause(5);
        Console.WriteLine();
        DisplayEndMessage();
       
    }

}