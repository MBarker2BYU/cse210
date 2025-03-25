// ***********************************************************************
// Assembly        : OnlineOrdering
// Author            : Matthew D. Barker
// Created           : 03-24-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-24-2025
// ***********************************************************************
// <copyright file="IOrder.cs" company="OnlineOrdering">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace OnlineOrdering.Interfaces;

/// <summary>
/// Interface IOrder
/// </summary>
public interface IOrder
{
    /// <summary>
    /// Gets the customer.
    /// </summary>
    /// <value>The customer.</value>
    public ICustomer Customer { get; }

    /// <summary>
    /// Gets the items.
    /// </summary>
    /// <value>The items.</value>
    public IReadOnlyList<IProduct> Items { get; }

    /// <summary>
    /// Adds the item.
    /// </summary>
    /// <param name="product">The product.</param>
    public void AddItem(IProduct product);

    /// <summary>
    /// Removes the item.
    /// </summary>
    /// <param name="id">The identifier.</param>
    public void RemoveItem(string id);

    /// <summary>
    /// Gets the packing label.
    /// </summary>
    /// <value>The packing label.</value>
    public string PackingLabel { get; }

    /// <summary>
    /// Gets the shipping label.
    /// </summary>
    /// <value>The shipping label.</value>
    public string ShippingLabel { get; }

    /// <summary>
    /// Gets the invoice.
    /// </summary>
    /// <value>The invoice.</value>
    public string Invoice { get; }

    /// <summary>
    /// Gets the total price.
    /// </summary>
    /// <value>The total price.</value>
    public decimal TotalCost { get; }
}