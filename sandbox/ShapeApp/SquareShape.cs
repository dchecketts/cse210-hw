namespace ShapeApp;

public class SquareShape(double side, string color) : Shape(color)
{
    private double _side = side;

    public override double GetArea()
    {
        return _side * _side;
    }
    
}