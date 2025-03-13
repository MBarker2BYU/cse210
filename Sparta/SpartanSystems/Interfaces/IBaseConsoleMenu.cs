// ***********************************************************************
// Assembly        : SpartanSystems
// Author            : Matthew D. Barker
// Created           : 03-13-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-13-2025
// ***********************************************************************
// <copyright file="IBaseConsoleMenu.cs" company="SpartanSystems">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using SpartanSystems.EventArgs;

namespace SpartanSystems.Interfaces;

/// <summary>
/// Interface IConsoleMenu
/// </summary>
public interface IBaseConsoleMenu
{

    #region Methods

    /// <summary>
    /// Shows this instance.
    /// </summary>
    public void Show();
    /// <summary>
    /// Exits this instance.
    /// </summary>
    void Exit();

    #endregion

    #region properties

    /// <summary>
    /// Gets or sets the color of the selected background.
    /// </summary>
    /// <value>The color of the selected background.</value>
    ConsoleColor SelectedBackgroundColor { get; set; }
    /// <summary>
    /// Gets or sets the color of the selected foreground.
    /// </summary>
    /// <value>The color of the selected foreground.</value>
    ConsoleColor SelectedForegroundColor { get; set; }
    /// <summary>
    /// Gets the menu items.
    /// </summary>
    /// <value>The menu items.</value>
    IEnumerable<Enum> MenuItems { get; }

    /// <summary>
    /// Gets the start position.
    /// </summary>
    /// <value>The start position.</value>
    int StartPosition { get; }
    /// <summary>
    /// Gets the end position.
    /// </summary>
    /// <value>The end position.</value>
    int EndPosition { get; }
    
    #endregion
}