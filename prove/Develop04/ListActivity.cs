namespace Develop04;

public class ListActivity(string activityName, string activityDescription) : Activity(activityName, activityDescription)
{
    private List<string> _prompts = 
        [
            "Who are people that you appreciate?",
            "What personal strengths do you have?",
            "Who are people you hve helped this week?",
            "When have you felt the Spirit this week?",
            "Who are some of your personal heroes?"
        ];

    public override void Run()
    {
        DisplayDescription();
        
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        
        Console.WriteLine($"List as many responses as you can to the following: \n{prompt} \nYou may begin in: ");
        ShowCountdown(5);
        Console.Clear();
        Console.WriteLine($"> {prompt}");
        
        List<string> userItems = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_activityDuration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                userItems.Add(input);
            }
        }
        
        Console.WriteLine($"you listed {userItems.Count} items.");
        DisplayEndMessage();
    }
}