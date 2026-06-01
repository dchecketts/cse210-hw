namespace Learning04;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studnetName, string topic, string textbookSection, string problems) : base(studnetName,
        topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"{_textbookSection} {_problems}";
    }
}