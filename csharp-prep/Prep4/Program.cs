// Using Lists in C#

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> listOfNumbers = new List<int>();
        int userNumber;
        

        do
        {
            Console.WriteLine("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());
            listOfNumbers.Add(userNumber);

        } while (userNumber != 0);
        
        Console.WriteLine("The sum is: " + listOfNumbers.Sum());
        Console.WriteLine("The average is: " + listOfNumbers.Average());
        Console.WriteLine("The largest number is: " + listOfNumbers.Max());
    }
}