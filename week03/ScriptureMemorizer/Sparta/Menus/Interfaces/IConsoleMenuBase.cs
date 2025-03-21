// ***********************************************************************
// Assembly        : Journal
// Author            : Matthew D. Barker
// Created           : 03-05-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-19-2025
// ***********************************************************************
// <copyright file="IConsoleMenuBase.cs" company="Journal">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using ScriptureMemorizer.Sparta.Menus.EventArgs;

namespace ScriptureMemorizer.Sparta.Menus.Interfaces;

/// <summary>
/// Interface IConsoleMenuBase
/// </summary>
public interface IConsoleMenuBase
{
    #region Events

    public event EventHandler<MenuEventArgs<Enum>> MenuSystemItemEvent;

    #endregion

    #region Methods

    /// <summary>
    /// Exits this instance.
    /// </summary>
    public void Exit();

    /// <summary>
    /// Exits the specified exception.
    /// </summary>
    /// <param name="exception">The exception.</param>
    /// <returns><c>true</c> if the menu set to exit successfully, <c>false</c> otherwise.</returns>
    public bool Exit(out Exception exception);

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