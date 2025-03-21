// ***********************************************************************
// Assembly        : ScriptureMemorizer
// Author            : Matthew D. Barker
// Created           : 03-20-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-20-2025
// ***********************************************************************
// <copyright file="ScriptureReference.cs" company="ScriptureMemorizer">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace ScriptureMemorizer;

/// <summary>
/// Class ScriptureReference.
/// </summary>
/// <param name="book">The book.</param>
/// <param name="chapter">The chapter.</param>
/// <param name="verse">The verse.</param>
public class ScriptureReference(string book, int chapter, Verse verse)
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ScriptureReference"/> class.
    /// </summary>
    /// <param name="book">The book.</param>
    /// <param name="chapter">The chapter.</param>
    /// <param name="start">The start.</param>
    /// <param name="end">The end.</param>
    public ScriptureReference(string book, int chapter, int start, int? end = null) : this(book, chapter, new Verse(start, end))
    {}

    /// <summary>
    /// Gets the book.
    /// </summary>
    /// <value>The book.</value>
    public string Book {get;} = book;

    /// <summary>
    /// Gets the chapter.
    /// </summary>
    /// <value>The chapter.</value>
    public int Chapter {get;} = chapter;

    /// <summary>
    /// Gets the verse.
    /// </summary>
    /// <value>The verse.</value>
    public Verse Verse {get;} = verse;

    public string Display()
        => $"{Book} {Chapter}:{Verse}";
}