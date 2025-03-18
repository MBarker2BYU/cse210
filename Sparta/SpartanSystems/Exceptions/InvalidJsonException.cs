// ***********************************************************************
// Assembly        : SpartanSystems
// Author            : Matthew D. Barker
// Created           : 03-18-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-18-2025
// ***********************************************************************
// <copyright file="InvalidJsonException.cs" company="SpartanSystems">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace SpartanSystems.Exceptions;

/// <summary>
/// Class InvalidJsonException.
/// Implements the <see cref="System.Exception" />
/// </summary>
/// <param name="json">The json.</param>
/// <seealso cref="System.Exception" />
public class InvalidJsonException(string json) : Exception
{
    /// <summary>
    /// Gets the json.
    /// </summary>
    /// <value>The json.</value>
    public string Json { get; } = json;
}