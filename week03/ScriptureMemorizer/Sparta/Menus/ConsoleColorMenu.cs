// ***********************************************************************
// Assembly         : ScriptureMemorizer
// Author           : Matthew D. Barker
// Created          : 03-05-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-21-2025
// ***********************************************************************
// <copyright file="ConsoleColorMenu.cs" company="ScriptureMemorizer">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using ScriptureMemorizer.Sparta.Menus.Base;
using ScriptureMemorizer.Sparta.Menus.Interfaces;

namespace ScriptureMemorizer.Sparta.Menus;

/// <summary>
/// Class ConsoleColorMenu.
/// Implements the <see cref="ConsoleMenuBase" />
/// Implements the <see cref="IConsoleColorMenu" />
/// </summary>
/// <seealso cref="ConsoleMenuBase" />
/// <seealso cref="IConsoleColorMenu" />
public class ConsoleColorMenu : ConsoleMenuBase, IConsoleColorMenu
{
    #region Implementation of IConsoleColorMenu

    /// <summary>
    /// Shows this instance.
    /// </summary>
    public void Show()
        => Show(out _);

    /// <summary>
    /// Shows the specified exception.
    /// </summary>
    /// <param name="exception">The exception.</param>
    public void Show(out Exception exception)
        => base.Show(Enum.GetValues(typeof(ConsoleColor)).Cast<Enum>() , out exception);

    #endregion
}