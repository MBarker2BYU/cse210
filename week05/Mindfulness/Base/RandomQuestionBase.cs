// ***********************************************************************
// Assembly        : Mindfulness
// Author            : Matthew D. Barker
// Created           : 04-05-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 04-05-2025
// ***********************************************************************
// <copyright file="RandomQuestionBase.cs" company="Mindfulness">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Mindfulness.Interfaces;

namespace Mindfulness.Base;

/// <summary>
/// Class RandomQuestionBase.
/// Implements the <see cref="Mindfulness.Base.RandomPromptBase" />
/// </summary>
/// <param name="name">The name.</param>
/// <param name="description">The description.</param>
/// <seealso cref="Mindfulness.Base.RandomPromptBase" />
public abstract class RandomQuestionBase(string name, string description) : RandomPromptBase(name, description)
{
    /// <summary>
    /// The questions
    /// </summary>
    protected readonly IPrompts _Questions = new Prompts();
    
}