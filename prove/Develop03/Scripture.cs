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

    private void ConvertToList(string reference)
    {
        _words = reference.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void ProcessVerse()
    {
        Random random = Random.Shared;

        int unhiddenWords = _words.Count(w => !w.IsHidden());
        
        // To change the minimum words to hide, change the variable immediately below.
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

    public bool AreAllWordsHidden()
    {
        return _words.All(w => w.IsHidden());
    }

    public void DisplayVerse()
    {
        Console.WriteLine(_reference.DisplayReference());
        foreach (Word w in _words)
        {
            w.DisplayWord();
        }
        Console.WriteLine();
    }
}