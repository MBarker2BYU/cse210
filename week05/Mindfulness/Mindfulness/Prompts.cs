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

    /// <summary>
    /// Gets the random prompt.
    /// </summary>
    /// <param name="random">The random.</param>
    /// <param name="prompt">The prompt.</param>
    /// <param name="exception">The exception.</param>
    /// <returns><c>true</c> if a random prompt is returned, <c>false</c> otherwise.</returns>
    /// <exception cref="System.InvalidOperationException">No prompts available.</exception>
    /// <exception cref="System.ArgumentNullException">random - Random instance cannot be null.</exception>
    public bool GetRandomPrompt(Random random, out IPrompt prompt, out Exception exception)
    {
        prompt = default!;
        exception = default!;

        try
        {
            if(Count == 0)
                throw new InvalidOperationException("No prompts available.");

            if(random == null)
                throw new ArgumentNullException(nameof(random), "Random instance cannot be null.");

            if(AllMarkedUsed)
                throw new InvalidOperationException("All prompts have been used. Please reset the prompts.");

            while (true)
            {
                prompt = this[random.Next(0, Count)];
                
                if(prompt.hasBeenMarkedUsed)
                    continue;

                ((Prompt)prompt).MarkAsUsed();

                break;
            }

            return true;
        }
        catch (Exception ex)
        {
            exception = ex;
            return false;
        }
    }

}