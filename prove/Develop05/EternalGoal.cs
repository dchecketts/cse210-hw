namespace Develop05;

public class EternalGoal(string goalName, string goalDescription, int goalPoints) : Goal(goalName, goalDescription, goalPoints)
{
    public override int RecordEvent()
    {
        return GoalPoints;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetFullGoalDetails()
    {
        // Eternal Goal: Goal Name, Goal Description, Points
        return $"EternalGoal:{GoalName},{GoalDescription},{GoalPoints}";
    }
}