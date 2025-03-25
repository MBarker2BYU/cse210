// ***********************************************************************
// Assembly        : Homework
// Author            : Matthew D. Barker
// Created           : 03-25-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-25-2025
// ***********************************************************************
// <copyright file="Assignment.cs" company="Homework">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Homework.Interfaces;

namespace Homework;

/// <summary>
/// Class Assignment.
/// Implements the <see cref="IAssignment" />
/// </summary>
/// <param name="studentName">Name of the student.</param>
/// <param name="topic">The topic.</param>
/// <seealso cref="IAssignment" />
public class Assignment(IStudent studentName, string topic) : IAssignment
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Assignment"/> class.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <param name="topic">The topic.</param>
    public Assignment(string name, string topic) : this(new Student(name), topic)
    { }

    /// <summary>
    /// Initializes a new instance of the <see cref="Assignment"/> class.
    /// </summary>
    /// <param name="firstName">The first name.</param>
    /// <param name="lastName">The last name.</param>
    /// <param name="topic">The topic.</param>
    public Assignment(string firstName, string lastName, string topic) : this(new Student(firstName, lastName), topic)
    {}

    #region Implementation of IAssignment

    /// <summary>
    /// Gets the name of the student.
    /// </summary>
    /// <value>The name of the student.</value>
    public IStudent StudentName { get; } = studentName;

    /// <summary>
    /// Gets the topic.
    /// </summary>
    /// <value>The topic.</value>
    public string Topic { get; } = topic;

    /// <summary>
    /// Gets the summary.
    /// </summary>
    /// <returns>System.String.</returns>
    /// <exception cref="System.NotImplementedException"></exception>
    public string GetSummary()
        => $"{StudentName} - {Topic}";



    #endregion
}