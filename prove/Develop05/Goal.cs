namespace Develop05;

public abstract class Goal(string name, string description, int points)
{ 
    protected readonly string GoalName = name; 
    protected readonly string Description = description; 
    protected readonly int Points = points;

    public string GetGoalName()
    {
        return GoalName;
    }

    public abstract int RecordEvent(); 
    protected abstract bool IsComplete(); 

    public virtual string GetGoalDetails() 
    { 
        return $"[{(IsComplete() ? "X" : " ")}] {GoalName} ({Description})"; 
    } 

    public abstract string GetFullGoalDetails();
}