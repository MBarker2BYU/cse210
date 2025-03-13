// ***********************************************************************
// Assembly        : SpartanSystems
// Author            : Matthew D. Barker
// Created           : 03-05-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-12-2025
// ***********************************************************************
// <copyright file="MenuBase.cs" company="SpartanSystems">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using SpartanSystems.EventArgs;
using SpartanSystems.Interfaces;

namespace SpartanSystems.Menus.Base;

/// <summary>
/// Class MenuBase.
/// </summary>
/// <param name="backgroundColor">Color of the background.</param>
/// <param name="foregroundColor">Color of the foreground.</param>
public abstract class MenuBase(ConsoleColor backgroundColor = ConsoleColor.White, ConsoleColor foregroundColor = ConsoleColor.Black) : IBaseConsoleMenu
{
    #region Events

    /// <summary>
    /// The menu system item event
    /// </summary>
    public EventHandler<MenuEventArgs<Enum>>? MenuSystemItemEvent;

    /// <summary>
    /// Called when [menu system item event].
    /// </summary>
    /// <param name="menuItem">The menu item.</param>
    private void OnMenuSystemItemEvent(Enum menuItem)
    {
        MenuSystemItemEvent?.Invoke(this, new MenuEventArgs<Enum>(menuItem));
    }

    #endregion

    #region Methods

    /// <summary>
    /// Shows this instance.
    /// </summary>
    public virtual void Show()
    {
        try
        {
            var currentIndex = 0;
            var items = MenuItems.ToArray();

            Console.CursorVisible = false;

            StartPosition = Console.GetCursorPosition().Top;
            EndPosition = StartPosition + items.Length + 1;

            while (true)
            {
                Console.SetCursorPosition(0, StartPosition);

                if (m_Exit)
                    break;

                if (MenuItems != null)
                {
                    for (var index = 0; index < MenuItems.ToArray().Length; index++)
                    {

                        if (currentIndex == index)
                        {
                            WriteLine(items[index].ToString(), true);
                            continue;
                        }

                        Console.WriteLine(items[index]);
                    }

                    var consoleKeyInfo = Console.ReadKey();

                    switch (consoleKeyInfo.Key)
                    {
                        case ConsoleKey.DownArrow:
                            currentIndex = (currentIndex == items.Length - 1 ? 0 : currentIndex + 1);

                            break;
                        case ConsoleKey.UpArrow:
                            currentIndex = (currentIndex == 0 ? items.Length - 1 : currentIndex - 1);

                            break;
                        case ConsoleKey.Enter:
                            OnMenuSystemItemEvent(items[currentIndex]);
                            break;
                    }
                }
            }

            Utilities.ClearRange(StartPosition);
            Console.SetCursorPosition(0, StartPosition);

        }
        finally
        {
            Console.CursorVisible = true;
        }
    }

    /// <summary>
    /// Exits this instance.
    /// </summary>
    public void Exit()
        => m_Exit = true;

    /// <summary>
    /// Writes the line.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <param name="isSelected">if set to <c>true</c> [is selected].</param>
    private void WriteLine(string text, bool isSelected = false)
        => Utilities.WriteLine(text, isSelected, SelectedBackgroundColor, SelectedForegroundColor);

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
    /// Gets or sets the menu items.
    /// </summary>
    /// <value>The menu items.</value>
    public IEnumerable<Enum> MenuItems { get; protected set; } = Enumerable.Empty<Enum>();

    /// <summary>
    /// The m exit
    /// </summary>
    private bool m_Exit = false;

    /// <summary>
    /// Gets or sets the start position.
    /// </summary>
    /// <value>The start position.</value>
    public int StartPosition { get; protected set; } = 0;
    /// <summary>
    /// Gets or sets the end position.
    /// </summary>
    /// <value>The end position.</value>
    public int EndPosition { get; protected set; } = 0;

    #endregion
}