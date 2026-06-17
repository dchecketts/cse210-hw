using System;
using ShapeApp;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello ShapeApp World!");
        
        Console.WriteLine("\n \nTesting Classes and Methods:");
        Shape myShape = new Shape("Green");
        Console.WriteLine($"My Shape is {myShape.GetColor()}.");
        myShape.SetColor("Red");
        Console.WriteLine($"My Shape is {myShape.GetColor()}.");
        
        Console.WriteLine("\n");

        SquareShape mySquare = new SquareShape(2, "Blue");
        Console.WriteLine($"My Square is {mySquare.GetColor()}, and it has an area of {mySquare.GetArea()}.");

        RectangleShape myRectangle = new RectangleShape(2,3,"Yellow");
        Console.WriteLine($"My Rectangle is {myRectangle.GetColor()}, and it has an area of {myRectangle.GetArea()}.");
        
        CircleShape myCircle = new CircleShape(2,"Purple");
        Console.WriteLine($"My Circle is {myCircle.GetColor()}, and it has an area of {myCircle.GetArea()}.");

        Console.WriteLine("\n \nList of Shapes:");
        List<Shape> shapes = [
            new SquareShape(2,"Blue"),
            new RectangleShape(2,3,"Yellow"),
            new CircleShape(2,"Purple")
        ];

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"My shape is {shape.GetColor()}, and has an area of {shape.GetArea()}.");
        }
        
        Console.WriteLine("\n \nTesting Abstract Shapes:");

        AbstractSquare myAbstractSquare = new AbstractSquare(2, "Blue");
        Console.WriteLine($"My Square is {myAbstractSquare.GetColor()}, and it has an area of {myAbstractSquare.GetArea()}.");
        AbstractRectangle myAbstractRectangle = new AbstractRectangle(2, 6, "Yellow");
        Console.WriteLine($"My Rectangle is {myAbstractRectangle.GetColor()}, and it has an area of {myAbstractRectangle.GetArea()}.");
        AbstractCircle myAbstractCircle = new AbstractCircle(2, "Purple");
        Console.WriteLine($"My Circle is {myAbstractCircle.GetColor()}, and it has an area of {myAbstractCircle.GetArea()}.");

        
        Console.WriteLine("\n \nList of Abstract Shapes:");
        List<AbstractShape> shapesAbstract =
        [
            new AbstractSquare(2, "Blue"),
            new AbstractRectangle(2, 6, "Yellow"),
            new AbstractCircle(2,"Purple")
        ];

        foreach (AbstractShape shape in shapesAbstract)
        {
            Console.WriteLine($"My shape is {shape.GetColor()}, and has an area of {shape.GetArea()}.");
        }
    }
}