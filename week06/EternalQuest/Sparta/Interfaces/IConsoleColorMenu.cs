// ***********************************************************************
// Assembly        : EternalQuest
// Author            : Matthew D. Barker
// Created           : 04-06-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-30-2025
// ***********************************************************************
// <copyright file="IConsoleColorMenu.cs" company="EternalQuest">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace EternalQuest.Sparta.Interfaces;

/// <summary>
/// Interface IConsoleColorMenu
/// Extends the <see cref="IConsoleMenuBase" />
/// </summary>
/// <seealso cref="IConsoleMenuBase" />
public interface IConsoleColorMenu : IConsoleMenuBase
{
    /// <summary>
    /// Shows this instance.
    /// </summary>
    public void Show();

    /// <summary>
    /// Shows the specified exception.
    /// </summary>
    /// <param name="exception">The exception.</param>
    public void Show(out Exception exception);
}