using System;
namespace Learning03;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction fraction = new Fraction();
        int iteration = 0;

        do
        {
            Random random = new Random();
            int numerator = random.Next(1, 10);
            int denominator = random.Next(1, 10);
            fraction.SetTop(numerator);
            fraction.SetBottom(denominator);
            Console.WriteLine($"Fraction #{iteration + 1}: {fraction.GetFractionString()} | Decimal: {fraction.GetDecimalValue()}");
            iteration += 1;
        } while (iteration < 20);
    }
}