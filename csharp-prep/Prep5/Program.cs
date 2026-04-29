// Using functions in C#

using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static void PromptUserBirthYear(out int birthYear)
    {
        Console.WriteLine("Please enter your birth year: ");
        birthYear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResults(string userName, int squaredNumber, int birthYear)
    {
        int currentYear = DateTime.Now.Year;
        int ageThisYear = currentYear - birthYear;
        
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}. \n {userName}, you will be {ageThisYear} years old this year.");
    }
    
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        PromptUserBirthYear(out int userBirthYear);
        int squaredNumber = SquareNumber(userNumber);
        
        DisplayResults(userName, squaredNumber, userBirthYear);

    }
}




