namespace ShapeApp;

public class AbstractCircle(double radius, string color) : AbstractShape(color)
{
    private double _radius = radius;
    
    public override double GetArea()
    {
        return Math.Round(Math.PI * Math.Pow(_radius, 2), 2);
    }
}