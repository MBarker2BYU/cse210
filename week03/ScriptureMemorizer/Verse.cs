// ***********************************************************************
// Assembly        : ScriptureMemorizer
// Author            : Matthew D. Barker
// Created           : 03-20-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-20-2025
// ***********************************************************************
// <copyright file="Verse.cs" company="ScriptureMemorizer">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace ScriptureMemorizer;

/// <summary>
/// Class Verse.
/// </summary>
/// <param name="start">The start.</param>
/// <param name="end">The end.</param>
public class Verse(int start, int? end = null)
{
    /// <summary>
    /// Gets the start.
    /// </summary>
    /// <value>The start.</value>
    public int Start {get;} = start;

    /// <summary>
    /// Gets the end.
    /// </summary>
    /// <value>The end.</value>
    public int? End {get;} = end;

    /// <summary>
    /// Returns a <see cref="System.String" /> that represents this instance.
    /// </summary>
    /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
    public override string ToString()
    {
        return End != null ? $"{Start}-{End}" : $"{Start}";
    }
}