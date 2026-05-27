namespace CircleApp;

public class Angle
{
    private double _radians;

    public Angle()
    {
        _radians = 0;
    }

    public Angle(double radians)
    {
        _radians = radians;
    }

    public Angle(int degrees)
    {
        _radians = ToRadians(degrees);
    }

    public double GetRadians()
    {
        return _radians;
    }

    public void SetRadians(double radians)
    {
        if (radians < 0)
        {
            Console.WriteLine("Invalid radian");
            _radians = 0;
        }
        else
        {
            _radians = radians;
        }
    }

    public double ToRadians(int degrees)
    {
        return _radians * degrees / 180 * Math.PI;
    }
}