// ***********************************************************************
// Assembly        : ScriptureMemorizer
// Author            : Matthew D. Barker
// Created           : 03-20-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-21-2025
// ***********************************************************************
// <copyright file="MenuItemSelectedEventArgs.cs" company="ScriptureMemorizer">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using ScriptureMemorizer.Sparta.Menus.Interfaces;

namespace ScriptureMemorizer.Sparta.Menus.EventArgs;

/// <summary>
/// Class MenuItemSelectedEventArgs.
/// Implements the <see cref="System.EventArgs" />
/// </summary>
/// <param name="menuItem">The menu item.</param>
/// <seealso cref="System.EventArgs" />
public class MenuItemSelectedEventArgs(IStringMenuItem menuItem) : System.EventArgs
{
    /// <summary>
    /// Gets the menu item.
    /// </summary>
    /// <value>The menu item.</value>
    public IStringMenuItem MenuItem { get; } = menuItem;
}