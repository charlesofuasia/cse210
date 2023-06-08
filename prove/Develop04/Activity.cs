using System;

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
        Console.WriteLine("Choose the length of time in seconds for this activity: ");
        string duration = Console.ReadLine();
        _activityDuration = int.Parse(duration);
        return _activityDuration;
    }
    public void ActivatePause(int period)
    {
       Console.CursorVisible = false;
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
            Thread.Sleep(200);
            Console.Write("\b \b");

            i++;
            if(i >= pauseIcons.Count)
            {
                i = 0;
            }

       }
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
        Console.Clear();
        Console.WriteLine(_activityEndMessage);
        Console.Write("Your Feedback: ");
        Console.ReadLine();
    }


}