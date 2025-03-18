// ***********************************************************************
// Assembly        : Journal
// Author            : Matthew D. Barker
// Created           : 03-13-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-16-2025
// ***********************************************************************
// <copyright file="Program.cs" company="Journal">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Journal.Managers;
using SpartanSystems.Extensions;

using static SpartanSystems.Utilities;

namespace Journal;

/// <summary>
/// Class Program.
/// </summary>
class Program
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    /// <param name="args">The arguments.</param>
    static void Main(string[] args)
    {
        try
        {
            var journalManager = new JournalManager();
            if (!journalManager.Run(out Exception? exception))
                exception.ThrowIfNotNull();
        }
        catch (Exception ex)
        {
            WriteLinePlus($"Exception: {ex.Message}", pressEnterToContinue: true);
        }
    }
}