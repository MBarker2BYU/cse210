// ***********************************************************************
// Assembly        : Mindfulness
// Author            : Matthew D. Barker
// Created           : 03-20-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-21-2025
// ***********************************************************************
// <copyright file="StringMenuItem.cs" company="Mindfulness">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Mindfulness.Sparta.Menus.Interfaces;

namespace Mindfulness.Sparta.Menus;

/// <summary>
/// Class StringMenuItem.
/// Implements the <see cref="IStringMenuItem" />
/// </summary>
/// <param name="obj">The object.</param>
/// <param name="menuText">The menu text.</param>
/// <seealso cref="IStringMenuItem" />
public class StringMenuItem(object obj, string menuText) : IStringMenuItem
{
    /// <summary>
    /// Initializes a new instance of the <see cref="StringMenuItem"/> class.
    /// </summary>
    /// <param name="obj">The object.</param>
    public StringMenuItem(object obj) : this(obj, obj.ToString())
    {}

    /// <summary>
    /// Gets the menu text.
    /// </summary>
    /// <value>The menu text.</value>
    public string MenuText { get; } = menuText;
    /// <summary>
    /// Gets the object.
    /// </summary>
    /// <value>The object.</value>
    public object Object { get; } = obj;
}