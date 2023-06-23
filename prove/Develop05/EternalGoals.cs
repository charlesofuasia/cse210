using System;

public class EternalGoals : Goal
{
    public EternalGoals(string name, string description, int points, bool complete) : base(name, description, points, complete)
    {
        _goalType = "Eternal Goal";
    }

    public override int RecordEvent()
    {
        _goalCompletion = false;
        Console.WriteLine($"You have just earned {_goalPoints}");
        return _goalPoints;
    }

    public override string FormatDisplay()
    {
        return $"{_goalName}  ({_goalDescription}) -{_goalPoints} points";
    }

    public override string FormatSave()
    {
        return $"{_goalType}|{_goalName}|{_goalDescription}|{_goalPoints}|{_goalCompletion}";
    }



}