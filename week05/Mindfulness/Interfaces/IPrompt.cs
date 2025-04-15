// ***********************************************************************
// Assembly        : Mindfulness
// Author            : Matthew D. Barker
// Created           : 03-30-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-31-2025
// ***********************************************************************
// <copyright file="IPrompt.cs" company="Mindfulness">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mindfulness.Interfaces;

/// <summary>
/// Interface IPrompt
/// </summary>
public interface IPrompt
{
    /// <summary>
    /// Resets this instance.
    /// </summary>
    public void Reset();

    /// <summary>
    /// Marks as used.
    /// </summary>
    public void MarkAsUsed();

    /// <summary>
    /// Gets a value indicating whether this instance has been marked used.
    /// </summary>
    /// <value><c>true</c> if this instance has been marked used; otherwise, <c>false</c>.</value>
    public bool hasBeenMarkedUsed { get; }

    /// <summary>
    /// Gets the text.
    /// </summary>
    /// <value>The text.</value>
    public string Text { get; }
}