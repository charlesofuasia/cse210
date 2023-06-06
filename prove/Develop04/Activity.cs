using System;
using System.IO;
using System.Threading;
using System.Timers;

public class Activity
{
    protected string _activityName;
    protected string _activityDescription;
    protected string _activityEndMessage;
    protected string _activityInstruction;
    protected int _activityDuration;
    protected string _activityUserFeedback;

    public Activity(string type, string description, int time, string message, string instruction )
    {
        _activityName = type;
        _activityDescription = description;
        _activityEndMessage = message;
        _activityDuration = time;
        _activityInstruction = instruction;
    }

    public void DisplayStartMessage(string type)
    {
        Console.Write($"Welcome to {_activityName} activity: {_activityDescription} ");
       
    }
    public void ActivatePause()
    {
       List<string> pauseIcons = new List<string>();
       pauseIcons.Add("$");
       pauseIcons.Add("£");
       pauseIcons.Add("$");
       pauseIcons.Add("£");
       pauseIcons.Add("$");
       pauseIcons.Add("£");
       pauseIcons.Add("$");
       pauseIcons.Add("£");

       for(int i = 0; i < pauseIcons.Count(); i++)
       {
        Console.Write(pauseIcons[i]);
        Thread.Sleep(1000);
        Console.Write("\b \b");

       }

    }

    public void ActivateActivityTimer(int timer)
    {
        for(int i = timer; i >= 0; i--)
        {
          Console.Write(i);
          Thread.Sleep(1000);
          Console.Write("\b \b");
         
        }
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine($"Congratulations! You have completed the {_activityName} exercise. What was your experience after completing this exercise? ");
        Console.Write("Your Feedback: ");
        Console.ReadLine();
    }


}