using System;
using System.IO;
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points, bool complete) :base(name, description, points, complete)
    {

    }

    public override int RecordEvent()
    { 
        _goalCompletion = true;
        return _goalPoints;
    }
    public override void SaveGoal()
    {
    }
}