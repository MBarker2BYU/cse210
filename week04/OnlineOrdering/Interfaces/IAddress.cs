// ***********************************************************************
// Assembly        : OnlineOrdering
// Author            : Matthew D. Barker
// Created           : 03-24-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-24-2025
// ***********************************************************************
// <copyright file="IAddress.cs" company="OnlineOrdering">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace OnlineOrdering.Interfaces;

/// <summary>
/// Interface IAddress
/// Extends the <see cref="OnlineOrdering.Interfaces.IDisplay" />
/// </summary>
/// <seealso cref="OnlineOrdering.Interfaces.IDisplay" />
public interface IAddress
{
    /// <summary>
    /// Gets the street.
    /// </summary>
    /// <value>The street.</value>
    public string Street {get; }
    /// <summary>
    /// Gets the city.
    /// </summary>
    /// <value>The city.</value>
    public string City { get; }
    /// <summary>
    /// Gets the state.
    /// </summary>
    /// <value>The state.</value>
    public string Region { get; }

    /// <summary>
    /// Gets the country.
    /// </summary>
    /// <value>The country.</value>
    public string Country { get; }

    /// <summary>
    /// Gets a value indicating whether this instance is usa.
    /// </summary>
    /// <value><c>true</c> if this instance is usa; otherwise, <c>false</c>.</value>
    public bool IsUSA { get; }
}