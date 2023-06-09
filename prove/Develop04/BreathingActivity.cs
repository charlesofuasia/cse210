using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
    {
        _activityName = "Breathing";
        _activityDescription = "This activity will help you to release stress by breathing deeply and intently";
        _activityInstruction = "At the prompt, keep inhaling until the countdown reaches 0 and then, using the same prompt, exhale";

    }
    public void RunBreathingActivity()
    {
        Console.Clear();
        DisplayStartMessage();
        Console.WriteLine();
       
        Console.WriteLine(_activityInstruction);
       
        ActivatePause(5); 
        _activityDuration = GetDuration();
        DateTime start = DateTime.Now;
        DateTime stop = start.AddSeconds(_activityDuration);
        Console.Write("Ready in......");
        PrepareToStart();
        
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