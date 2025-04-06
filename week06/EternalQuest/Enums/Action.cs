// ***********************************************************************
// Assembly        : EternalQuest
// Author            : Matthew D. Barker
// Created           : 04-05-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 04-05-2025
// ***********************************************************************
// <copyright file="Action.cs" company="EternalQuest">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.ComponentModel;

namespace EternalQuest.Enums;

public enum Action
{
    /// <summary>
    /// Pray(Gain 10 - 20 Faith Points)
    /// </summary>
    [Description("Pray(Gain 10 - 20 Faith Points")]
    Pray,
    /// <summary>
    /// Serve Others (Gain 15-30 Faith Points)
    /// </summary>
    [Description("Serve Others (Gain 15-30 Faith Points)")]
    ServeOthers,
    /// <summary>
    /// Study (Spend 10 - 20 Faith Points)
    /// </summary>
    [Description("Study(Spend 10 - 20 Faith Points)")]
    Study,
    /// <summary>
    /// Face a Trial (Risk vs Reward)
    /// </summary>
    [Description("Face a Trial (Risk vs Reward)")]
    FaceTrial,
    /// <summary>
    /// Rest and Reflect (Heal your spirit)
    /// </summary>
    [Description("Rest and Reflect (Heal your spirit)")]
    Rest,
    /// <summary>
    /// Check Progress (Check your progress)
    /// </summary>
    [Description("Check Progress")]
    CheckProgress,
    [Description("View Level Information")]
    LevelInformation,
    /// <summary>
    /// Exit Quest (End the game)
    /// </summary>
    [Description("Exit Quest")]
    Exit
}