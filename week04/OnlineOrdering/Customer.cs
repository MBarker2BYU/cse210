// ***********************************************************************
// Assembly        : OnlineOrdering
// Author            : Matthew D. Barker
// Created           : 03-24-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-24-2025
// ***********************************************************************
// <copyright file="Customer.cs" company="OnlineOrdering">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using OnlineOrdering.Interfaces;

namespace OnlineOrdering;

/// <summary>
/// Class Customer.
/// Implements the <see cref="ICustomer" />
/// </summary>
/// <param name="name">The name.</param>
/// <param name="address">The address.</param>
/// <seealso cref="ICustomer" />
public class Customer(string name, IAddress address) : ICustomer
{
    #region Implementation of ICustomer

    /// <summary>
    /// Gets the name.
    /// </summary>
    /// <value>The name.</value>
    public string Name { get; } = name;

    /// <summary>
    /// Gets the address.
    /// </summary>
    /// <value>The address.</value>
    public IAddress Address { get; } = address;

    /// <summary>
    /// Gets a value indicating whether this instance is usa.
    /// </summary>
    /// <value><c>true</c> if this instance is usa; otherwise, <c>false</c>.</value>
    public bool IsUSA
        => Address.IsUSA;

    #endregion
}