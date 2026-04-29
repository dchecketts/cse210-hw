// Using Loops in C#

using System;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int magicNumber = rand.Next(1, 101);
        int guessNumber;
        
        
        do
        {
            Console.WriteLine("Guess a number: ");
            string userGuess = Console.ReadLine();
            guessNumber = int.Parse(userGuess);
        
            if (guessNumber > magicNumber)
            {
                Console.WriteLine("Too high!");
            }
        
            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("Too low!");
            }
            else if (guessNumber == magicNumber)
            {
                Console.WriteLine("That's it!");
            }
        } while (guessNumber != magicNumber);
    }
}