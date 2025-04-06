// ***********************************************************************
// Assembly        : EternalQuest
// Author            : Matthew D. Barker
// Created           : 04-06-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 04-06-2025
// ***********************************************************************
// <copyright file="Study.cs" company="EternalQuest">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using EternalQuest.Base;

namespace EternalQuest;

/// <summary>
/// Class Study.
/// Implements the <see cref="Base.ActionBase" />
/// </summary>
/// <seealso cref="Base.ActionBase" />
public class Study : ActionBase
{
    /// <summary>
    /// The minimum points
    /// </summary>
    public const int MIN_POINTS = 10;
    /// <summary>
    /// The maximum points
    /// </summary>
    public const int MAX_POINTS = 20;

    #region Overrides of ActionBase

    /// <summary>
    /// Updates the player.
    /// </summary>
    /// <param name="player">The player.</param>
    public override void UpdatePlayer(Player player)
    {
        _LastAwardedFaithPoints = Random.Next(MIN_POINTS, MAX_POINTS + 1);

        player.FaithPoints += _LastAwardedFaithPoints;
    }

    /// <summary>
    /// Displays the action message.
    /// </summary>
    public override void DisplayActionMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"You study the scriptures. Gained {_LastAwardedFaithPoints} Faith Points.");
    }

    #endregion
}