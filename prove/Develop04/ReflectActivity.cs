namespace Develop04;

public class ReflectActivity(string activityName, string activityDescription) : Activity(activityName, activityDescription)
{
    private List<string> _prompts =
        [
            "Think of a time where you stood up for someone else.",
            "Think of a time when you did something really difficult for you.",
            "Think of a time when you helped someone who needed it.",
            "Think of a time when you did something truly selfless."
        ];

    private List<string> _questions =
        [
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when you finished it?",
            "What made this time different from other times where you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that could be applied to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        ];

    public override void Run()
    {
        DisplayDescription();
        
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        
        Console.Clear();
        Console.WriteLine($"Consider the following: \n{prompt} \n \nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        
        Console.Clear();
        Console.WriteLine("Now, ponder each of the following questions about that experience. \nYou may begin in:");
        ShowCountdown(5);

        Console.Clear();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_activityDuration);

        List<string> remainingQuestions = new List<string>(_questions);

        while (DateTime.Now < endTime)
        {
            if (remainingQuestions.Count == 0) remainingQuestions = new List<string>(_questions);
            
            int index = random.Next(remainingQuestions.Count);
            string question = remainingQuestions[index];
            remainingQuestions.RemoveAt(index);
            
            Console.Clear();
            Console.WriteLine($"> {question}");
            ShowSpinner(8);
        }
        
        DisplayEndMessage();
    }
}