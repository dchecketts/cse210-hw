namespace Develop05;

public abstract class Goal(string name, string goalDescription, int goalPoints)
{ 
    protected string GoalName = name; 
    protected string GoalDescription = goalDescription; 
    protected int GoalPoints = goalPoints;

    public string GetGoalName()
    {
        return GoalName;
    }

    public abstract int RecordEvent(); 
    public abstract bool IsComplete(); 

    public virtual string GetGoalDetails() 
    { 
        return $"[{(IsComplete() ? "X" : " ")}] {GoalName} ({GoalDescription})"; 
    } 

    public abstract string GetFullGoalDetails();
}