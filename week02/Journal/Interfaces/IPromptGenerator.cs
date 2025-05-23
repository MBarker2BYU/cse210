﻿// ***********************************************************************
// Assembly         : Journal
// Author           : Matthew D. Barker
// Created          : 03-05-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-13-2025
// ***********************************************************************
// <copyright file="IPromptGenerator.cs" company="Journal">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Journal.Interfaces;

/// <summary>
/// Interface IPromptGenerator
/// </summary>
public interface IPromptGenerator
{
    /// <summary>
    /// Returns the next random prompt.
    /// </summary>
    /// <returns>System.String.</returns>
    public string NextPrompt();
}