// ***********************************************************************
// Assembly        : YouTubeVideos
// Author            : Matthew D. Barker
// Created           : 03-24-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-24-2025
// ***********************************************************************
// <copyright file="Comment.cs" company="YouTubeVideos">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Text;
using YouTubeVideos.Interfaces;

namespace YouTubeVideos;

/// <summary>
/// Class Comment.
/// Implements the <see cref="IComment" />
/// </summary>
/// <seealso cref="IComment" />
public class Comment : IComment
{
    private const char STAR_SYMBOL = '*';
    
    /// <summary>
    /// Initializes a new instance of the <see cref="Comment"/> class.
    /// </summary>
    public Comment()
    {}

    /// <summary>
    /// Initializes a new instance of the <see cref="Comment"/> class.
    /// </summary>
    /// <param name="person">The person.</param>
    /// <param name="text">The text.</param>
    /// <param name="stars"></param>
    internal Comment(IPerson person, string text, byte stars = 5)
    {
        Person = person;
        Text = text;
        Stars = stars;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Comment"/> class.
    /// </summary>
    /// <param name="firstName">The first name.</param>
    /// <param name="lastName">The last name.</param>
    /// <param name="text">The text.</param>
    /// <param name="stars"></param>
    internal Comment(string firstName, string lastName, string text, byte stars = 5)
    {
        Person = new Person(firstName, lastName);
        Text = text;
        Stars = stars;
    }

    #region Implementation of IDisplay

    /// <summary>
    /// Displays this instance.
    /// </summary>
    public void Display()
    {
        Console.WriteLine($"\tName: {Person, -55} Rating: \u001b[33m{new string(STAR_SYMBOL, Stars)}\u001b[0m");
        Console.WriteLine($"\tComment: {Text}");
        Console.WriteLine();
    }
    
    #endregion

    #region Implementation of IComment

    /// <summary>
    /// Gets the person.
    /// </summary>
    /// <value>The person.</value>
    public IPerson Person { get; }
    /// <summary>
    /// Gets the text.
    /// </summary>
    /// <value>The text.</value>
    public string Text { get; }

    /// <summary>
    /// Gets the stars.
    /// </summary>
    /// <value>The stars.</value>
    public byte Stars { get; }

    #endregion
}