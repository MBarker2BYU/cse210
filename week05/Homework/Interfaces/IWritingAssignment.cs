// ***********************************************************************
// Assembly        : Homework
// Author            : Matthew D. Barker
// Created           : 03-25-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-25-2025
// ***********************************************************************
// <copyright file="IWritingAssignment.cs" company="Homework">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Homework.Interfaces;

/// <summary>
/// Interface IWritingAssignment
/// Extends the <see cref="Homework.Interfaces.IAssignment" />
/// </summary>
/// <seealso cref="Homework.Interfaces.IAssignment" />
public interface IWritingAssignment : IAssignment
{
    /// <summary>
    /// Gets the title.
    /// </summary>
    /// <value>The title.</value>
    public string Title { get; }

    /// <summary>
    /// Gets the writing information.
    /// </summary>
    /// <returns>System.String.</returns>
    public string GetWritingInformation();
}