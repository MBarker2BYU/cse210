// ***********************************************************************
// Assembly        : Journal
// Author            : Matthew D. Barker
// Created           : 03-05-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-16-2025
// ***********************************************************************
// <copyright file="IJournal.cs" company="Journal2">
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
    /// <param name="journalEntry"></param>
    /// <param name="exception">The exception.</param>
    /// <returns><c>true</c> if the journal entry is added successfully, <c>false</c> otherwise.</returns>
    public bool AddEntry(IJournalEntry journalEntry, out Exception? exception);

    /// <summary>
    /// Displays all.
    /// </summary>
    /// <param name="exception">The exception.</param>
    /// <returns><c>true</c> if journal entries are displayed successfully, <c>false</c> otherwise.</returns>
    public bool DisplayAll(out Exception? exception);

    /// <summary>
    /// Merges the specified journal.
    /// </summary>
    /// <param name="journal">The journal.</param>
    /// <param name="exception">The exception.</param>
    /// <returns><c>true</c> if the entries are merged successfully, <c>false</c> otherwise.</returns>
    public bool Merge(Journal journal, out Exception? exception);

    /// <summary>
    /// Creates new journal entry.
    /// </summary>
    /// <returns>IJournalEntry.</returns>
    public IJournalEntry NewJournalEntry();
}