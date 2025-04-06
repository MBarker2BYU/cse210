namespace Shapes;

public abstract class Shape(string color)
{
    public string Color { get; } = color;

    public virtual double GetArea()
        => default;
}