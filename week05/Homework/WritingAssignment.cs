// ***********************************************************************
// Assembly        : Homework
// Author            : Matthew D. Barker
// Created           : 03-25-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-25-2025
// ***********************************************************************
// <copyright file="WritingAssignment.cs" company="Homework">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Homework.Interfaces;

namespace Homework;

/// <summary>
/// Class WritingAssignment.
/// Implements the <see cref="Homework.Assignment" />
/// Implements the <see cref="IWritingAssignment" />
/// </summary>
/// <param name="studentName">Name of the student.</param>
/// <param name="topic">The topic.</param>
/// <param name="title">The title.</param>
/// <seealso cref="Homework.Assignment" />
/// <seealso cref="IWritingAssignment" />
public class WritingAssignment(IStudent studentName, string topic, string title) : Assignment(studentName, topic), IWritingAssignment
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WritingAssignment"/> class.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <param name="topic">The topic.</param>
    /// <param name="title">The title.</param>
    public WritingAssignment(string name, string topic, string title) : this(new Student(name), topic, title)
    {}

    /// <summary>
    /// Initializes a new instance of the <see cref="WritingAssignment"/> class.
    /// </summary>
    /// <param name="firstName">The first name.</param>
    /// <param name="lastName">The last name.</param>
    /// <param name="topic">The topic.</param>
    /// <param name="title">The title.</param>
    public WritingAssignment(string firstName, string lastName, string topic, string title) : this(new Student(firstName, lastName), topic, title)
    { }

    #region Implementation of IWritingAssignment

    /// <summary>
    /// Gets the title.
    /// </summary>
    /// <value>The title.</value>
    public string Title { get; } = title;

    /// <summary>
    /// Gets the writing information.
    /// </summary>
    /// <returns>System.String.</returns>
    /// <exception cref="System.NotImplementedException"></exception>
    public string GetWritingInformation()
    {
        return $"{Title} by {StudentName}";
    }

    #endregion
}