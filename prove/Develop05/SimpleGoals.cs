using System;

public class SimpleGoal : Goal
{
    public SimpleGoal()
    {

    }

    public override void CreateNewGoal()
    {
        base.GetGoalName();
        base.GetDescription();
        base.GivePoints();
    }

    public override int RecordEvent()
    { 
        _goalCompletion = true;
        return _goalPoints;
    }

    public override string DisplayGoal()
    {
        if(_goalCompletion)
        {
            return $"[  ] : {_goalName}~{_goalDescription}~{_goalPoints}~{_goalCompletion}";
        }
        else
        {
            return $"[ \u2714 ] : {_goalName}~{_goalDescription}~{_goalPoints}~{_goalCompletion}";
        }
    }
}