//Author: Matthew D. Barker
//Course: CSE 210 : Programming with classes
//Assignment: C# Programming Exercise 5: Functions

class Program
{
    static void Main(string[] args)
    {
        Clear();
        AddLines(2);
        
        DisplayWelcome();
        
        var userName = PromptUserName();
        var favoriteNumber = PromptUserNumber();
        var square = SquareNumber(favoriteNumber);

        DisplayResult(userName, square);
        AddLines(2);
    }

    #region Utilities

    private static void Clear()
        => Console.Clear();

    private static void WriteConsole(string value = "", bool lineReturn = true)
        {
            if(lineReturn) 
                Console.WriteLine(value); 
            else
                Console.Write(value);            
        }

    private static string PromptUser(string prompt, bool lineReturn = true)
    {
        WriteConsole(prompt, lineReturn);
        return ReadLine();
    }

    private static string ReadLine()
        => Console.ReadLine();

    private static void AddLines(int lineCount = 1)
    {
        for (var index = 0; index < lineCount; index++)
        {
            Console.WriteLine();
        }
    }

    private static void PressEnterToContinue()
    {
        Console.WriteLine("Please press enter...");
        Console.ReadLine();
    }

    private static int PropmptUserForInteger(string prompt = "", int minimum = 0, int maximum = 100)
    {
        prompt = prompt == string.Empty ? $"Please enter a value between'{minimum}' and '{maximum}'." : prompt;

        if (maximum <= minimum)
            throw new ArgumentException($"Maximum must be greater than minimum. Minimum: {minimum} and Maximum: {maximum} provided.");

        while (true)
        {            
            var userInput = PromptUser(prompt, false);

            if (int.TryParse(userInput, out var value))
            {
                if (value >= minimum && value <= maximum)
                    return value;
            }

            Console.WriteLine($"'{userInput}' is an invalid value.");
            PressEnterToContinue();            
        }
    }

    #endregion

    #region Assignment

    private static void DisplayWelcome()
        => WriteConsole("Welcome to the program!");
    
    private static string PromptUserName()
        => PromptUser("Please Enter Your Name: ", false);

    private static int PromptUserNumber()
        => PropmptUserForInteger("Please enter your favorite number: ");

    private static int SquareNumber(int number)
        => number * number;

    private static void DisplayResult(string userName, int square)
        => WriteConsole($"{userName}, the square of your number is {square}.");
        
    #endregion

}