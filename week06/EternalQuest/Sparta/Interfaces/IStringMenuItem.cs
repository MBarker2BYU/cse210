// ***********************************************************************
// Assembly        : EternalQuest
// Author            : Matthew D. Barker
// Created           : 04-06-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-30-2025
// ***********************************************************************
// <copyright file="IStringMenuItem.cs" company="EternalQuest">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace EternalQuest.Sparta.Interfaces;

/// <summary>
/// Interface IStringMenuItem
/// </summary>
public interface IStringMenuItem
{
    /// <summary>
    /// Gets the menu text.
    /// </summary>
    /// <value>The menu text.</value>
    public string MenuText { get; }

    /// <summary>
    /// Gets the object.
    /// </summary>
    /// <value>The object.</value>
    public object Object { get; }
    
}