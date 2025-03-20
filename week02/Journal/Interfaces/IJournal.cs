// ***********************************************************************
// Assembly         : Journal
// Author           : Matthew D. Barker
// Created          : 03-05-2025
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
    /// <param name="journalEntry">The journal entry.</param>
    /// <param name="exception">The exception.</param>
    /// <returns><c>true</c> if the journal entry is added successfully, <c>false</c> otherwise.</returns>
    public bool AddEntry(IJournalEntry journalEntry, out Exception exception);

    /// <summary>
    /// Creates new journal entry.
    /// </summary>
    /// <returns>IJournalEntry.</returns>
    public IJournalEntry NewJournalEntry();

    /// <summary>
    /// Displays all.
    /// </summary>
    /// <param name="exception">The exception.</param>
    /// <returns><c>true</c> if the entries are display successfully, <c>false</c> otherwise.</returns>
    public bool DisplayAll(out Exception exception);
    
    /// <summary>
    /// Loads from file.
    /// </summary>
    /// <param name="filename">The filename.</param>
    /// <param name="exception">The exception.</param>
    /// <returns><c>true</c> if file is loaded successfully , <c>false</c> otherwise.</returns>
    public bool LoadFromFile(string filename, out Exception exception);

    /// <summary>
    /// Saves to file.
    /// </summary>
    /// <param name="filename">The filename.</param>
    /// <param name="exception">The exception.</param>
    /// <returns><c>true</c> if file is saved successfully, <c>false</c> otherwise.</returns>
    public bool SaveToFile(string filename, out Exception exception);
}