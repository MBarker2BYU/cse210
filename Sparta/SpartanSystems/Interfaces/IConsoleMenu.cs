// ***********************************************************************
// Assembly        : SpartanSystems
// Author            : Matthew D. Barker
// Created           : 03-13-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-13-2025
// ***********************************************************************
// <copyright file="IConsoleMenu.cs" company="SpartanSystems">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace SpartanSystems.Interfaces;

/// <summary>
/// Interface IConsoleMenu
/// Extends the <see cref="SpartanSystems.Interfaces.IBaseConsoleMenu" />
/// </summary>
/// <seealso cref="SpartanSystems.Interfaces.IBaseConsoleMenu" />
public interface IConsoleMenu : IBaseConsoleMenu
{
    /// <summary>
    /// Gets or sets the menu items.
    /// </summary>
    /// <value>The menu items.</value>
    new IEnumerable<Enum> MenuItems { get; set; }
}