// ***********************************************************************
// Assembly        : EternalQuest
// Author            : Matthew D. Barker
// Created           : 04-06-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 04-06-2025
// ***********************************************************************
// <copyright file="Rest.cs" company="EternalQuest">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using EternalQuest.Base;

namespace EternalQuest;

/// <summary>
/// Class Rest.
/// Implements the <see cref="Base.ActionBase" />
/// </summary>
/// <seealso cref="Base.ActionBase" />
public class Rest : ActionBase
{
    /// <summary>
    /// The points
    /// </summary>
    public const int POINTS = 5;

    #region Overrides of ActionBase

    /// <summary>
    /// Updates the player.
    /// </summary>
    /// <param name="player">The player.</param>
    public override void UpdatePlayer(Player player)
    {
        _LastAwardedFaithPoints = POINTS;

        player.FaithPoints += _LastAwardedFaithPoints;
    }

    /// <summary>
    /// Displays the action message.
    /// </summary>
    public override void DisplayActionMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"You rest and reflect on your journey. Your spirit feels renewed. You've earned {_LastAwardedFaithPoints} Faith Points.");
    }

    #endregion
}