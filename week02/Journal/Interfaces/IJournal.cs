// ***********************************************************************
// Assembly        : Journal
// Author            : Matthew D. Barker
// Created           : 03-05-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-13-2025
// ***********************************************************************
// <copyright file="IJournal.cs" company="Journal">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Journal.Interfaces;

/// <summary>
/// Interface IJournal
/// </summary>
public interface IJournal
{
    /// <summary>
    /// Adds the entry.
    /// </summary>
    /// <param name="entry">The entry.</param>
    public void AddEntry(IJournalEntry entry);

    /// <summary>
    /// Creates new journal entry Interface. 
    /// </summary>
    /// <returns>IJournalEntry.</returns>
    public IJournalEntry NewJournalEntry();

    /// <summary>
    /// Saves to file.
    /// </summary>
    /// <param name="filename">The filename.</param>
    /// <param name="exception">The exception.</param>
    /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
    public bool SaveToFile(string filename, out Exception exception);
    /// <summary>
    /// Loads from file.
    /// </summary>
    /// <param name="filename">The filename.</param>
    /// <param name="exception">The exception.</param>
    /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
    public bool LoadFromFile(string filename, out Exception exception);
    /// <summary>
    /// Displays all.
    /// </summary>
    public void DisplayAll();
}