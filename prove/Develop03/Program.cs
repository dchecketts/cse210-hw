using System;
using Develop03;

class Program
{
    static void Main(string[] args)
    {
        // Example Scripture used is Genesis 1:1-2.
        Scripture myScripture = new Scripture("Genesis", 1, 1, 2,
            "1 In the beginning God created the heaven and the earth. 2 And the earth was without form, and void; and darkness was upon the face of the deep. And the Spirit of God moved upon the face of the waters.");

        while (true)
        {
            Console.Clear();
            myScripture.DisplayVerse();

            if (myScripture.AreAllWordsHidden())
            {
                break;
            }
            Console.WriteLine("Press the Enter Key to hide words or type \"Quit\" to exit...");
            string input = Console.ReadLine();

            if (input != null && input.Trim().ToLower() == "quit")
            {
                break;
            }
            
            myScripture.ProcessVerse();
        }
    }
}