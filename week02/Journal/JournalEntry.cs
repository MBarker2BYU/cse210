// ***********************************************************************
// Assembly        : Journal
// Author            : Matthew D. Barker
// Created           : 03-05-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-16-2025
// ***********************************************************************
// <copyright file="JournalEntry.cs" company="Journal">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Globalization;
using Journal.Interfaces;
using Newtonsoft.Json;

using static SpartanSystems.Utilities;

namespace Journal;

/// <summary>
/// Class JournalEntry.
/// Implements the <see cref="IJournalEntry" />
/// </summary>
/// <seealso cref="IJournalEntry" />
public class JournalEntry : IJournalEntry
{
    #region Implementation of IJournalEntry

    /// <summary>
    /// Gets the date.
    /// </summary>
    /// <value>The date.</value>
    [JsonProperty]
    public string Date { get; } = DateTime.Now.ToString(CultureInfo.InvariantCulture);
    /// <summary>
    /// Gets the prompt text.
    /// </summary>
    /// <value>The prompt text.</value>
    [JsonProperty]
    public string PromptText { get; protected set; }
    /// <summary>
    /// Gets or sets the entry text.
    /// </summary>
    /// <value>The entry text.</value>
    public string EntryText { get; set; }
    /// <summary>
    /// Displays this instance.
    /// </summary>
    /// <exception cref="System.NotImplementedException"></exception>
    public void Display()
    {
        WriteLinePlus($"Date: {Date}", spacingAfter: 0);
        WriteLinePlus($"Prompt: {PromptText}", spacingAfter: 0);
        WriteLinePlus($"Entry: {EntryText}");
    }

    #endregion
}