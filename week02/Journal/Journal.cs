// ***********************************************************************
// Assembly        : Journal
// Author            : Matthew D. Barker
// Created           : 03-05-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-16-2025
// ***********************************************************************
// <copyright file="Journal.cs" company="Journal">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Journal.ExtensionMethods;
using Journal.Interfaces;
using Newtonsoft.Json;
using SpartanSystems.Extensions;

namespace Journal;

/// <summary>
/// Class Journal.
/// Implements the <see cref="IJournal" />
/// </summary>
/// <seealso cref="IJournal" />
public class Journal : IJournal
{
    #region Methods

    /// <summary>
    /// Adds the entry.
    /// </summary>
    /// <param name="journalEntry">The journal entry.</param>
    /// <param name="exception">The exception.</param>
    /// <returns><c>true</c> if the journal entry is added successfully, <c>false</c> otherwise.</returns>
    public bool AddEntry(IJournalEntry journalEntry, out Exception? exception)
    {
        exception = null;

        try
        {
            m_JournalEntries.Add((JournalEntry)journalEntry);

            return true;
        }
        catch (Exception ex)
        {
            exception = ex;
            return false;
        }

    }

    /// <summary>
    /// Displays all.
    /// </summary>
    /// <param name="exception">The exception.</param>
    /// <returns><c>true</c> if journal entries are displayed successfully, <c>false</c> otherwise.</returns>
    public bool DisplayAll(out Exception? exception)
    {
        exception = null;

        try
        {
            foreach (var journalEntry in m_JournalEntries)
            {
                journalEntry.Display();
            }

            return true;
        }
        catch (Exception ex)
        {
            exception = ex;
            return false;
        }

    }

    /// <summary>
    /// Merges the specified journal.
    /// </summary>
    /// <param name="journal">The journal.</param>
    /// <param name="exception">The exception.</param>
    /// <returns><c>true</c> if the entries are merged successfully, <c>false</c> otherwise.</returns>
    public bool Merge(Journal journal, out Exception? exception)
    {
        exception = null;

        try
        {
            foreach (var entry in journal.m_JournalEntries)
            {
                m_JournalEntries.Add(entry);
            }

            return true;
        }
        catch (Exception ex)
        {
            exception = ex;
            return false;
        }

    }

    /// <summary>
    /// Creates new journal entry.
    /// </summary>
    /// <returns>IJournalEntry.</returns>
    public IJournalEntry NewJournalEntry()
        => new HiddenJournalEntry(m_PromptGenerator.NextPrompt());

    #endregion

    #region Properties

    /// <summary>
    /// The m journal entries
    /// </summary>
    [JsonProperty]
    private readonly List<JournalEntry> m_JournalEntries = new();

    /// <summary>
    /// The m prompt generator
    /// </summary>
    private readonly IPromptGenerator m_PromptGenerator = new PromptGenerator();

    #endregion

    /// <summary>
    /// Class HiddenJournalEntry.
    /// Implements the <see cref="JournalEntry" />
    /// </summary>
    /// <seealso cref="JournalEntry" />
    private class HiddenJournalEntry : JournalEntry
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HiddenJournalEntry"/> class.
        /// </summary>
        /// <param name="prompt">The prompt.</param>
        public HiddenJournalEntry(string prompt)
        {
            base.PromptText = prompt;
        }
    }
}