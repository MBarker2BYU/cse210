// ***********************************************************************
// Assembly        : Journal
// Author            : Matthew D. Barker
// Created           : 03-05-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-13-2025
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
    /// Gets the timestamp.
    /// </summary>
    /// <value>The timestamp.</value>
    public DateTime Timestamp { get; }

    /// <summary>
    /// Gets the prompt.
    /// </summary>
    /// <value>The prompt.</value>
    public string Prompt { get; }

    /// <summary>
    /// Gets or sets the response.
    /// </summary>
    /// <value>The response.</value>
    public string Response { get; set; }

    /// <summary>
    /// Displays this instance.
    /// </summary>
    public void Display();
}