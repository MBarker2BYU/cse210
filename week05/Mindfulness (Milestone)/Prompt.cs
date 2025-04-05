// ***********************************************************************
// Assembly        : Mindfulness
// Author            : Matthew D. Barker
// Created           : 03-31-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-31-2025
// ***********************************************************************
// <copyright file="Prompt.cs" company="Mindfulness">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Mindfulness.Interfaces;

namespace Mindfulness;

/// <summary>
/// Class Prompt.
/// Implements the <see cref="IPrompt" />
/// </summary>
/// <param name="text">The text.</param>
/// <seealso cref="IPrompt" />
public class Prompt(string text) : IPrompt
{
    #region Implementation of IPrompt

    /// <summary>
    /// Resets this instance.
    /// </summary>
    public void Reset()
    {
        hasBeenMarkedUsed = false;
    }

    /// <summary>
    /// Marks as used.
    /// </summary>
    public void MarkAsUsed()
        => hasBeenMarkedUsed = true;

    /// <summary>
    /// Gets a value indicating whether this instance has been marked used.
    /// </summary>
    /// <value><c>true</c> if this instance has been marked used; otherwise, <c>false</c>.</value>
    public bool hasBeenMarkedUsed { get; private set; }

    /// <summary>
    /// Gets the text.
    /// </summary>
    /// <value>The text.</value>
    public string Text { get; } = text;

    #endregion
}