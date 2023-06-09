using System;

public class Activity
{
    protected string _activityName;
    protected string _activityDescription;
    protected string _activityInstruction;
    protected int _activityDuration;
    protected string _activityUserFeedback;

   public Activity()
   {

   }
    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to {_activityName} activity: {_activityDescription} ");
       
    }

    protected int GetDuration()
    {
        Console.CursorVisible = true;
        Console.WriteLine("Choose the length of time in seconds for this activity: ");
        string duration = Console.ReadLine();
        _activityDuration = int.Parse(duration);
        return _activityDuration;
    }
    protected void ActivatePause(int period)
    {
       List<string> pauseIcons = new List<string>();
       pauseIcons.Add("|");
       pauseIcons.Add("/");
       pauseIcons.Add("-");
       pauseIcons.Add("\\");
       pauseIcons.Add("|");
       pauseIcons.Add("/");
       pauseIcons.Add("-");
       pauseIcons.Add("\\");

       DateTime startTime = DateTime.Now;
       DateTime stoptime = startTime.AddSeconds(period);

       int i = 0;

       while(DateTime.Now < stoptime)
       {
       {
            Console.Write(pauseIcons[i]);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;
            if(i >= pauseIcons.Count)
            {
                i = 0;
            }

       }
       }
    }

    protected void ActivateActivityTimer(int timer)
    {
        for(int i = timer; i >= 0; i--)
        {
          Console.Write(i);
          Thread.Sleep(1000);
          Console.Write("\b \b");
         
        }
    }


    protected void DisplayEndMessage()
    {
        Console.Clear();
        Console.WriteLine($"Congratulations! You have completed {_activityDuration} seconds of {_activityName} activity. How did you feel after the exercise?");
        Console.Write("Your Feedback: ");
        Console.ReadLine();
    }

    protected void PrepareToStart()
    {
        Console.Clear();
        Thread.Sleep(1000);
        Console.Write("Begin in... ");
        ActivateActivityTimer(3);
        Console.Clear();
        Console.WriteLine("Start!");
        Thread.Sleep(1000);
        Console.Clear();
    }


}