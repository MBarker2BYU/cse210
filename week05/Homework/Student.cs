// ***********************************************************************
// Assembly        : Homework
// Author            : Matthew D. Barker
// Created           : 03-25-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-25-2025
// ***********************************************************************
// <copyright file="Student.cs" company="Homework">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Homework.Interfaces;

namespace Homework;

/// <summary>
/// Class Student.
/// Implements the <see cref="IStudent" />
/// </summary>
/// <param name="firstName">The first name.</param>
/// <param name="lastName">The last name.</param>
/// <seealso cref="IStudent" />
public class Student(string firstName, string lastName) : IStudent
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Student"/> class.
    /// </summary>
    /// <param name="name">The name.</param>
    public Student(string name) : this(ParseName(name))
    {}

    /// <summary>
    /// Initializes a new instance of the <see cref="Student"/> class.
    /// </summary>
    /// <param name="name">The name.</param>
    public Student((string firstName, string lastName) name) : this(name.firstName, name.lastName)
    {}

    /// <summary>
    /// Parses the name.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <returns>System.ValueTuple&lt;System.String, System.String&gt;.</returns>
    private static (string firstName, string lastName) ParseName(string name)
    {
        var nameParts = name.Split(' ');
        return nameParts.Length == 2 ? (nameParts[0], nameParts[1]) : (nameParts[0], string.Empty);
    }

    #region Implementation of IStudent

    /// <summary>
    /// Gets the first name.
    /// </summary>
    /// <value>The first name.</value>
    public string FirstName { get; } = firstName;
    /// <summary>
    /// Gets the last name.
    /// </summary>
    /// <value>The last name.</value>
    public string LastName { get; } = lastName;

    #endregion

    #region Overrides of Object

    /// <summary>
    /// Returns a <see>
    ///     <cref>System.String</cref>
    /// </see>
    /// that represents this instance.
    /// </summary>
    /// <returns>A <see>
    ///         <cref>System.String</cref>
    ///     </see>
    ///     that represents this instance.</returns>
    public override string ToString()
        => $"{FirstName} {LastName}";


    #endregion
}