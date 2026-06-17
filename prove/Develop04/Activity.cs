namespace Develop04;

public class Activity(string activityName, string description)
{
    private string _activtyName = activityName;
    private string _description = description;
    private int _duration;

    public string GetActivityName()
    {
        return $"Welcome to the {_activtyName}";
    }
}