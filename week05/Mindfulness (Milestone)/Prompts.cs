// ***********************************************************************
// Assembly        : Mindfulness
// Author            : Matthew D. Barker
// Created           : 03-31-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-31-2025
// ***********************************************************************
// <copyright file="Prompts.cs" company="Mindfulness">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Mindfulness.Interfaces;

namespace Mindfulness;

/// <summary>
/// Class Prompts.
/// Implements the <see>
///     <cref>System.Collections.Generic.List{Mindfulness.Interfaces.IPrompt}</cref>
/// </see>
/// Implements the <see cref="IPrompts" />
/// </summary>
/// <seealso>
///     <cref>System.Collections.Generic.List{Mindfulness.Interfaces.IPrompt}</cref>
/// </seealso>
/// <seealso cref="IPrompts" />
public class Prompts : List<IPrompt>, IPrompts
{
    /// <summary>
    /// Resets this instance.
    /// </summary>
    public void Reset()
    {
        foreach (var prompt in this)
            prompt.Reset();
    }

    /// <summary>
    /// Gets a value indicating whether [all marked used].
    /// </summary>
    /// <value><c>true</c> if [all marked used]; otherwise, <c>false</c>.</value>
    public bool AllMarkedUsed
        => this.All(prompt => prompt.hasBeenMarkedUsed);
}