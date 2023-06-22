using System;

public class EternalGoals : Goal
{
    public EternalGoals(string name, string description, int points, bool complete) :base(name, description, points, complete)
    {

    }

    public override int RecordEvent()
    {
        _goalCompletion = false;
        return _goalPoints;
    }
}