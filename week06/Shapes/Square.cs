namespace Shapes;

public class Square(string color, double side) : Shape(color)
{
    public double Side { get; } = side;

    #region Overrides of Shape

    public override double GetArea()
        => Side * Side;

    #endregion
}