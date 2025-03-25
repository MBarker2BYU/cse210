// ***********************************************************************
// Assembly        : Homework
// Author            : Matthew D. Barker
// Created           : 03-25-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-25-2025
// ***********************************************************************
// <copyright file="IProblem.cs" company="Homework">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Homework.Interfaces;

/// <summary>
/// Interface IProblem
/// </summary>
public interface IProblem
{
    /// <summary>
    /// Gets the text.
    /// </summary>
    /// <value>The text.</value>
    public string Text { get; }
}