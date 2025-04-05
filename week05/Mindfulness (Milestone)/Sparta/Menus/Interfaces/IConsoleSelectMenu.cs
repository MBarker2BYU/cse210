// ***********************************************************************
// Assembly        : Mindfulness
// Author            : Matthew D. Barker
// Created           : 03-20-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-21-2025
// ***********************************************************************
// <copyright file="IConsoleSelectMenu.cs" company="Mindfulness">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Mindfulness.Sparta.Menus.EventArgs;

namespace Mindfulness.Sparta.Menus.Interfaces;

/// <summary>
/// Interface IConsoleSelectMenu
/// </summary>
public interface IConsoleSelectMenu
{
    #region Events

    /// <summary>
    /// Occurs when [menu item selected event].
    /// </summary>
    public event EventHandler<MenuItemSelectedEventArgs> MenuItemSelectedEvent;

    #endregion

    #region Methods

    /// <summary>
    /// Exits the specified exception.
    /// </summary>
    /// <param name="exception">The exception.</param>
    /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
    public bool Exit(out Exception exception);

    /// <summary>
    /// Exits this instance.
    /// </summary>
    public void Exit();

    /// <summary>
    /// Shows the specified menu items.
    /// </summary>
    /// <param name="menuItems">The menu items.</param>
    /// <param name="exception">The exception.</param>
    /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
    public bool Show(IEnumerable<IStringMenuItem> menuItems, out Exception exception);

    /// <summary>
    /// Shows the specified menu items.
    /// </summary>
    /// <param name="menuItems">The menu items.</param>
    /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
    public bool Show(IEnumerable<IStringMenuItem> menuItems);

    #endregion

    #region Properties

    /// <summary>
    /// Gets or sets the color of the selected background.
    /// </summary>
    /// <value>The color of the selected background.</value>
    public ConsoleColor SelectedBackgroundColor { get; set; }

    /// <summary>
    /// Gets or sets the color of the selected foreground.
    /// </summary>
    /// <value>The color of the selected foreground.</value>
    public ConsoleColor SelectedForegroundColor { get; set; }

    /// <summary>
    /// Gets the start position.
    /// </summary>
    /// <value>The start position.</value>
    public (int Left, int Top) StartPosition { get; }

    /// <summary>
    /// Gets the end position.
    /// </summary>
    /// <value>The end position.</value>
    public (int Left, int Top) EndPosition { get; }

    #endregion
}