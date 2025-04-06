namespace Shapes;

public class Rectangle(string color, double length, double width) : Shape(color)
{
    public double Length { get; } = length;
    public double Width { get; } = width;

    #region Overrides of Shape
    
    public override double GetArea()
        => Length * Width;
    
    #endregion
}

    
