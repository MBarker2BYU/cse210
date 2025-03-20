// ***********************************************************************
// Assembly        : Journal
// Author            : Matthew D. Barker
// Created           : 03-05-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-20-2025
// ***********************************************************************
// <copyright file="Program.cs" company="Journal">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Runtime.CompilerServices;
using Journal.Enums;
using Journal.Sparta.Menus;

namespace Journal;

/// <summary>
/// Class Program.
/// </summary>
class Program
{
    /// <summary>
    /// The title
    /// </summary>
    private const string TITLE = "W02 Project: Journal Program";

    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    /// <param name="args">The arguments.</param>
    public static void Main(string[] args)
    {
        var journal = new global::Journal.Journal();

        WriteTitle();

        var mainMenu = new ConsoleMenu();
        mainMenu.MenuSystemItemEvent += (sender, eventArgs) =>
        {
            var skipPressEnter = false;

            if (sender is not ConsoleMenu main) return;

            WriteTitle();

            switch ((MenuItem)eventArgs.MenuItem)
            {
                case MenuItem.AddEntry:
                {
                    var newJournalEntry = journal.NewJournalEntry();

                    try
                    {
                        Console.CursorVisible = true;

                        Console.WriteLine(newJournalEntry.Prompt);
                        newJournalEntry.Response = Console.ReadLine();

                        if (!journal.AddEntry(newJournalEntry, out var exception))
                        {
                            if (exception != null)
                                throw exception;
                        }
                        
                        FormattedWriteLine("Entry added successfully to journal.");
                    }
                    catch (Exception ex)
                    {
                        PublishException(ex);
                    }
                    finally
                    {
                        Console.CursorVisible = false;
                    }

                    break;
                }
                case MenuItem.DisplayAll:
                {
                    try
                    {
                        if (!journal.DisplayAll(out var exception))
                        {
                            if (exception != null)
                                throw exception;
                        }
                    }
                    catch (Exception ex)
                    {
                        PublishException(ex);
                    }

                    break;
                }
                case MenuItem.LoadFromFile:
                {
                    try
                    {
                        Console.CursorVisible = true;

                        Console.WriteLine("What is the name of the file you want to load without the extension?");
                        var filename = Console.ReadLine();

                        if (!journal.LoadFromFile(filename, out var exception))
                        {
                            if (exception != null)
                                throw exception;
                        }

                        
                        FormattedWriteLine("File loaded successfully!");
                    }
                    catch (Exception ex)
                    {
                        PublishException(ex);
                    }
                    finally
                    {
                        Console.CursorVisible = false;
                    }

                    break;
                }
                case MenuItem.SaveToFile:
                {
                    try
                    {
                        Console.CursorVisible = true;

                        Console.WriteLine("What is the name of the file you want to save without the extension?");
                        var filename = Console.ReadLine();

                        if (!journal.SaveToFile(filename, out var exception))
                        {
                            if (exception != null)
                                throw exception;
                        }

                        FormattedWriteLine("File saved successfully!");
                    }
                    catch (Exception ex)
                    {
                        PublishException(ex);
                    }
                    finally
                    {
                        Console.CursorVisible = false;
                    }

                    break;
                }
                case MenuItem.Exit:
                {
                    skipPressEnter = true;
                    main.Exit();
                    break;
                }
            }

            if (!skipPressEnter)
                PressEnter();

            WriteTitle();

        };
        mainMenu.Show([
            MenuItem.AddEntry, MenuItem.DisplayAll, MenuItem.LoadFromFile, MenuItem.SaveToFile, MenuItem.Exit]);

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
}