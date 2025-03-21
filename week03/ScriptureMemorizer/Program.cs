using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using ScriptureMemorizer.Enums;
using ScriptureMemorizer.Sparta.Menus;

namespace ScriptureMemorizer;

class Program
{
    private const string TITLE = "W03 Project: Scripture Memorizer Program";

    static void Main(string[] args)
    {

        var scriptureLibrary = LoadScriptures();
        
        
        
        var scripture = LoadScripture();

        LoadScriptures();
        
        WriteTitle();

        Console.WriteLine(scripture.Display());
        Console.WriteLine();

        var menu = new ConsoleMenu();
        menu.MenuSystemItemEvent += (sender, eventArgs) =>
        {

            if (sender is not ConsoleMenu main) return;

            WriteTitle();

            switch ((ProgramOption)eventArgs.MenuItem)
            {
                case ProgramOption.Continue:
                {
                    if (scripture.AllWordAreHidden)
                    {
                        menu.Exit();
                        break;
                    }

                    scripture.HideRandomWords(3);
                    
                    WriteTitle();

                    Console.WriteLine(scripture.Display());
                    Console.WriteLine();

                    break;
                }
                case ProgramOption.Quit:
                {
                    menu.Exit();
                    break;
                }
            }
            
            
        };
        menu.Show([ProgramOption.Continue, ProgramOption.Quit]);

        WriteExitMessage();
    }

    /// <summary>
    /// A prompt that waits until user presses enter.
    /// </summary>
    public static void PressEnter()
    {
        Console.WriteLine("Press Enter to continue...");
        while (Console.ReadKey(true).Key != ConsoleKey.Enter)
        {
            // Wait for the Enter key to be pressed
        }
    }

    /// <summary>
    /// Writes a clean and spaced title.
    /// </summary>
    static void WriteTitle()
    {
        Console.Clear();
        Console.WriteLine(TITLE);
        Console.WriteLine();
    }

    /// <summary>
    /// Writes a clean and polite exit message.
    /// </summary>
    static void WriteExitMessage()
    {
        WriteTitle();

        Console.WriteLine("Thank you for using the Journal application!");
        Console.WriteLine();
        Console.WriteLine("Have a blessed day!");
        Console.WriteLine();

        PressEnter();

        Environment.Exit(0);
    }

    /// <summary>
    /// Publishes the exception.
    /// </summary>
    /// <param name="exception">The exception.</param>
    /// <param name="memberName">Name of the member.</param>
    static void PublishException(Exception exception, [CallerMemberName] string memberName = "Unknown")
    {
        WriteTitle();

        Console.WriteLine($"{memberName} failed.");
        Console.WriteLine();
        Console.WriteLine($"Exception: {exception.Message}");
    }

    /// <summary>
    ///  Writes a clean and spaced line.
    /// </summary>
    /// <param name="value">The value.</param>
    static void FormattedWriteLine(string value)
    {
        Console.WriteLine();
        Console.WriteLine(value);
        Console.WriteLine();
    }

    static Scripture LoadScripture()
    {
        return new Scripture(new ScriptureReference("Psalm", 144, 1,2), @" Praise the Lord, who is my rock. He trains my hands for war, and gives my fingers skill for battle. He is my loving ally and my fortress, my tower of safety, my rescuer. He is my shield, and I take refuge in him. He makes the nations submit to me.");
    }

    static ScriptureLibrary LoadScriptures()
    {
        var json = File.ReadAllText("ScriptureLibrary.json");
        
        return JsonConvert.DeserializeObject<ScriptureLibrary>(json);
    }

}