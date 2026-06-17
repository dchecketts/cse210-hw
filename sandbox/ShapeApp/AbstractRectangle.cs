namespace ShapeApp;

public class AbstractRectangle(double length, double width, string color) : AbstractShape(color)
{
    private double _length = length;
    private double _width = width;

    public override double GetArea()
    {
        return _length * _width;
    }
}