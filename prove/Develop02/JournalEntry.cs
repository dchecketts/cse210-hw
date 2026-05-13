namespace Develop02;

public class JournalEntry
{
    private string _date;
    private string _prompt;
    private string _response;

    // TODO: Add more prompts
    private string[] _prompts =
    {
        "How are you feeling today?",
        "Who did you talk with today?"
    };

    public void CreateJournalEntry()
    {
        _date = DateTime.Now.ToShortDateString();
        
        // TODO: Use random to select a prompt string
        _prompt = _prompts[0];
        Console.WriteLine(_prompt);
        _response = Console.ReadLine();
    }

    public void DisplayJournalEntry()
    {
        Console.WriteLine($"{_date}, {_prompt} - {_response}");
    }

    public string CreateFileSystemString()
    {
        return $"{_date},{_prompt},{_response}";
    }
}