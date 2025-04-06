// ***********************************************************************
// Assembly        : EternalQuest
// Author            : Matthew D. Barker
// Created           : 04-06-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 04-06-2025
// ***********************************************************************
// <copyright file="Player.cs" company="EternalQuest">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using EternalQuest.Enums;
using EternalQuest.ExtensionMethods;

namespace EternalQuest;

/// <summary>
/// Class Player.
/// </summary>
/// <param name="name">The name.</param>
public class Player(string name)
{
    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    /// <value>The name.</value>
    public string Name { get; } = name;

    /// <summary>
    /// The m faith points
    /// </summary>
    private int m_FaithPoints = 0;
    /// <summary>
    /// Gets or sets the faith points.
    /// </summary>
    /// <value>The faith points.</value>
    public int FaithPoints
    {
        get => m_FaithPoints;
        set
        {
            m_FaithPoints = value;

            if (m_FaithPoints < 0)
                m_FaithPoints = 0;

            Level = CheckLevelUp();
        }
    }

    /// <summary>
    /// Gets the level.
    /// </summary>
    /// <value>The level.</value>
    public Level Level { get; private set; } = Level.ThePremortalCouncil;

    /// <summary>
    /// Gets a value indicating whether [level up].
    /// </summary>
    /// <value><c>true</c> if [level up]; otherwise, <c>false</c>.</value>
    public bool LevelUp { get; private set; } = false;

    /// <summary>
    /// Resets the level up.
    /// </summary>
    public void ResetLevelUp()
        => LevelUp = false;
    
    ///<summary>
    /// Checks the level up.
    /// </summary>
    /// <returns>Level.</returns>
    private Level CheckLevelUp()
    {
        for (var level = Enum.GetValues<Level>().Length - 1; level >= (int)Level; level--)
        {
            var ld = ((Level)level).GetLevelDescription();
            var faithPointsRequired = ld.FaithPointsRequired;

            if (FaithPoints >= faithPointsRequired)
            {
                if (level != (int)Level)
                    LevelUp = true;

                return (Level)level;
            }
        }

        return Level;
    }
}
