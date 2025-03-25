// ***********************************************************************
// Assembly        : Homework
// Author            : Matthew D. Barker
// Created           : 03-25-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-25-2025
// ***********************************************************************
// <copyright file="IStudent.cs" company="Homework">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Homework.Interfaces;

/// <summary>
/// Interface IStudent
/// </summary>
public interface IStudent
{
    /// <summary>
    /// Gets the first name.
    /// </summary>
    /// <value>The first name.</value>
    public string FirstName { get; }
    /// <summary>
    /// Gets the last name.
    /// </summary>
    /// <value>The last name.</value>
    public string LastName { get; }
}