namespace Shapes;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        var shapes = new List<Shape>
        {
            new Square("Blue", 7.5),
            new Circle("Red", 3.5),
            new Rectangle("Green", 4.0, 5.0)
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.Color}");
            Console.WriteLine($"Shape Area: {shape.GetArea():##,###.00} Sq Units");
        }

    }
}