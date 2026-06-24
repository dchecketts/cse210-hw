namespace Develop05;

public class SimpleGoal(string name, string description, int points, bool isComplete = false) : Goal(name, description, points)
{
    private bool _isComplete = isComplete;

    public override int RecordEvent()
    {
        if (_isComplete)
        {
            return 0;
        }
        else
        {
            _isComplete = true;
            return Points;
        }

    }

    protected override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetFullGoalDetails()
    {
        // Simple Goal: Goal Name, Goal Description, Points, Completed
        return $"SimpleGoal:{GoalName},{Description},{Points},{_isComplete}";
    }
}