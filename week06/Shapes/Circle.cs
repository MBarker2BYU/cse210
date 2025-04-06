namespace Shapes;

public class Circle(string color, double radius) : Shape(color)
{
    public double Radius { get; } = radius;

    #region Overrides of Shape

    public override double GetArea()
        => Math.PI * Radius * Radius;
    
    #endregion
}