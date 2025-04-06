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
    [Description("Pray(Gain 10 - 20 Faith Points")]
    Pray,
    [Description("Serve Others (Gain 15-30 Faith Points)")]
    ServeOthers,
    [Description("Study(Spend 10 - 20 Faith Points)")]
    Study,
    [Description("Face a Trial (Risk vs Reward)")]
    FaceTrial,
    [Description("Rest and Reflect (Heal your spirit)")]
    Rest,
    [Description("Check Progress")]
    CheckProgress,
    [Description("Exit Quest")]
    Exit
}