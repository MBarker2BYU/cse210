// ***********************************************************************
// Assembly        : OnlineOrdering
// Author            : Matthew D. Barker
// Created           : 03-24-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-24-2025
// ***********************************************************************
// <copyright file="ICustomer.cs" company="OnlineOrdering">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace OnlineOrdering.Interfaces;

/// <summary>
/// Interface ICustomer
/// </summary>
public interface ICustomer
{
    /// <summary>
    /// Gets the name.
    /// </summary>
    /// <value>The name.</value>
    public string Name { get; }

    /// <summary>
    /// Gets the address.
    /// </summary>
    /// <value>The address.</value>
    public IAddress Address { get; }
    
    /// <summary>
    /// Gets a value indicating whether this instance is usa.
    /// </summary>
    /// <value><c>true</c> if this instance is usa; otherwise, <c>false</c>.</value>
    public bool IsUSA { get; }
}