using System;

public abstract class Goal
{
    protected string _goalName;
    protected int _goalPoints;
    protected bool _goalCompletion;
    protected string _goalDescription;
    protected string _goalType;


    public Goal(string name, string description, int points, bool complete)
    {
        _goalName = name;
        _goalDescription = description;
        _goalPoints = points;
        _goalCompletion = complete;
    }

    public string GetGoalName()
    {
        return _goalName;
    }


    public bool GoalIsComplete()
    {
        return _goalCompletion;
    }

    protected void PlayAnimation()
    {
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(2);
        while (DateTime.Now < end)
        {
            Console.CursorVisible = false;
            Console.Clear();
            Console.WriteLine("*               *              *              *              *        *");
        Console.WriteLine("\n       *          *              *            *             *                *");
            Console.WriteLine("\n*               *               *            *           *           *");
        Console.WriteLine("\n*          *              *                  *                  *");
            Thread.Sleep(250);
            Console.Clear();
            Thread.Sleep(250);
        }
    }

    public abstract int RecordEvent();
    public abstract string FormatDisplay();
    public abstract string FormatSave();

}