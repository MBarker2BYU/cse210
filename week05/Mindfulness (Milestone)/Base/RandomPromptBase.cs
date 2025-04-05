// ***********************************************************************
// Assembly        : Mindfulness
// Author            : Matthew D. Barker
// Created           : 03-30-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-30-2025
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
/// Implements the <see cref="ActivityBase" />
/// Implements the <see cref="IRandomPromptBase" />
/// </summary>
/// <param name="name">The name.</param>
/// <param name="description">The description.</param>
/// <seealso cref="ActivityBase" />
/// <seealso cref="IRandomPromptBase" />
public abstract class RandomPromptBase(string name, string description) : ActivityBase(name, description), IRandomPromptBase
{
    /// <summary>
    /// Gets the random prompt.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="prompt">The prompt.</param>
    /// <param name="exception">The exception.</param>
    /// <returns><c>true</c> if a random prompt is returned successfully, <c>false</c> otherwise.</returns>
    protected virtual bool GetRandomPrompt<T>(out T prompt, out Exception exception) where T : IPrompt
    {
        prompt = default;
        exception = default;

        try
        {



            return true;
        }
        catch (Exception ex)
        {
            exception = ex;
            return false;
        }
    }

    protected readonly IPrompts Prompts = new Prompts();

}