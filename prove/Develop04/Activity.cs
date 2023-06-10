using System;

public class Activity
{//Class attributes are protected and as such are accessible by subclasses of Activity only
    protected string _activityName;
    protected string _activityDescription;
    protected string _activityInstruction;
    protected int _activityDuration;

    protected void DisplayStartMessage()
    {
        /*A method to display the wellcome message to an activity and also
          the instructions for that activity.
          Parameters: none;
          returns: nothing.
        */
        Console.Clear();
        Console.WriteLine($"Welcome to {_activityName} activity: {_activityDescription} ");
        ActivatePause(4);
        Console.WriteLine();
        Console.WriteLine(_activityInstruction);
        ActivatePause(5);
       
    }

    protected int GetDuration()
    {
        /*A method that prompts the user to set the duration of an activity
        Parameters: none
        returns: int _activityDuration
        */
        Console.WriteLine("Choose the length of time in seconds for this activity: ");
        string duration = Console.ReadLine();
        _activityDuration = int.Parse(duration);
        ActivatePause(5);
        return _activityDuration;
    }
    protected void ActivatePause(int period)
    {
        /*A method that displays animation of a clockwise rotation
        Parameter: int period in seconds that is the duration of the animation
        Returns; nothing
        */
       Console.CursorVisible = false; 
       List<string> pauseIcons = new List<string>()
       {"|", "/", "-", "\\", "|", "/", "-", "\\"};
    
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
    {/*A method that simulates a countdown
       Parameter: int timer ie, lenght of countdown
       Return: none
       */
        for(int i = timer; i >= 0; i--)
        {
          Console.Write(i);
          Thread.Sleep(1000);
          Console.Write("\b \b");
         
        }
    }


    protected void DisplayEndMessage()
    {/*A method that displays the end message on the completion of an activity class 
       Parameters: none
       returns: nothing
    */
        ActivatePause(3);
        Console.WriteLine($"Congratulations! You have completed {_activityDuration} seconds of {_activityName} activity. How did you feel after the exercise?");
        Console.Write("Your Feedback: ");
        Console.ReadLine();
        ActivatePause(3);
    }

    protected void PrepareToStart()
    {/*A method that perfroms a countdown and prompts user to get ready to start
    an activity.
    Parameters: none
    returns: nothing
    */
        Console.Clear();
        Thread.Sleep(500);
        Console.Write("Begin in... ");
        ActivateActivityTimer(3);
        Console.Clear();
        Console.WriteLine("Start!");
        Thread.Sleep(500);
        Console.Clear();
    }


}