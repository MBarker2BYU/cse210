namespace Mindfulness.Sparta.Helpers;

public class ConsoleHelper
{
    public static readonly string Indent = new(' ', 2);

    public static void PressEnterToContinue()
    {

        WriteLinePlus("Press enter to continue...", leadingLines: 1);

        while (true)
        {
            if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                break;

            Thread.Sleep(250);
        }
    }

    public static void AddLines(int count = 1)
    {
        for (var i = 0; i < count; i++)
            Console.WriteLine();
    }

    public static void WriteLinePlus(string? value, bool clear = false, int leadingLines = 0, int trailingLines = 0)
    {
        if (clear)
            Console.Clear();

        AddLines(leadingLines);
        Console.WriteLine(value);
        AddLines(trailingLines);
    }

    public static bool NumberPrompt(out int number, string prompt="Please enter a number.")
    {
        var cursorPosition = Console.GetCursorPosition();

        while (true)
        {
            WriteLinePlus(prompt, leadingLines: 1);
            if(!int.TryParse(Console.ReadLine(), out number))
            {
                WriteLinePlus("Invalid input. Please enter a valid number.", leadingLines: 1);
                Console.SetCursorPosition(cursorPosition.Left, cursorPosition.Top);
                continue;
            }
            break;
        }

        return true;
    }

    public static void Clear((int Left, int Top) cursorLocation, int length)
    {
        try
        {
            Console.SetCursorPosition(cursorLocation.Left, cursorLocation.Top);

            Console.Write(new string(' ', length));

            Console.SetCursorPosition(cursorLocation.Left, cursorLocation.Top);

            Console.CursorVisible = false;
        }
        catch (Exception e)
        {
            Console.CursorVisible = true;
        }
    }

    public static void StandbyReadyBegin(int start = 3, int interval = 1000, int top = -1, bool clear = false)
    {
        if (clear)
            Console.Clear();

        if (top > -1)
            Console.SetCursorPosition(Console.CursorLeft, top);

        var cursorLocation = Console.GetCursorPosition();

        try
        {

            Console.Write("Standby!");
            Thread.Sleep(interval);
            var tmpCursorLocation = Console.GetCursorPosition();

            Console.Write(" 3");
            Thread.Sleep(interval);
            Clear(tmpCursorLocation, 2);


            Console.Write(" 2");
            Thread.Sleep(interval);
            Clear(cursorLocation, 10);

            Console.Write("Ready!");
            Thread.Sleep(interval);
            Clear(cursorLocation, 6);

            Console.Write("Begin!");
            Thread.Sleep(interval);
            Clear(cursorLocation, 6);

        }
        finally
        {
            Console.SetCursorPosition(cursorLocation.Left, cursorLocation.Top);
            Console.CursorVisible = true;
        }
    }

    public static void CountTo(int upTo = 10, int interval = 1000, bool setCursorVisible = true)
    {
        var cursorLocation = Console.GetCursorPosition();

        try
        {
            Console.CursorVisible = false;

            for (var i = 1; i <= upTo; i++)
            {
                var number = $"{i}";
                Console.Write(number);
                Thread.Sleep(interval);
                Clear(cursorLocation, number.Length);
            }
        }
        finally
        {
            Console.SetCursorPosition(cursorLocation.Left, cursorLocation.Top);
            Console.CursorVisible = setCursorVisible;
        }
    }

    public static List<char> SixDotBraille()
    {
        var brailleList = new List<char>();

        for (var i = 0x1; i < 0x40; i++)
        {
            brailleList.Add((char)(0x2800 + i - 1));
        }

        return brailleList;
    }

    public static List<char> Eight8DotBraille()
    {
        var brailleList = new List<char>();

        for (var i = 0x41; i < 0x100; i++)
        {
            brailleList.Add((char)(0x2800 + i - 1));
        }

        return brailleList;
    }

}