// ***********************************************************************
// Assembly        : Mindfulness
// Author            : Matthew D. Barker
// Created           : 03-31-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-31-2025
// ***********************************************************************
// <copyright file="IPrompts.cs" company="Mindfulness">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mindfulness.Interfaces;

/// <summary>
/// Interface IPrompts
/// Extends the <see cref="System.Collections.Generic.IList{Mindfulness.Interfaces.IPrompt}" />
/// </summary>
/// <seealso cref="System.Collections.Generic.IList{Mindfulness.Interfaces.IPrompt}" />
public interface IPrompts : IList<IPrompt>
{
    /// <summary>
    /// Resets this instance.
    /// </summary>
    public void Reset();

    /// <summary>
    /// Gets a value indicating whether [all marked used].
    /// </summary>
    /// <value><c>true</c> if [all marked used]; otherwise, <c>false</c>.</value>
    public bool AllMarkedUsed { get; }
}