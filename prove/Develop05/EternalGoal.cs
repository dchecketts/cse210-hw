namespace Develop05;

public class EternalGoal(string name, string description, int points) : Goal(name, description, points)
{
    public override int RecordEvent()
    {
        return Points;
    }

    protected override bool IsComplete()
    {
        return false;
    }

    public override string GetFullGoalDetails()
    {
        // Eternal Goal: Goal Name, Goal Description, Points
        return $"EternalGoal:{GoalName},{Description},{Points}";
    }
}