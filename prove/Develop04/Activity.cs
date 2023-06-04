using System;
using System.IO;

public class Activity
{
    protected string _activityName;
    protected string _activityDescription;
    protected string _activityEndMessage;
    protected int _activityDuration;
    protected string _activityUserFeedback;

    public Activity(string type, string description, int time, string message )
    {
        _activityName = type;
        _activityDescription = description;
        _activityEndMessage = message;
        _activityDuration = time;
    }

    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to {_activityName} activity");
    }


}