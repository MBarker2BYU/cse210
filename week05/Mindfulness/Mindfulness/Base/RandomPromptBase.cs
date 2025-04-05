// ***********************************************************************
// Assembly         : Mindfulness
// Author           : Matthew D. Barker
// Created          : 03-30-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 04-05-2025
// ***********************************************************************
// <copyright file="RandomPromptBase.cs" company="Mindfulness">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Mindfulness.Interfaces;

namespace Mindfulness.Base;

/// <summary>
/// Class RandomPromptBase.
/// Implements the <see>
///     <cref>Mindfulness.Base.ActivityBase</cref>
/// </see>
/// </summary>
/// <param name="name">The name.</param>
/// <param name="description">The description.</param>
/// <seealso>
///     <cref>Mindfulness.Base.ActivityBase</cref>
/// </seealso>
public abstract class RandomPromptBase(string name, string description) : ActivityBase(name, description)
{

    /// <summary>
    /// The prompts
    /// </summary>
    protected readonly IPrompts _Prompts = new Prompts();

    /// <summary>
    /// The m random
    /// </summary>
    protected readonly Random _Random = new();
}