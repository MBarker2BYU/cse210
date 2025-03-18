// ***********************************************************************
// Assembly        : Journal
// Author            : Matthew D. Barker
// Created           : 03-05-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-16-2025
// ***********************************************************************
// <copyright file="PromptGenerator.cs" company="Journal">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Journal.Interfaces;

namespace Journal;

/// <summary>
/// Class PromptGenerator.
/// Implements the <see cref="IPromptGenerator" />
/// </summary>
/// <seealso cref="IPromptGenerator" />
public class PromptGenerator : IPromptGenerator
{
    #region Implementation of IPromptGenerator

    /// <summary>
    /// Returns the next random prompt.
    /// </summary>
    /// <returns>System.String.</returns>
    /// <exception cref="System.InvalidOperationException">No prompts available to select from.</exception>
    public string NextPrompt()
    {
        if (m_Prompts == null || m_Prompts.Count == 0) throw new InvalidOperationException("No prompts available to select from.");

        var index = m_Random.Next(m_Prompts.Count);
        return m_Prompts[index];
    }

    #endregion

    #region Properties

    /// <summary>
    /// The m random
    /// </summary>
    private readonly Random m_Random = new();

    /// <summary>
    /// Gets the m prompts.
    /// </summary>
    /// <value>The m prompts.</value>
    private List<string> m_Prompts { get; } =
    [
        "What made you smile today?",
        "What is something you learned recently?",
        "Describe a moment you felt proud of yourself.",
        "What are you grateful for today?",
        "What is a goal you want to achieve this week?",
        "What is something good that happened to you today?",
        "What are you most grateful for right now?",
        "Describe a moment today that made you smile.",
        "What is a personal achievement you're proud of?",
        "What is one thing you're looking forward to?",
        "Who is someone that inspires you, and why?",
        "What is a kind act you witnessed or performed today?",
        "What is a favorite memory that brings you joy?",
        "What is something you love about yourself?",
        "What is one thing that made you feel peaceful today?"
    ];

    #endregion
}