// ***********************************************************************
// Assembly        : Journal2
// Author            : Matthew D. Barker
// Created           : 03-14-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-16-2025
// ***********************************************************************
// <copyright file="IJournalManager.cs" company="Journal2">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Journal.Managers.Interfaces;

/// <summary>
/// Interface IJournalManager
/// </summary>
public interface IJournalManager
{
    /// <summary>
    /// Runs the specified exception.
    /// </summary>
    /// <param name="exception">The exception.</param>
    /// <returns><c>true</c> if the manager executes and returns properly, <c>false</c> otherwise.</returns>
    public bool Run(out Exception? exception);
}