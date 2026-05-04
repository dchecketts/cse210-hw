// using System;

// class Program
class Sandbox
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Sandbox World!");
        // int x = 10;
        //
        // if (x == 11) 
        // {
        //     Console.WriteLine("x is 11");
        // }
        //
        // int age = -1;
        // while (age < 0 || age > 125)
        // {
        //     Console.WriteLine("Please enter your age: ");
        //     age = int.Parse(Console.ReadLine());
        // }
        //
        // int age2;
        // do
        // {
        //     Console.WriteLine("Please enter your age: ");
        //     age2 = int.Parse(Console.ReadLine());
        // } while (age2 < 0 || age2 > 125);
        
        Console.Write("Enter your height in inches: ");
        string userHeight = Console.ReadLine();

        int height = int.Parse(userHeight);

        if (height < 48)
        {
            Console.Write("Sorry, you are too short.");
        }
        else if (height > 78)
        {
            Console.Write("Sorry, you are too tall.");
        }
        else if (height > 48 && height < 78)
        {
            Console.Write("Enjoy your ride!");
        }
    }
}