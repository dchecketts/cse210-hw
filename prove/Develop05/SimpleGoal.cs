namespace Develop05;

public class SimpleGoal(string goalName, string goalDescription, int goalPoints, bool isComplete = false) : Goal(goalName, goalDescription, goalPoints)
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
            return goalPoints;
        }

    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetFullGoalDetails()
    {
        // Simple Goal: Goal Name, Goal Description, Points, Completed
        return $"SimpleGoal:{GoalName},{GoalDescription},{GoalPoints},{_isComplete}";
    }
}