using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Clear();

        var valueList = new List<int[]> { new int[0], new int[] { 5 }, new int[] { 3, 4 }, new int[] { 1, 3 } };

        foreach (var values in valueList)
        {
         switch(values.Length)
         {
            case 0:
                var fraction = new Fraction();
                Console.WriteLine($"Fraction value: {fraction.GetFractionString()}");
                Console.WriteLine($"Decimal value: {fraction.GetDecimalValue()}");
                break;
            case 1:
                var fraction1 = new Fraction(values[0]);
                Console.WriteLine($"Fraction value: {fraction1.GetFractionString()}");
                Console.WriteLine($"Decimal value: {fraction1.GetDecimalValue()}");
                break;
            case 2:
                var fraction2 = new Fraction(values[0], values[1]);
                Console.WriteLine($"Fraction value: {fraction2.GetFractionString()}");
                Console.WriteLine($"Decimal value: {fraction2.GetDecimalValue()}");
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
         }
        }

    }
}