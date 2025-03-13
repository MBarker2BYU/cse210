// ***********************************************************************
// Assembly        : SpartanSystems
// Author            : Matthew D. Barker
// Created           : 03-05-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-12-2025
// ***********************************************************************
// <copyright file="ConsoleMenu.cs" company="SpartanSystems">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using SpartanSystems.Interfaces;
using SpartanSystems.Menus.Base;

namespace SpartanSystems.Menus;

/// <summary>
/// Class ConsoleMenu.
/// Implements the <see cref="MenuBase" />
/// </summary>
/// <param name="backgroundColor">Color of the background.</param>
/// <param name="foregroundColor">Color of the foreground.</param>
/// <seealso cref="MenuBase" />
public class ConsoleMenu(ConsoleColor backgroundColor = ConsoleColor.White, ConsoleColor foregroundColor = ConsoleColor.Black) : MenuBase(backgroundColor, foregroundColor), IConsoleMenu
{
    #region Properties

    /// <summary>
    /// Gets or sets the menu items.
    /// </summary>
    /// <value>The menu items.</value>
    public new IEnumerable<Enum> MenuItems
    {
        get => base.MenuItems;
        set => base.MenuItems = value;
    }

    #endregion
}