// ***********************************************************************
// Assembly        : SpartanSystems
// Author            : Matthew D. Barker
// Created           : 03-05-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-12-2025
// ***********************************************************************
// <copyright file="Utilities.cs" company="SpartanSystems">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Text;

namespace SpartanSystems
{
    /// <summary>
    /// Class Utilities.
    /// </summary>
    public class Utilities
    {
        /// <summary>
        /// Adds the prompt.
        /// </summary>
        /// <param name="prompt">The prompt.</param>
        /// <param name="spacingBefore">The spacing before.</param>
        /// <param name="spacingAfter">The spacing after.</param>
        /// <param name="pressEnterToContinue">if set to <c>true</c> [press enter to continue].</param>
        public static void AddPrompt(string prompt, int spacingBefore = 0, int spacingAfter = 1, bool pressEnterToContinue = false)
            => WriteLinePlus(prompt, false, spacingBefore, spacingAfter, pressEnterToContinue);

        /// <summary>
        /// Adds the spacing.
        /// </summary>
        /// <param name="lines">The lines.</param>
        public static void AddSpacing(int lines = 1)
        {
            for (var i = 0; i < lines; i++)
            {
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Clears the range.
        /// </summary>
        /// <param name="start">The start.</param>
        /// <param name="end">The end.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">Start and end must be within the console buffer height and start must be less than or equal to end.</exception>
        public static void ClearRange(int start, int end)
        {
            if (start < 0 || end < 0 || start > end || end >= Console.BufferHeight)
                throw new ArgumentOutOfRangeException($"{nameof(start)} and {nameof(end)}", "Start and end must be within the console buffer height and start must be less than or equal to end.");

            for (var i = start; i <= end; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(new string(' ', Console.BufferWidth));
            }
            
            Console.SetCursorPosition(0, start);
        }

        /// <summary>
        /// Clears the range.
        /// </summary>
        /// <param name="start">The start.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">start - Start must be within the console buffer height.</exception>
        public static void ClearRange(int start)
        {
            if (start < 0 || start >= Console.BufferHeight)
                throw new ArgumentOutOfRangeException(nameof(start), "Start must be within the console buffer height.");

            for (var i = start; i < Console.BufferHeight; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(new string(' ', Console.BufferWidth));
            }
            
            Console.SetCursorPosition(0, start);
        }

        /// <summary>
        /// Formats the line.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>System.String.</returns>
        public static string FormatLine(string text)
            => $"{text}{new string(' ', Console.WindowWidth - text.Length)}";

        /// <summary>
        /// Inserts the spaces.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>System.String.</returns>
        public static string InsertSpaces(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return text;

            var result = new System.Text.StringBuilder();
            foreach (var character in text)
            {
                if (char.IsUpper(character) && result.Length > 0 && result[^1] != ' ') result.Append(' ');

                result.Append(character);
            }

            return result.ToString();
        }

        public static (ConsoleColor BackgroundColor, ConsoleColor ForegroundColor) GetConsoleColors()
            => (Console.BackgroundColor, Console.ForegroundColor);
        
        /// <summary>
        /// Inserts the spaces.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.String.</returns>
        public static string InsertSpaces(Enum value)
            => InsertSpaces(value.ToString());

        /// <summary>
        /// Creates new screen.
        /// </summary>
        /// <param name="title">The title.</param>
        /// <param name="prompt">The prompt.</param>
        /// <param name="pressEnter">if set to <c>true</c> [press enter].</param>
        public static void NewScreen(string title, string prompt = "", bool pressEnter = false)
        {
            Console.Clear();

            WriteLine(title, true);

            if (prompt.Equals(""))
                return;

            WriteLine(prompt);
        }

        /// <summary>
        /// Waits for the user to press enter
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
        /// Prompts the specified prompt.
        /// </summary>
        /// <param name="prompt">The prompt.</param>
        /// <param name="response">The response.</param>
        /// <param name="returnKey">The return key.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Prompt(string prompt, out string response, ConsoleKey returnKey = ConsoleKey.Enter)
        {
            response = default!;

            try
            {
                var stringBuilder = new StringBuilder();

                WriteLine(prompt);

                var exit = false;
                var lineIndex = Console.GetCursorPosition().Top;
                
                while (true)
                {
                    if(exit)
                        break;
                    var consoleKeyInfo = Console.ReadKey();

                    switch (consoleKeyInfo.Key)
                    {
                        case ConsoleKey.Enter:
                        {
                            exit = true;
                            break;
                        }
                        case ConsoleKey.Backspace:
                        {
                            stringBuilder.Remove(stringBuilder.Length - 1, 1);

                            break;
                        }
                        case ConsoleKey.Delete:
                        {
                            var index = Console.GetCursorPosition().Left;

                                stringBuilder.Remove(index, 1);

                                break;
                        }
                        default:
                        {
                            if(char.IsAsciiLetterOrDigit(consoleKeyInfo.KeyChar) || consoleKeyInfo.Key == ConsoleKey.Spacebar)
                                stringBuilder.Append(consoleKeyInfo.KeyChar);

                            break;
                        }
                    }
                    
                    Console.SetCursorPosition(0, lineIndex); 
                    WriteLinePlus(stringBuilder.ToString(), spacingAfter: 0);
                    Console.SetCursorPosition(stringBuilder.Length, lineIndex);
                    
                }

                response = stringBuilder.ToString();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static void SetConsoleColors((ConsoleColor backgroundColor, ConsoleColor forgroundColor) colors)
        {
            Console.BackgroundColor = colors.backgroundColor;
            Console.ForegroundColor = colors.forgroundColor;
        }

        public static void SetPosition((int Left, int Top) position, bool clear = true, int end = -1)
        {
            Console.SetCursorPosition(position.Left, position.Top);
            
            if (!clear) return;
            
            if (end >= position.Top)
            {
                ClearRange(position.Top, end);
            }
            else
            {
                ClearRange(position.Top);
            }
        }

        public static void Write(string text, bool isSelected = false, ConsoleColor selectedBackgroundColor = ConsoleColor.White, ConsoleColor selectedForegroundColor = ConsoleColor.Black)
        {
            //var backgroundColor = Console.BackgroundColor;
            //var foregroundColor = Console.ForegroundColor;

            var colors = GetConsoleColors();
            
            if (isSelected)
            {
                //Console.BackgroundColor = selectedBackgroundColor;
                //Console.ForegroundColor = selectedForegroundColor;
                SetConsoleColors((selectedBackgroundColor, selectedForegroundColor));
            }

            Console.Write(text);

            //Console.BackgroundColor = colors.BackgroundColor;
            //Console.ForegroundColor = colors.ForegroundColor;
            SetConsoleColors(colors);
            
            Console.Write(new string(' ', Console.BufferWidth - text.Length));
        }

        public static void WriteWithHighlight(string text, ConsoleColor selectedBackgroundColor = ConsoleColor.White,
            ConsoleColor selectedForegroundColor = ConsoleColor.Black)
            => Write(text, true, selectedBackgroundColor, selectedForegroundColor);


        /// <summary>
        /// Writes the line.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="isSelected">if set to <c>true</c> [is selected].</param>
        /// <param name="selectedBackgroundColor">Color of the selected background.</param>
        /// <param name="selectedForegroundColor">Color of the selected foreground.</param>
        public static void WriteLine(string text = "", bool isSelected = false, ConsoleColor selectedBackgroundColor = ConsoleColor.White, ConsoleColor selectedForegroundColor = ConsoleColor.Black)
        {
            //var backgroundColor = Console.BackgroundColor;
            //var foregroundColor = Console.ForegroundColor;

            var colors = GetConsoleColors();

            if (isSelected)
            {
                //Console.BackgroundColor = selectedBackgroundColor;
                //Console.ForegroundColor = selectedForegroundColor;

                SetConsoleColors((selectedBackgroundColor, selectedForegroundColor));
            }

            Console.Write(text);

            //Console.BackgroundColor = backgroundColor;
            //Console.ForegroundColor = foregroundColor;
            SetConsoleColors(colors);

            Console.Write($"{new string(' ', Console.BufferWidth - text.Length)}\n");
        }

        /// <summary>
        /// Writes the line plus.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="clearScreen">if set to <c>true</c> [clear screen].</param>
        /// <param name="spacingBefore">The spacing before.</param>
        /// <param name="spacingAfter">The spacing after.</param>
        /// <param name="pressEnterToContinue">if set to <c>true</c> [press enter to continue].</param>
        public static void WriteLinePlus(string text, bool clearScreen = false, int spacingBefore = 0, int spacingAfter = 1, bool pressEnterToContinue = false)
        {
            if (clearScreen)
                Console.Clear();

            if (spacingBefore > 0)
                AddSpacing(spacingBefore);

            Console.WriteLine(FormatLine(text));

            if (spacingAfter > 0)
                AddSpacing(spacingAfter);

            if (pressEnterToContinue)
                PressEnter();
        }

        public static void WriteLineWithHighlights(string text, ConsoleColor selectedBackgroundColor = ConsoleColor.White, ConsoleColor selectedForegroundColor = ConsoleColor.Black, string tagBegin = @"\!@", string endTag = @"\@!")
        {
            var colors = GetConsoleColors();
            
            try
            {
                
                if (string.IsNullOrEmpty(text))
                {
                    WriteLine();
                    return;
                }

                var startIndex = 0;

                while (true)
                {
                    startIndex = text.IndexOf(tagBegin, startIndex, StringComparison.Ordinal);
                    var endIndex = text.IndexOf(endTag, startIndex + tagBegin.Length, StringComparison.Ordinal);

                    if (startIndex == -1 || endIndex == -1)
                        break;

                    var before = text.Substring(0, startIndex);

                    var selectedText =
                        text.Substring(startIndex + tagBegin.Length, endIndex - startIndex - tagBegin.Length);

                    var after = text.Substring(endIndex + endTag.Length);

                    startIndex = endIndex;

                    Console.Write(before);

                    SetConsoleColors((selectedBackgroundColor, selectedForegroundColor));
                    
                    Console.Write(selectedText);

                    SetConsoleColors(colors);
                    
                    Console.Write($"{after}\n");
                }
            }
            finally
            {
                SetConsoleColors(colors);
            }
        }

        /// <summary>
        /// Yeses the no prompt.
        /// </summary>
        /// <param name="prompt">The prompt.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool YesNoPrompt(string prompt)
        {
            WriteLine(prompt);
            return Console.ReadKey(true).Key == ConsoleKey.Y;
        }



    }
}
