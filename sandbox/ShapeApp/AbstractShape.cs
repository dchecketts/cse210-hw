namespace ShapeApp;

public abstract class AbstractShape(string color)
{
    private string _color = color;

    public string GetColor()
    {
        return _color;
    }

    void SetColor(string color)
    {
        _color = color;
    }

    public abstract double GetArea();
}