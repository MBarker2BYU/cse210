// ***********************************************************************
// Assembly        : SpartanSystems
// Author            : Matthew D. Barker
// Created           : 03-05-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-12-2025
// ***********************************************************************
// <copyright file="ConsoleColorMenu.cs" company="SpartanSystems">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using SpartanSystems.EventArgs;
using SpartanSystems.Interfaces;
using SpartanSystems.Menus.Base;

namespace SpartanSystems.Menus;

/// <summary>
/// Class ConsoleColorMenu.
/// Implements the <see cref="MenuBase" />
/// </summary>
/// <seealso cref="MenuBase" />
public class ConsoleColorMenu : MenuBase
{
    /// <summary>
    /// Class MenuBase.
    /// </summary>
    /// <param name="backgroundColor">Color of the background.</param>
    /// <param name="foregroundColor">Color of the foreground.</param>
    public ConsoleColorMenu(ConsoleColor backgroundColor = ConsoleColor.White, ConsoleColor foregroundColor = ConsoleColor.Black) : base(backgroundColor, foregroundColor)
    {
        MenuItems = Enum.GetValues(typeof(ConsoleColor)).Cast<Enum>();
    }
}