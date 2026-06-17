namespace ShapeApp;

public class CircleShape(double radius, string color) : Shape(color)
{
    private double _radius = radius;
    
    public override double GetArea()
    {
        return Math.Round(Math.PI * Math.Pow(_radius, 2), 2);
    }
}