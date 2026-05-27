using System;
using CircleApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello CircleApp World!");

        Angle myAngle = new Angle();
        myAngle.SetRadians(10);
        Console.WriteLine(myAngle.GetRadians());
        
        Angle anotherAngle = new Angle(10);
        Console.WriteLine(anotherAngle.GetRadians());
    }
}