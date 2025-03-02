//Author: Matthew D. Barker
//Course: CSE 210 : Programming with classes
//Assignment: C# Programming Exercise 4: Lists and Generics

using System.Text;

public class NumbersList
{
    private List<decimal> m_Numbers = new();

    private void Clear()
        => Console.Clear();

    private void WriteLine(string value = "")
        => Console.WriteLine(value);

    private string ListToString(List<decimal> list)
    {
        var stringBuilder = new StringBuilder();

        foreach(var value in list)
        {
            if(stringBuilder.Length > 0)
                stringBuilder.Append(", ");

            stringBuilder.Append($"{value}");
        }

        return $"[{stringBuilder}]";
    }

    private string ReadLine()
        => Console.ReadLine();

    private void PressEnterToContinue()
    {
        WriteLine("Please press enter...");
        ReadLine();
    }

    private string PromptUser(string prompt)
        {
            WriteLine(prompt);
            return ReadLine();
        }

    private void AddLines(int lineCount = 1)
        {
            for (var index = 0; index < lineCount; index++)
            {
                Console.WriteLine();
            }
        }

    private decimal PropmptUserForDecimal(string prompt = "", decimal minimum = 0, decimal maximum = 100)
    {
        prompt = prompt == string.Empty ? $"Please enter a value between'{minimum}' and '{maximum}'." : prompt;

        if (maximum <= minimum)
            throw new ArgumentException($"Maximum must be greater than minimum. Minimum: {minimum} and Maximum: {maximum} provided.");

        while (true)
        {
            Clear();
            var userInput = PromptUser(prompt);

            if (decimal.TryParse(userInput, out var value))
            {
                if (value >= minimum && value <= maximum)
                    return value;
            }

            WriteLine($"'{userInput}' is an invalid value.");
            PressEnterToContinue();

        }
    }

    private bool GetSmallestPositiveNumber(List<decimal> list, out decimal smallestNumber)
    {
        smallestNumber = decimal.MaxValue;
        var updated = false;

        foreach(var value in list)
        {
            if (value <= smallestNumber && value > 0)
            {
                smallestNumber = value;
                updated = true;
            }
        }

        return updated;
    }

    private bool GetLargestNegativeNumber(List<decimal> list, out decimal largestNumber)
    {
        largestNumber = decimal.MinValue;
        var updated = false;

        foreach(var value in list)
        {
            if(value >= largestNumber && value < 0)
            {    
                largestNumber = value;
                updated = true;
            }
        }

        return updated;
    }

    private void PrintSummary()
    {
        
        var sum = m_Numbers.Sum();

        m_Numbers.Sort();
        
        Clear();
        WriteLine("List analysis reveals the following:");
        AddLines();
        WriteLine($" - There are {m_Numbers.Count} numbers in the list.");
        WriteLine($" - List Sum: {sum:#,##0.00}.");
        WriteLine($" - List Average: {sum / m_Numbers.Count:#,##0.00}");
        WriteLine($" - Largest Number: {m_Numbers[m_Numbers.Count - 1]:#,##0.00}");
        WriteLine($" - Smallest Number: {m_Numbers[0]:#,##0.00}");

        if(GetSmallestPositiveNumber(m_Numbers, out var smallestNumber))
            WriteLine($" - Smallest Positive Number: {smallestNumber:#,##0.00}");
        
        if(GetLargestNegativeNumber(m_Numbers, out var largestNumber))
            WriteLine($" - Lagest Negitive Number: {largestNumber:#,##0.00}");
        
        WriteLine($" - Accending Sort: {ListToString(m_Numbers)}");

        m_Numbers.Reverse();

        WriteLine($" - Decending Sort: {ListToString(m_Numbers)}");

        AddLines(2);

    }

    public void Run()
    {
        Clear();
        WriteLine($"Enter a list of numbers. Enter 0 when finished.");
        PressEnterToContinue();

        while(true)
        {
            var userInput = PropmptUserForDecimal("Enter number:", decimal.MinValue, decimal.MaxValue);

            if(userInput == 0)
                break;

            m_Numbers.Add(userInput);
        }

        PrintSummary();
    }
}

class Program
{
    static void Main(string[] args)
    {
        new NumbersList().Run();
    }
}