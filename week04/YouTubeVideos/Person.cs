// ***********************************************************************
// Assembly        : YouTubeVideos
// Author            : Matthew D. Barker
// Created           : 03-24-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-24-2025
// ***********************************************************************
// <copyright file="Person.cs" company="YouTubeVideos">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using YouTubeVideos.Interfaces;

namespace YouTubeVideos;

/// <summary>
/// Class Person.
/// Implements the <see cref="IPerson" />
/// </summary>
/// <seealso cref="IPerson" />
public class Person : IPerson
{

    /// <summary>
    /// Initializes a new instance of the <see cref="Person"/> class.
    /// </summary>
    public Person()
    {}

    /// <summary>
    /// Initializes a new instance of the <see cref="Person"/> class.
    /// </summary>
    /// <param name="firstName">The first name.</param>
    /// <param name="lastName">The last name.</param>
    internal Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    #region Implementation of IDisplay

    /// <summary>
    /// Displays this instance.
    /// </summary>
    public void Display()
    {
        Console.WriteLine(ToString());
    }

    #endregion

    #region Implementation of IPerson

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
    {
        return $"{FirstName} {LastName}";
    }

    #endregion
}