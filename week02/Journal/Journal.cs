// ***********************************************************************
// Assembly        : Journal
// Author            : Matthew D. Barker
// Created           : 03-05-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-13-2025
// ***********************************************************************
// <copyright file="Journal.cs" company="Journal">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Journal.Interfaces;
using Newtonsoft.Json;

namespace Journal;

/// <summary>
/// Class Journal.
/// Implements the <see cref="IJournal" />
/// </summary>
/// <seealso cref="IJournal" />
public class Journal : IJournal
{
    /// <summary>
    /// The m prompt generator
    /// </summary>
    private readonly PromptGenerator m_PromptGenerator = new PromptGenerator();

    /// <summary>
    /// The entries
    /// </summary>
    [JsonProperty]
    private List<JournalEntry> _entries = [];

    /// <summary>
    /// Adds the entry.
    /// </summary>
    /// <param name="journalEntry">The journal entry.</param>
    /// <param name="exception">The exception.</param>
    /// <returns><c>true</c> if the journal entry is added successfully, <c>false</c> otherwise.</returns>
    public bool AddEntry(IJournalEntry journalEntry, out Exception exception)
    {
        exception = default!;
        
        try
        {
            
            _entries.Add((JournalEntry)journalEntry);

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
        => new JournalEntry(m_PromptGenerator.NextPrompt());

    /// <summary>
    /// Displays all.
    /// </summary>
    /// <param name="exception">The exception.</param>
    /// <returns><c>true</c> if the entries are display successfully, <c>false</c> otherwise.</returns>
    public bool DisplayAll(out Exception exception)
    {
        exception = default!;
        
        try
        {
            foreach (var entry in _entries) 
                entry.Display();

            return true;
        }
        catch (Exception ex)
        {
            exception = ex;
            return false;
        }
        
    }

    /// <summary>
    /// Loads from file.
    /// </summary>
    /// <param name="filename">The filename.</param>
    /// <param name="exception">The exception.</param>
    /// <returns><c>true</c> if file is loaded successfully , <c>false</c> otherwise.</returns>
    /// <exception cref="System.ArgumentException">Filename cannot be null or empty. - filename</exception>
    /// <exception cref="System.IO.FileNotFoundException">The specified file does not exist.</exception>
    public bool LoadFromFile(string filename, out Exception exception)
    {
        exception = default!;
        
        try
        {
            if (string.IsNullOrWhiteSpace(filename))
                throw new ArgumentException("Filename cannot be null or empty.", nameof(filename));

            filename = $"{filename}.json";

            if (!File.Exists(filename))
                throw new FileNotFoundException("The specified file does not exist.", filename);

            var json = File.ReadAllText(filename);
            _entries = JsonConvert.DeserializeObject<List<JournalEntry>>(json) ?? new List<JournalEntry>();

            return true;
        }
        catch (Exception ex)
        {
            exception = ex;
            return false;
        }
    }

    /// <summary>
    /// Saves to file.
    /// </summary>
    /// <param name="filename">The filename.</param>
    /// <param name="exception">The exception.</param>
    /// <returns><c>true</c> if file is saved successfully, <c>false</c> otherwise.</returns>
    /// <exception cref="System.ArgumentException">Filename cannot be null or empty. - filename</exception>
    public bool SaveToFile(string filename, out Exception exception)
    {
        exception = default!;

        try
        {
            if (string.IsNullOrWhiteSpace(filename))
                throw new ArgumentException("Filename cannot be null or empty.", nameof(filename));

            filename = $"{filename}.json";

            var json = JsonConvert.SerializeObject(_entries, Formatting.Indented);
            File.WriteAllText(filename, json);

            return true;
        }
        catch (Exception ex)
        {
            exception = ex;
            return false;
        }
    }

}