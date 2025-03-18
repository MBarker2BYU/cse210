// ***********************************************************************
// Assembly        : Journal
// Author            : Matthew D. Barker
// Created           : 03-05-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-16-2025
// ***********************************************************************
// <copyright file="IJournalEntry.cs" company="Journal">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Journal.Interfaces;

/// <summary>
/// Interface IJournalEntry
/// </summary>
public interface IJournalEntry
{
    /// <summary>
    /// Gets the date.
    /// </summary>
    /// <value>The date.</value>
    public string Date { get; }
    /// <summary>
    /// Gets the prompt text.
    /// </summary>
    /// <value>The prompt text.</value>
    public string PromptText { get; }
    /// <summary>
    /// Gets or sets the entry text.
    /// </summary>
    /// <value>The entry text.</value>
    public string EntryText { get; set; }
    /// <summary>
    /// Displays this instance.
    /// </summary>
    public void Display();
}