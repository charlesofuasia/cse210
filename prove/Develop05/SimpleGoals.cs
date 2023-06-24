using System;
using System.IO;
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points, bool complete) :base(name, description, points, complete)
    {
        _goalType = "Simple Goal";
    }

    public override int RecordEvent()
    { 
        _goalCompletion = true;
        PlayAnimation();
        Console.WriteLine($"Congratulation for completing your goal! You just earned {_goalPoints} points");
        return _goalPoints;
    }

    public override string FormatDisplay()
    {
        return $"{_goalName} ( {_goalDescription} ) - Points value = {_goalPoints}";
    }

    public override string FormatSave()
    {
        return $"{_goalType}|{_goalName}|{_goalDescription}|{_goalPoints}|{_goalCompletion}";
    }
}