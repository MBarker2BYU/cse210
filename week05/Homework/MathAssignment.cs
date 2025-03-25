// ***********************************************************************
// Assembly        : Homework
// Author            : Matthew D. Barker
// Created           : 03-25-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-25-2025
// ***********************************************************************
// <copyright file="MathAssignment.cs" company="Homework">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Text;
using Homework.Interfaces;

namespace Homework;

/// <summary>
/// Class MathAssignment.
/// Implements the <see cref="Homework.Assignment" />
/// Implements the <see cref="IMathAssignment" />
/// </summary>
/// <param name="studentName">Name of the student.</param>
/// <param name="topic">The topic.</param>
/// <param name="textbookSection">The textbook section.</param>
/// <param name="problems">The problem.</param>
/// <seealso cref="Homework.Assignment" />
/// <seealso cref="IMathAssignment" />
public class MathAssignment(IStudent studentName, string topic, string textbookSection, string problems) : Assignment(studentName, topic), IMathAssignment
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MathAssignment"/> class.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <param name="topic">The topic.</param>
    /// <param name="textbookSection">The textbook section.</param>
    /// <param name="problems">The problem.</param>
    public MathAssignment(string name, string topic, string textbookSection, string problems) : this(new Student(name), topic, textbookSection, problems )
    { }

    /// <summary>
    /// Initializes a new instance of the <see cref="MathAssignment"/> class.
    /// </summary>
    /// <param name="firstName">The first name.</param>
    /// <param name="lastName">The last name.</param>
    /// <param name="topic">The topic.</param>
    /// <param name="textbookSection">The textbook section.</param>
    /// <param name="problems">The problem.</param>
    public MathAssignment(string firstName, string lastName, string topic, string textbookSection, string problems) : this(new Student(firstName, lastName), topic, textbookSection, problems)
    { }
    
    #region Implementation of IMathAssignment

    /// <summary>
    /// Gets the textbook section.
    /// </summary>
    /// <value>The textbook section.</value>
    public string TextbookSection { get; } = textbookSection;

    /// <summary>
    /// Gets the problems.
    /// </summary>
    /// <value>The problems.</value>
    public string Problems { get; } = problems;

    /// <summary>
    /// Gets the homework list.
    /// </summary>
    /// <returns>System.String.</returns>
    /// <exception cref="System.NotImplementedException"></exception>
    public string GetHomeworkList()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"Section {TextbookSection} Problems {Problems}");
        
        return sb.ToString();
    }

    #endregion
}