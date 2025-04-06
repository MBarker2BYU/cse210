// ***********************************************************************
// Assembly        : EternalQuest
// Author            : Matthew D. Barker
// Created           : 04-06-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 04-06-2025
// ***********************************************************************
// <copyright file="LevelDescription.cs" company="EternalQuest">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace EternalQuest.Attributes;

/// <summary>
/// Class LevelDescription.
/// Implements the <see cref="System.Attribute" />
/// </summary>
/// <param name="name">The name.</param>
/// <param name="objective">The objective.</param>
/// <param name="quest">The quest.</param>
/// <param name="reward">The reward.</param>
/// <param name="ldsContext">The LDS context.</param>
/// <param name="faithPointsMultiplier">The faith points multiplier.</param>
/// <param name="faithPointsBase">The faith points base.</param>
/// <seealso>
///     <cref>System.Attribute</cref>
/// </seealso>
public class LevelDescription(string name,  string objective, string quest, string reward, string ldsContext, int level=0, double faithPointsMultiplier = 1, int faithPointsBase = 100) : Attribute
{
    /// <summary>
    /// Gets the name.
    /// </summary>
    /// <value>The name.</value>
    public string Name { get; } = name;
    /// <summary>
    /// Gets the objective.
    /// </summary>
    /// <value>The objective.</value>
    public string Objective { get; } = objective;
    /// <summary>
    /// Gets the quest.
    /// </summary>
    /// <value>The quest.</value>
    public string Quest { get; } = quest;
    /// <summary>
    /// Gets the reward.
    /// </summary>
    /// <value>The reward.</value>
    public string Reward { get; } = reward;
    /// <summary>
    /// Gets the LDS context.
    /// </summary>
    /// <value>The LDS context.</value>
    public string LDSContext { get; } = ldsContext;
    /// <summary>
    /// Gets the faith points required.
    /// </summary>
    /// <value>The faith points required.</value>
    public int FaithPointsRequired { get; } = (int)(level * 1.15 * 1000);
    /// <summary>
    /// Gets the faith points multiplier.
    /// </summary>
    /// <value>The faith points multiplier.</value>
    public double FaithPointsMultiplier { get; } = faithPointsMultiplier;
    /// <summary>
    /// Gets the faith points base.
    /// </summary>
    /// <value>The faith points base.</value>
    public int FaithPointsBase { get; } = faithPointsBase;

    /// <summary>
    /// Displays the level description.
    /// </summary>
    public void DisplayLevelDescription()
    {
        Console.WriteLine($"Level: {Name}");
        Console.WriteLine($"Objective: {Objective}");
        Console.WriteLine($"Quest: {Quest}");
        Console.WriteLine($"Reward: {Reward}");
        Console.WriteLine($"LDS Context: {LDSContext}");
    }
}