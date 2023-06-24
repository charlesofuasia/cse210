using System;

public class ChecklistGoals : Goal
{
    private int _targetReps;
    private int _currentReps;
    private int _bonusPoints;

    public ChecklistGoals(int target, int current, int bonus, string name, string description, int points, bool complete) : base(name, description, points, complete)
    {
        _targetReps = target;
        _currentReps = current;
        _bonusPoints = bonus;
        _goalType = "Checklist Goal";
    }


    public override int RecordEvent()
    {
        _currentReps++;
        if (_currentReps < _targetReps)
        {
            _goalCompletion = false;
            Console.WriteLine($"You have earned {_goalPoints} points. Keep going.");
            return _goalPoints;
        }
        else
        {
            _goalCompletion = true;
            PlayAnimation();
            Console.WriteLine($"Congratulations! You have completed {_goalName} goal and earned extra{_bonusPoints} points");
            return _bonusPoints + _goalPoints;
        }
    }


    public override string FormatDisplay()
    {
        return $"{_goalName} - {_goalDescription} - {_goalPoints} Done {_currentReps} Out of {_targetReps}";
    }

    public override string FormatSave()
    {
        return $"{_goalType}|{_goalName}|{_goalDescription}|{_goalPoints}|{_goalCompletion}|{_targetReps}|{_currentReps}|{_bonusPoints}";
    }
}
