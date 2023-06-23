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

    public string GetDescription()
    {
        return _goalDescription;
    }

    public int GetPoints()
    {
        return _goalPoints;
    }

    public bool GoalIsComplete()
    {
        return _goalCompletion;
    }

    //public abstract void CreateNewGoal();
    //public abstract string DisplayGoal();
    public abstract int RecordEvent();
    public abstract string FormatDisplay();
    public abstract string FormatSave();
   
}