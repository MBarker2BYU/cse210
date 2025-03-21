﻿// ***********************************************************************
// Assembly        : ScriptureMemorizer
// Author            : Matthew D. Barker
// Created           : 03-05-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-21-2025
// ***********************************************************************
// <copyright file="IConsoleMenu.cs" company="ScriptureMemorizer">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace ScriptureMemorizer.Sparta.Menus.Interfaces;

/// <summary>
/// Interface IConsoleMenu
/// Extends the <see cref="ScriptureMemorizer.Sparta.Menus.Interfaces.IConsoleMenuBase" />
/// </summary>
/// <seealso cref="ScriptureMemorizer.Sparta.Menus.Interfaces.IConsoleMenuBase" />
public interface IConsoleMenu : IConsoleMenuBase
{
    #region Methods

    /// <summary>
    /// Shows this instance.
    /// </summary>
    /// <param name="menuItems">The menu items.</param>
    public void Show(IEnumerable<Enum> menuItems);

    /// <summary>
    /// Shows the specified exception.
    /// </summary>
    /// <param name="menuItems">The menu items.</param>
    /// <param name="exception">The exception.</param>
    /// <returns><c>true</c> if the menu is shown successfully , <c>false</c> otherwise.</returns>
    public bool Show(IEnumerable<Enum> menuItems, out Exception exception);

    #endregion
}
    