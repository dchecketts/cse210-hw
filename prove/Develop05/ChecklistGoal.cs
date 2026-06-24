namespace Develop05;

public class ChecklistGoal(string name, string description, int repeatPoints, int bonusPoints, int maxRepetitions, int currentRepetitions = 0) : Goal(name, description, repeatPoints)
{
    private readonly int _maxRepetitions = maxRepetitions;
    private int _currentRepetitions = currentRepetitions;
    private readonly int _repeatPoints = repeatPoints;
    private readonly int _bonusPoints = bonusPoints;
    
    public override int RecordEvent()
    {
        int points = 0;

        if (!IsComplete())
        {
            _currentRepetitions++;
            points = _repeatPoints;
        }

        return points;
    }
    
    protected override bool IsComplete()
    {
        if (_currentRepetitions >= _maxRepetitions)
        {
            return true;
        }
        return false;
    }

    public override string GetGoalDetails()
    {
        return $"{base.GetGoalDetails()} -- Currently completed: {_currentRepetitions}/{_maxRepetitions}";
    }

    public override string GetFullGoalDetails()
    {
        // Checklist Goal: Goal Name, Goal Description, Repetition Points, Bonus Points, Max Repetitions, Current Repetitions
        return $"ChecklistGoal:{GoalName},{Description},{_repeatPoints},{_bonusPoints},{_maxRepetitions},{_currentRepetitions}";
    }
}