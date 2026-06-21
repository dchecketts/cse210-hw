namespace Develop04;

public class BreathActivity(string activityName, string activityDescription) : Activity(activityName, activityDescription)
{
    public override void Run()
    {
        DisplayDescription();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_activityDuration);

        while (DateTime.Now < endTime)
        {
            Console.Clear();
            Console.Write("Breathe in... ");
            ShowCountdown(4);
            Console.Clear();
            Console.Write("Breathe out... ");
            ShowCountdown(6);
        }
        
        DisplayEndMessage();
    }
}