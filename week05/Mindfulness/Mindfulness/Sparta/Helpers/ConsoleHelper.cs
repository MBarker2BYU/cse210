using Microsoft.VisualBasic;

namespace Mindfulness.Sparta.Helpers;

public class ConsoleHelper
{
    public static readonly string Indent = new(' ', 2);

    private static readonly List<char> sm_SixDotBraille = SixDotBraille();
    private static readonly List<char> sm_EightDotBraille = Eight8DotBraille();
    private static readonly Dictionary<ConsoleColor, string> sm_ColorMap;
    
    static ConsoleHelper()
    {

        sm_ColorMap = new Dictionary<ConsoleColor, string>
        {
            { ConsoleColor.Black, "\x1b[30m" },
            { ConsoleColor.Red, "\x1b[31m" },
            { ConsoleColor.Green, "\x1b[32m" },
            { ConsoleColor.Yellow, "\x1b[33m" },
            { ConsoleColor.Blue, "\x1b[34m" },
            { ConsoleColor.Magenta, "\x1b[35m" },
            { ConsoleColor.Cyan, "\x1b[36m" },
            { ConsoleColor.White, "\x1b[37m" },
            { ConsoleColor.Gray, "\x1b[90m" },
            { ConsoleColor.DarkRed, "\x1b[91m" },
            { ConsoleColor.DarkGreen, "\x1b[92m" },
            { ConsoleColor.DarkYellow, "\x1b[93m" },
            { ConsoleColor.DarkBlue, "\x1b[94m" },
            { ConsoleColor.DarkMagenta, "\x1b[95m" },
            { ConsoleColor.DarkCyan, "\x1b[96m" }
        };

    }
    
    public static string ReadLine(int timeoutMilliseconds)
    {
        using var cts = new CancellationTokenSource(timeoutMilliseconds);

        Task<string> inputTask = Task.Run(Console.ReadLine, cts.Token)!;

        try
        {
            inputTask.Wait(cts.Token);
            return inputTask.Result;
        }
        catch (OperationCanceledException)
        {
            return null!;
        }
        catch (AggregateException ex)
        {
            if (ex.InnerException is OperationCanceledException)
            {
                return null!;
            }
            throw;
        }
    }


    public static void Animate((int Left, int Top) cursorLocation, CancellationToken token, int interval = 500, ConsoleColor color = ConsoleColor.White)
    {
        
        Task.Run(() =>
        {
            var index = 0;
            var index2 = 3;

            var colorCode = sm_ColorMap[color];

            while (true)
            {
                if (token.IsCancellationRequested)
                    break;

                Console.SetCursorPosition(cursorLocation.Left, cursorLocation.Top);

                Console.Write($"{colorCode}{sm_EightDotBraille[index]}{sm_EightDotBraille[index2]}\x1b[0m");
                
                if (index + 1 >= sm_EightDotBraille.Count)
                    index = 0;
                else
                    index++;

                if (index2 + 1 >= sm_EightDotBraille.Count)
                    index = 0;
                else
                    index2++;

                Thread.Sleep(interval);
            }

        }, token);
    }
    
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

    public static void WritePlusAnimation(string value, out (int Left, int Top) animationPosition, bool clear = false, int leadingLines = 0, int trailingLines = 0,int timeout = 1000, int interval = 100, ConsoleColor color = ConsoleColor.White)
    {
        if (clear)
            Console.Clear();

        AddLines(leadingLines);
        Console.Write(value);

        animationPosition = Console.GetCursorPosition();
        var cts = new CancellationTokenSource(timeout);

        Animate((animationPosition.Left + 2, animationPosition.Top), cts.Token, color: color);

        AddLines(trailingLines + 1);
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