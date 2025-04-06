// ***********************************************************************
// Assembly        : EternalQuest
// Author            : Matthew D. Barker
// Created           : 04-06-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 04-06-2025
// ***********************************************************************
// <copyright file="EnumExtensions.cs" company="EternalQuest">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using EternalQuest.Attributes;
using EternalQuest.Enums;

namespace EternalQuest.ExtensionMethods;

/// <summary>
/// Class EnumExtensions.
/// </summary>
public static class EnumExtensions
{
    /// <summary>
    /// Gets the level description.
    /// </summary>
    /// <param name="level">The level.</param>
    /// <returns>LevelDescription.</returns>
    public static LevelDescription GetLevelDescription(this Level level)
    {
        var type = typeof(Level);
        var memInfo = type.GetMember(level.ToString());
        var attributes = memInfo[0].GetCustomAttributes(typeof(LevelDescription), false);
        return (LevelDescription)attributes[0];
    }
}