// ***********************************************************************
// Assembly        : Homework
// Author            : Matthew D. Barker
// Created           : 03-25-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-25-2025
// ***********************************************************************
// <copyright file="IMathAssignment.cs" company="Homework">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Homework.Interfaces;

/// <summary>
/// Interface IMathAssignment
/// Extends the <see cref="Homework.Interfaces.IAssignment" />
/// </summary>
/// <seealso cref="Homework.Interfaces.IAssignment" />
public interface IMathAssignment : IAssignment
{
    /// <summary>
    /// Gets the textbook section.
    /// </summary>
    /// <value>The textbook section.</value>
    public string TextbookSection { get; }

    /// <summary>
    /// Gets the problems.
    /// </summary>
    /// <value>The problems.</value>
    public string Problems { get; }

    /// <summary>
    /// Gets the homework list.
    /// </summary>
    /// <returns>System.String.</returns>
    public string GetHomeworkList();
}