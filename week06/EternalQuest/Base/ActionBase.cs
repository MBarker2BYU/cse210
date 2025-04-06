// ***********************************************************************
// Assembly        : EternalQuest
// Author            : Matthew D. Barker
// Created           : 04-06-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 04-06-2025
// ***********************************************************************
// <copyright file="ActionBase.cs" company="EternalQuest">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace EternalQuest.Base;

/// <summary>
/// Class ActionBase.
/// </summary>
public abstract class ActionBase
{
    /// <summary>
    /// The random
    /// </summary>
    protected static Random Random = new(DateTime.Now.Nanosecond);

    /// <summary>
    /// The last awarded faith points
    /// </summary>
    protected int _LastAwardedFaithPoints = 0;

    /// <summary>
    /// Updates the player.
    /// </summary>
    /// <param name="player">The player.</param>
    public abstract void UpdatePlayer(Player player);

    /// <summary>
    /// Displays the action message.
    /// </summary>
    public abstract void DisplayActionMessage();
}