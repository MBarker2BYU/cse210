// ***********************************************************************
// Assembly        : Journal
// Author            : Matthew D. Barker
// Created           : 03-05-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-13-2025
// ***********************************************************************
// <copyright file="JournalEntry.cs" company="Journal">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Journal.Interfaces;

namespace Journal;

/// <summary>
/// Class JournalEntry.
/// Implements the <see cref="IJournalEntry" />
/// </summary>
/// <param name="prompt">The prompt.</param>
/// <seealso cref="IJournalEntry" />
public class JournalEntry(string prompt) : IJournalEntry
{
    /// <summary>
    /// Gets the timestamp.
    /// </summary>
    /// <value>The timestamp.</value>
    public DateTime Timestamp { get; } = DateTime.Now;

    /// <summary>
    /// Gets the prompt.
    /// </summary>
    /// <value>The prompt.</value>
    public string Prompt { get; init; } = prompt;

    /// <summary>
    /// Gets or sets the response.
    /// </summary>
    /// <value>The response.</value>
    public string Response { get; set; }

    /// <summary>
    /// Displays this instance.
    /// </summary>
    public void Display()
    {
        Console.WriteLine($"Journal Entry: {Timestamp}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine();
    }
}