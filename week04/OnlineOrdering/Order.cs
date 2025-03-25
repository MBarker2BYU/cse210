// ***********************************************************************
// Assembly        : OnlineOrdering
// Author            : Matthew D. Barker
// Created           : 03-24-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-24-2025
// ***********************************************************************
// <copyright file="Order.cs" company="OnlineOrdering">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Text;
using OnlineOrdering.Interfaces;

namespace OnlineOrdering;

/// <summary>
/// Class Order.
/// Implements the <see cref="IOrder" />
/// </summary>
/// <param name="customer">The customer.</param>
/// <seealso cref="IOrder" />
public class Order(ICustomer customer) : IOrder
{
    #region Implementation of IOrder
    /// <summary>
    /// Gets the customer.
    /// </summary>
    /// <value>The customer.</value>
    public ICustomer Customer { get; } = customer;

    /// <summary>
    /// Gets the items.
    /// </summary>
    /// <value>The items.</value>
    public IReadOnlyList<IProduct> Items
        => _items;

    /// <summary>
    /// The items
    /// </summary>
    private readonly Items _items = [];

    /// <summary>
    /// Adds the item.
    /// </summary>
    /// <param name="product">The product.</param>
    public void AddItem(IProduct product)
        => _items.Add(product);

    /// <summary>
    /// Removes the item.
    /// </summary>
    /// <param name="productId">The product identifier.</param>
    public void RemoveItem(string productId)
    {
        var item = _items.FirstOrDefault(p => p.ID == productId);
        if (item != null)
        {
            _items.Remove(item);
        }
    }

    private string BuildPackingLabel()
    {
        var invoice = new StringBuilder("Packing Label\n\n");

        invoice.AppendLine($"{"ID",-15}{"Name",-35}{"Quantity",15}");
        invoice.AppendLine(new string('-', 65));

        decimal sum = 0;

        foreach (var item in Items)
        {
            invoice.AppendLine($"{item.ID,-15}{item.Name,-35}{item.Quantity,15}");
        }

        invoice.AppendLine(new string('-', 65));

        return invoice.ToString();
    }

    private string BuildShippingLabel()
    {
        var shippingLabel = new StringBuilder();

        var padding = 8;

        shippingLabel.AppendLine("J&S Labs");
        shippingLabel.AppendLine("101 First St.");
        shippingLabel.AppendLine("Cape Coral, FL 33993");
        shippingLabel.AppendLine();
        shippingLabel.AppendLine($"Ship To:");
        shippingLabel.AppendLine($"{new string(' ', padding)}{Customer.Name}");
        shippingLabel.AppendLine($"{new string(' ', padding)}{Customer.Address.Street}");
        shippingLabel.AppendLine($"{new string(' ', padding)}{Customer.Address.City}, {Customer.Address.Region}, {Address.InsertSpaces(Customer.Address.Country)}");

        return shippingLabel.ToString();
    }

    private string BuildInvoice()
    {
        var invoice = new StringBuilder("Invoice\n\n");

        invoice.AppendLine($"{"ID",-15}{"Name",-35}{"Quantity",15}{"Price",15}{"Cost",15}");
        invoice.AppendLine(new string('-', 95));
        
        foreach (var item in Items)
        {
            var price = $"${item.Price:#,##0.00}";
            var subTotal = item.Price * item.Quantity;
            var total = $"{subTotal:#,##0.00}";

            invoice.AppendLine($"{item.ID,-15}{item.Name,-35}{item.Quantity,15}{price,15}{total,15}");
        }

        invoice.AppendLine(new string('-', 95));

        var shippingLabel = "Shipping:";
        var totalLabel = "Total:";
        var shippingCost = Customer.IsUSA ? 5 : 35;
        var shipping = $"${shippingCost:#,##0.00}";
        var totalValue = $"${TotalCost:#,##0.00}";

        invoice.AppendLine($"{shippingLabel,80}{shipping,15}");
        invoice.AppendLine($"{totalLabel,80}{totalValue,15}");

        return invoice.ToString();
    }


    /// <summary>
    /// Gets the packing label.
    /// </summary>
    /// <value>The packing label.</value>
    public string PackingLabel
        => BuildPackingLabel();

    /// <summary>
    /// Gets the shipping label.
    /// </summary>
    /// <value>The shipping label.</value>
    public string ShippingLabel
        => BuildShippingLabel();

    /// <summary>
    /// Gets the invoice.
    /// </summary>
    /// <value>The invoice.</value>
    public string Invoice
        => BuildInvoice();

    /// <summary>
    /// Gets the total price.
    /// </summary>
    /// <value>The total price.</value>
    public decimal TotalCost
        => Items.Sum(item => item.Price * item.Quantity) + (Customer.IsUSA ? 5 : 35);

    #endregion
}
