namespace ShapeApp;

public class AbstractSquare(double side, string color) : AbstractShape(color)
{
    private double _side = side;

    public override double GetArea()
    {
        return _side * _side;
    }
}