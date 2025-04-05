#nullable enable
namespace Mindfulness;

public class ConsoleHelper
{
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

    public static void Countdown(int start = 3, int interval = 1000)
    {
        var cursorLocation = Console.GetCursorPosition();

        try
        {
            Console.CursorVisible = false;

            for (var i = start; i > 0; i--)
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
            Console.CursorVisible = true;
        }
    }

    public static void CountTo(int upTo = 10, int interval =1000, bool setCursorVisible = true)
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

    public static void StandbyReadyBegin(int start = 3, int interval = 1000, int top = -1)
    {
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
}