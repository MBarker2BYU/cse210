// ***********************************************************************
// Assembly        : Homework
// Author            : Matthew D. Barker
// Created           : 03-25-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-25-2025
// ***********************************************************************
// <copyright file="IAssignment.cs" company="Homework">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Homework.Interfaces;

/// <summary>
/// Interface IAssignment
/// </summary>
public interface IAssignment
{
    /// <summary>
    /// Gets the name of the student.
    /// </summary>
    /// <value>The name of the student.</value>
    public IStudent StudentName { get; }

    /// <summary>
    /// Gets the topic.
    /// </summary>
    /// <value>The topic.</value>
    public string Topic { get; }

    /// <summary>
    /// Gets the summary.
    /// </summary>
    /// <returns>System.String.</returns>
    public string GetSummary();
}