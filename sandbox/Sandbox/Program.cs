// using System;

// class Program
class Sandbox
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        int x = 10;

        if (x == 11) 
        {
            Console.WriteLine("x is 11");
        }

        int age = -1;
        while (age < 0 || age > 125)
        {
            Console.WriteLine("Please enter your age: ");
            age = int.Parse(Console.ReadLine());
        }

        int age2;
        do
        {
            Console.WriteLine("Please enter your age: ");
            age2 = int.Parse(Console.ReadLine());
        } while (age2 < 0 || age2 > 125);
    }
}