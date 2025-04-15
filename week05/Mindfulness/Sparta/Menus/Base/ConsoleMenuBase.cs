// ***********************************************************************
// Assembly        : Mindfulness
// Author            : Matthew D. Barker
// Created           : 03-20-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-21-2025
// ***********************************************************************
// <copyright file="ConsoleMenuBase.cs" company="Mindfulness">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Mindfulness.Sparta.ExtensionMethods;
using Mindfulness.Sparta.Menus.EventArgs;
using Mindfulness.Sparta.Menus.Interfaces;

namespace Mindfulness.Sparta.Menus.Base;

/// <summary>
/// Class ConsoleMenuBase.
/// Implements the <see cref="IConsoleMenuBase" />
/// </summary>
/// <param name="backgroundColor">Color of the background.</param>
/// <param name="foregroundColor">Color of the foreground.</param>
/// <seealso cref="IConsoleMenuBase" />
public abstract class ConsoleMenuBase(ConsoleColor backgroundColor = ConsoleColor.White, ConsoleColor foregroundColor = ConsoleColor.Black) : IConsoleMenuBase
{
    #region Events

    /// <summary>
    /// Occurs when [menu system item event].
    /// </summary>
    public event EventHandler<MenuEventArgs<Enum>> MenuSystemItemEvent;

    /// <summary>
    /// Called when [menu system item event].
    /// </summary>
    /// <param name="menuItem">The menu item.</param>
    protected void OnMenuSystemItemEvent(Enum menuItem)
    {
        MenuSystemItemEvent?.Invoke(this, new MenuEventArgs<Enum>(menuItem));
    }

    #endregion

    #region Methods

    /// <summary>
    /// Exits this instance.
    /// </summary>
    public void Exit()
        => Exit(out _);

    /// <summary>
    /// Exits the specified exception.
    /// </summary>
    /// <param name="exception">The exception.</param>
    /// <returns><c>true</c> if the menu set to exit successfully, <c>false</c> otherwise.</returns>
    public bool Exit(out Exception exception)
    {
        exception = default;

        try
        {
            m_Exit = true;

            return true;
        }
        catch (Exception ex)
        {
            exception = ex;
            return false;
        }
    }

    /// <summary>
    /// Shows the specified menu items.
    /// </summary>
    /// <param name="menuItems">The menu items.</param>
    protected void Show(IEnumerable<Enum> menuItems)
        => Show(menuItems, out _);

    /// <summary>
    /// Shows the specified menu items.
    /// </summary>
    /// <param name="menuItems">The menu items.</param>
    /// <param name="exception">The exception.</param>
    /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
    protected bool Show(IEnumerable<Enum> menuItems, out Exception exception)
    {
        exception = default;

        try
        {
            Console.CursorVisible = false;

            var currentIndex = 0;
            m_MenuItems =  menuItems.ToArray();

            StartPosition = Console.GetCursorPosition();
            EndPosition = (StartPosition.Left, StartPosition.Top + m_MenuItems.Length + 1);

            while (true)
            {
                if(m_Exit)
                    break;
                
                Console.SetCursorPosition(0, StartPosition.Top);

                if (m_MenuItems != null)
                {
                    for (var index = 0; index < m_MenuItems.ToArray().Length; index++)
                    {
                        WriteLine(m_MenuItems[index].ToString().InsertSpaces(), currentIndex == index);
                    }
                }

                var consoleKeyInfo = Console.ReadKey(true);

                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.DownArrow:
                        currentIndex = (currentIndex == m_MenuItems.Length - 1 ? 0 : currentIndex + 1);

                        break;
                    case ConsoleKey.UpArrow:
                        currentIndex = (currentIndex == 0 ? m_MenuItems.Length - 1 : currentIndex - 1);

                        break;
                    case ConsoleKey.Enter:
                        OnMenuSystemItemEvent(m_MenuItems[currentIndex]);
                        break;
                }
            }

            Console.SetCursorPosition(StartPosition.Left, StartPosition.Top);
            
            for (var index = StartPosition.Top; index < EndPosition.Top; index++)
            {
                WriteLine("");
            }
            
            Console.SetCursorPosition(StartPosition.Left, StartPosition.Top);
            
            return true;
        }
        catch (Exception ex)
        {
            exception = ex;
            return false;
        }
    }

    /// <summary>
    /// Writes the line.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="isSelected">if set to <c>true</c> [is selected].</param>
    protected void WriteLine(string value, bool isSelected = false)
    {
        var currentBackgroundColor = Console.BackgroundColor;
        var currentForegroundColor = Console.ForegroundColor;

        try
        {
            var currentPosition = Console.GetCursorPosition();
            
            Console.WriteLine(new string(' ', Console.BufferWidth));
            
            if (isSelected)
            {
                Console.BackgroundColor = SelectedBackgroundColor;
                Console.ForegroundColor = SelectedForegroundColor;
            }
            
            Console.SetCursorPosition(currentPosition.Left, currentPosition.Top);
            Console.WriteLine($"{value}");
            
        }
        finally
        {
            Console.BackgroundColor = currentBackgroundColor;
            Console.ForegroundColor = currentForegroundColor;
        }
    }

    #endregion

    #region Properties

    /// <summary>
    /// Gets or sets the color of the selected background.
    /// </summary>
    /// <value>The color of the selected background.</value>
    public ConsoleColor SelectedBackgroundColor { get; set; } = backgroundColor;

    /// <summary>
    /// Gets or sets the color of the selected foreground.
    /// </summary>
    /// <value>The color of the selected foreground.</value>
    public ConsoleColor SelectedForegroundColor { get; set; } = foregroundColor;

    /// <summary>
    /// Gets or sets the m menu items.
    /// </summary>
    /// <value>The m menu items.</value>
    private Enum[] m_MenuItems { get; set; }

    /// <summary>
    /// Gets the start position.
    /// </summary>
    /// <value>The start position.</value>
    public (int Left, int Top) StartPosition { get; protected set; }

    /// <summary>
    /// Gets the end position.
    /// </summary>
    /// <value>The end position.</value>
    public (int Left, int Top) EndPosition { get; protected set; }

    /// <summary>
    /// The m exit
    /// </summary>
    private bool m_Exit;

    #endregion
}