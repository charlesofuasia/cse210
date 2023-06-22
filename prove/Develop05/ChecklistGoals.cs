using System;

public class ChecklistGoals : Goal
{
    private int _targetReps;
    private int _currentReps;
    private int _bonusPoints;

    public ChecklistGoals(int target, int current, int bonus, string name, string description, int points, bool complete) :base(name, description, points, complete)
    {
        _targetReps = target;
        _currentReps = current;
        _bonusPoints = bonus;
    }

    public int GetTarget()
    {
        return _targetReps;
    }

    public int GetBonus()
    {
        return _bonusPoints;
    }
    public int GetCurrent()
    {
        return _currentReps;
    }

    public override int RecordEvent()
    {
        if(_currentReps < _targetReps)
        {
            _goalCompletion = false;
            return _goalPoints;
        }
        else
        {
            _goalCompletion = true;
            return _bonusPoints + _goalPoints;
        }
    }

    
    public override string FormatDisplay()
    {
        return $"{_goalName} - {_goalDescription} - {_goalPoints} Done {_currentReps} Out of {_targetReps}";
    }
}
