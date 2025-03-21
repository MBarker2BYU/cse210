// ***********************************************************************
// Assembly        : ScriptureMemorizer
// Author            : Matthew D. Barker
// Created           : 03-17-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-21-2025
// ***********************************************************************
// <copyright file="Program.cs" company="ScriptureMemorizer">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using ScriptureMemorizer.Advanced;
using ScriptureMemorizer.Enums;
using ScriptureMemorizer.Sparta.ExtensionMethods;
using ScriptureMemorizer.Sparta.Menus;

namespace ScriptureMemorizer;

/// <summary>
/// Class Program.
/// </summary>
class Program
{
    /// <summary>
    /// The title
    /// </summary>
    private const string TITLE = "W03 Project: Scripture Memorizer Program";

    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    /// <param name="args">The arguments.</param>
    static void Main(string[] args)
    {
        WriteTitle();

        FormattedWriteLine("Please select one of the following scriptures of Warfighters:");


        if (!LoadScriptures(out var scriptures, out var exception))
            exception.ThrowIfNotNull();

        Scripture selectedScripture = null;

        var selectMenu = new ConsoleSelectMenu();
        selectMenu.MenuItemSelectedEvent += (s, e) =>
        {
            if(s is not ConsoleSelectMenu scriptureMenu) return;
            
            selectedScripture = (Scripture)e.MenuItem.Object;
            scriptureMenu.Exit();

        };
        selectMenu.Show(scriptures.ToMenuItems());

        WriteTitle();

        var beginVerse = Console.GetCursorPosition();
        
        Console.WriteLine(selectedScripture.Display());
        Console.WriteLine();

        var menu = new ConsoleMenu();
        menu.MenuSystemItemEvent += (sender, eventArgs) =>
        {
            
            if (sender is not ConsoleMenu main) return;

            Console.SetCursorPosition(beginVerse.Left, beginVerse.Top);

            switch ((ProgramOption)eventArgs.MenuItem)
            {
                case ProgramOption.Continue:
                {
                    if (selectedScripture.AllWordAreHidden)
                    {
                        menu.Exit();
                        break;
                    }

                    selectedScripture.HideRandomWords(3);
                    
                    Console.WriteLine(selectedScripture.Display());
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
    /// Handles the MenuItemSelectedEvent event of the SelectMenu control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="Sparta.Menus.EventArgs.MenuItemSelectedEventArgs"/> instance containing the event data.</param>
    /// <exception cref="System.NotImplementedException"></exception>
    private static void SelectMenu_MenuItemSelectedEvent(object sender, Sparta.Menus.EventArgs.MenuItemSelectedEventArgs e)
    {
        throw new NotImplementedException();
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
    /// Writes a clean and spaced line.
    /// </summary>
    /// <param name="value">The value.</param>
    static void FormattedWriteLine(string value)
    {
        Console.WriteLine();
        Console.WriteLine(value);
        Console.WriteLine();
    }
    
    /// <summary>
    /// Loads the scriptures.
    /// </summary>
    /// <param name="scriptures">The scriptures.</param>
    /// <param name="exception">The exception.</param>
    /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
    static bool LoadScriptures(out Advanced.Scriptures scriptures, out Exception exception)
    {
        scriptures = default;
        exception = default;
        
        try
        {
            var json = File.ReadAllText("Scriptures.json");
            scriptures = JsonConvert.DeserializeObject<Advanced.Scriptures>(json);

            return true;
        }
        catch (Exception ex)
        {
            scriptures = default;
            exception = ex;
            
            return false;
        }
    }

}