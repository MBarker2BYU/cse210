// ***********************************************************************
// Assembly        : Mindfulness
// Author            : Matthew D. Barker
// Created           : 03-05-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-21-2025
// ***********************************************************************
// <copyright file="ConsoleMenu.cs" company="Mindfulness">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Mindfulness.Sparta.Menus.Base;
using Mindfulness.Sparta.Menus.Interfaces;

namespace Mindfulness.Sparta.Menus;

/// <summary>
/// Class ConsoleMenu.
/// Implements the <see cref="ConsoleMenuBase" />
/// Implements the <see cref="IConsoleMenu" />
/// </summary>
/// <seealso cref="ConsoleMenuBase" />
/// <seealso cref="IConsoleMenu" />
public class ConsoleMenu : ConsoleMenuBase, IConsoleMenu
{
    #region Implementation of IConsoleMenu

    /// <summary>
    /// Shows the specified menu items.
    /// </summary>
    /// <param name="menuItems">The menu items.</param>
    public new void Show(IEnumerable<Enum> menuItems)
        => Show(menuItems, out _);

    /// <summary>
    /// Shows the specified menu items.
    /// </summary>
    /// <param name="menuItems">The menu items.</param>
    /// <param name="exception">The exception.</param>
    /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
    public new bool Show(IEnumerable<Enum> menuItems, out Exception exception)
        => base.Show(menuItems, out exception);

    #endregion
}