using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string userAnswer = Console.ReadLine();
        int percentAnswer = int.Parse(userAnswer);

        string gradeLetter = "";

        if (percentAnswer >= 90)
        {
            gradeLetter = "A";
        }
        else if (percentAnswer >= 80)
        {
            gradeLetter = "B";
        }
        else if (percentAnswer >= 70)
        {
            gradeLetter = "C";
        }
        else if (percentAnswer >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }

        Console.WriteLine($"Your grade is: {gradeLetter}");
        
        if (percentAnswer >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("That's rough buddy.");
        }
    }
}