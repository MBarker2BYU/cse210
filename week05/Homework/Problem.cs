// ***********************************************************************
// Assembly        : Homework
// Author            : Matthew D. Barker
// Created           : 03-25-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-25-2025
// ***********************************************************************
// <copyright file="Problem.cs" company="Homework">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Homework.Interfaces;

namespace Homework;

/// <summary>
/// Class Problem.
/// Implements the <see cref="IProblem" />
/// </summary>
/// <seealso cref="IProblem" />
public class Problem(string text) : IProblem
{
    #region Implementation of IProblem

    /// <summary>
    /// Gets the text.
    /// </summary>
    /// <value>The text.</value>
    public string Text { get; } = text;

    #endregion
}