// ***********************************************************************
// Assembly        : OnlineOrdering
// Author            : Matthew D. Barker
// Created           : 03-24-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-24-2025
// ***********************************************************************
// <copyright file="CountryInfo.cs" company="OnlineOrdering">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace OnlineOrdering;

/// <summary>
/// Class CountryInfoAttribute.
/// Implements the <see cref="System.Attribute" />
/// </summary>
/// <seealso cref="System.Attribute" />
public class CountryInfoAttribute : Attribute
{
    internal CountryInfoAttribute()
    {}

    /// <summary>
    /// Gets the code.
    /// </summary>
    /// <value>The code.</value>
    public string Code { get; init; }

    /// <summary>
    /// Gets the phone code.
    /// </summary>
    /// <value>The phone code.</value>
    public int  PhoneCode { get; init; }

    /// <summary>
    /// Gets the name.
    /// </summary>
    /// <value>The name.</value>
    public string Name { get; init; }
}