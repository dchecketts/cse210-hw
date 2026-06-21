namespace Develop04;

public class Activity(string activityName, string activityDescription)
{
    protected string _activtyName = activityName;
    protected string _activityDescription = activityDescription;
    protected int _activityDuration;

    public void DisplayDescription()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activtyName}. \n");
        Console.WriteLine($"{_activityDescription} \nHow many seconds would you like for this session? ");
        _activityDuration = int.Parse(Console.ReadLine() ?? string.Empty);

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    public void DisplayEndMessage()
    {
        Console.Clear();
        Console.WriteLine($"You have completed {_activityDuration} seconds of the {_activtyName}.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        List<char> characters = new List<char> { '|', '/', '-', '\\' };
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int characterStep = 0;

        while (DateTime.Now < endTime)
        {
            char currentCharacter = characters[characterStep];
            Console.Write(currentCharacter);
            Thread.Sleep(250);
            Console.Write("\b");
            characterStep++;

            if (characterStep >= characters.Count)
            {
                characterStep = 0;
            }
        }
    }

    public void ShowCountdown(int seconds)
    {
        for (int duration = seconds; duration > 0; duration--)
        {
            Console.Write(duration);
            Thread.Sleep(1000);
            Console.Write("\b");
        }
    }
}