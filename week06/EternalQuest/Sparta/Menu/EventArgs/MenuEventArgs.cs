﻿// ***********************************************************************
// Assembly        : EternalQuest
// Author            : Matthew D. Barker
// Created           : 04-06-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 04-06-2025
// ***********************************************************************
// <copyright file="MenuEventArgs.cs" company="EternalQuest">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace EternalQuest.Sparta.Menu.EventArgs;

/// <summary>
/// Class MenuEventArgs.
/// Implements the <see cref="System.EventArgs" />
/// </summary>
/// <typeparam name="T"></typeparam>
/// <param name="menuItem">The menu item.</param>
/// <seealso cref="System.EventArgs" />
public class MenuEventArgs<T>(T menuItem) : System.EventArgs where T : Enum
{
    /// <summary>
    /// Gets the menu item.
    /// </summary>
    /// <value>The menu item.</value>
    public T MenuItem { get; } = menuItem;
}