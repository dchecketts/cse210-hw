namespace Develop03;

public class Reference
{
    private string _reference;

    public void SetReference(string reference)
    {
        _reference = reference;
    }
    
    public void DisplayReference()
    {
        Console.WriteLine(_reference);
    }
}