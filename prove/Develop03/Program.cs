using System;
using Develop03;

class Program
{
    static void Main(string[] args)
    {
        Word myWord = new Word("Hello");
        Console.WriteLine(myWord.GetWord());
        
        myWord.Hide();
        Console.WriteLine(myWord.GetWord());
        
        myWord.DisplayWord();
        
        if (myWord.IsHidden())
        {
            Console.WriteLine(myWord.GetWord());
        }
    }
}