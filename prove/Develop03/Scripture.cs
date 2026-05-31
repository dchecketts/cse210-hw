namespace Develop03;

public class Scripture
{
    private List<Word> _words;
    private Reference _reference;

    public Scripture(string book, int chapter, int startVerse, string reference)
    {
        _reference = new Reference(book, chapter, startVerse);
        ConvertToList(reference);
    }
    
    public Scripture(string book, int chapter, int startVerse, int endVerse, string reference)
    {
        _reference = new Reference(book, chapter, startVerse, endVerse);
        ConvertToList(reference);
    }

    private List<Word> ConvertToList(string reference)
    {
        return _words = reference.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void ProcessVerse()
    {
        Random random = Random.Shared;

        int unhiddenWords = _words.Count(w => !w.IsHidden());
        int wordsToHide = Math.Min(3, unhiddenWords);
        int hiddenWords = 0;

        while (hiddenWords < wordsToHide)
        {
            int index = random.Next(_words.Count);
            Word selectedWord = _words[index];

            if (!selectedWord.IsHidden())
            {
                selectedWord.Hide();
                hiddenWords++;
            }
        }
    }

    public void DisplayVerse()
    {
        foreach (Word w in _words)
        {
            w.DisplayWord();
        }
        Console.WriteLine();
    }
}