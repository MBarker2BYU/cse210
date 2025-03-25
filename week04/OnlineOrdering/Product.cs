// ***********************************************************************
// Assembly        : OnlineOrdering
// Author            : Matthew D. Barker
// Created           : 03-24-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-24-2025
// ***********************************************************************
// <copyright file="Product.cs" company="OnlineOrdering">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using OnlineOrdering.Interfaces;

namespace OnlineOrdering;

/// <summary>
/// Class Product.
/// Implements the <see cref="IProduct" />
/// </summary>
/// <param name="id">The identifier.</param>
/// <param name="name">The name.</param>
/// <param name="price">The price.</param>
/// <param name="quantity">The quantity.</param>
/// <seealso cref="IProduct" />
public class Product(string id, string name, decimal price, int quantity = 1) : IProduct
{
    
    #region Implementation of IProduct

    /// <summary>
    /// Gets the identifier.
    /// </summary>
    /// <value>The identifier.</value>
    public string ID { get; } = id.ToUpper();
    /// <summary>
    /// Gets the name.
    /// </summary>
    /// <value>The name.</value>
    public string Name { get; } = name;
    /// <summary>
    /// Gets the price.
    /// </summary>
    /// <value>The price.</value>
    public decimal Price { get; } = price;
    /// <summary>
    /// Gets or sets the quantity.
    /// </summary>
    /// <value>The quantity.</value>
    public int Quantity { get; } = quantity;

    #endregion
}