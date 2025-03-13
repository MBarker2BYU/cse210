// ***********************************************************************
// Assembly        : Journal
// Author            : Matthew D. Barker
// Created           : 03-05-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-10-2025
// ***********************************************************************
// <copyright file="JournalEntry.cs" company="Journal">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Globalization;
using Journal.Interfaces;

namespace Journal;

/// <summary>
/// Class JournalEntry.
/// Implements the <see cref="IJournalEntry" />
/// </summary>
/// <param name="promptText">The prompt text.</param>
/// <seealso cref="IJournalEntry" />
public class JournalEntry(string promptText) : IJournalEntry
{
    #region Overrides of DisplayBase

    /// <summary>
    /// Displays this instance.
    /// </summary>
    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {PromptText}");
        Console.WriteLine($"Entry: {EntryText}");
    }

    #endregion

    #region Implementation of IEntry

    /// <summary>
    /// Gets the date.
    /// </summary>
    /// <value>The date.</value>
    public string Date { get; } = DateTime.Now.ToString(CultureInfo.InvariantCulture);
    /// <summary>
    /// Gets the prompt text.
    /// </summary>
    /// <value>The prompt text.</value>
    public string PromptText { get; } = promptText;
    /// <summary>
    /// Gets or sets the entry text.
    /// </summary>
    /// <value>The entry text.</value>
    public string EntryText { get; set; }

    #endregion
}