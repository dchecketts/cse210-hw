namespace Develop03;

public class Word
{
    private string _word;
    private bool _hidden;
    
    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

    public string GetWord()
    {
        string tempWord = _word;

        if (_hidden)
        {
            foreach (char c in _word)
            {
                // This if statement will only hide characters if they are not punctuation or numbers, to improve readability and assist with memorization.
                if (char.IsLetter(c))
                {
                    tempWord = tempWord.Replace(c, '_');
                }
            }
        }
        return tempWord;
    }

    public bool IsHidden()
    {
        return _hidden;
    }
    public void Hide()
    {
        _hidden = true;
    }

    public void DisplayWord()
    {
        Console.Write($"{GetWord()} ");
    }
    
}