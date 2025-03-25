// ***********************************************************************
// Assembly        : OnlineOrdering
// Author            : Matthew D. Barker
// Created           : 03-24-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-24-2025
// ***********************************************************************
// <copyright file="IProduct.cs" company="OnlineOrdering">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace OnlineOrdering.Interfaces;

/// <summary>
/// Interface IProduct
/// </summary>
public interface IProduct
{
    /// <summary>
    /// Gets the identifier.
    /// </summary>
    /// <value>The identifier.</value>
    public string ID {get; }

    /// <summary>
    /// Gets the name.
    /// </summary>
    /// <value>The name.</value>
    public string Name { get; }

    /// <summary>
    /// Gets the price.
    /// </summary>
    /// <value>The price.</value>
    public decimal Price { get; }

    /// <summary>
    /// Gets or sets the quantity.
    /// </summary>
    /// <value>The quantity.</value>
    public int Quantity { get; }
}