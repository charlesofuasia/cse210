using System;

public abstract class Goal
{
    protected string _goalName;
    protected int _goalPoints;
    protected bool _goalCompletion = false;
    protected string _goalDescription;
    //protected string _goalCategory;

    public Goal()
    {
       
    }

    public string GetGoalName()
    {
        Console.Write("What is the name of the goal?: ");
        _goalName = Console.ReadLine();
        return _goalName;
    }

    public string GetDescription()
    {
        Console.Write("Please describe the goal: ");
        _goalDescription = Console.ReadLine();
        return _goalDescription;
    }

    public int GivePoints()
    {
        Console.Write("What is the point for this goal?: ");
        _goalPoints = int.Parse(Console.ReadLine());
        return _goalPoints;
    }

    public bool GoalIsComplete()
    {
        return _goalCompletion;
    }

    public abstract void CreateNewGoal();
    public abstract void DisplayGoal();
    public abstract int RecordEvent();

   
   
}