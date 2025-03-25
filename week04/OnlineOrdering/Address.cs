// ***********************************************************************
// Assembly        : OnlineOrdering
// Author            : Matthew D. Barker
// Created           : 03-24-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-24-2025
// ***********************************************************************
// <copyright file="Address.cs" company="OnlineOrdering">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Text;
using OnlineOrdering.Enums;
using OnlineOrdering.Interfaces;
using static System.Enum;

namespace OnlineOrdering;

/// <summary>
/// Class Address.
/// Implements the <see cref="IAddress" />
/// </summary>
/// <param name="street">The street.</param>
/// <param name="city">The city.</param>
/// <param name="region">The region.</param>
/// <param name="country">The country.</param>
/// <seealso cref="IAddress" />
public class Address(string street, string city, string region, Country country) : IAddress
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Address"/> class.
    /// </summary>
    /// <param name="street">The street.</param>
    /// <param name="city">The city.</param>
    /// <param name="region">The region.</param>
    /// <param name="country">The country.</param>
    public Address(string street, string city, string region, string country): this(street, city, region, Parse<Country>(country))
    {}

    #region Implementation of IAddress

    /// <summary>
    /// Gets the street.
    /// </summary>
    /// <value>The street.</value>
    public string Street { get; } = street;
    /// <summary>
    /// Gets the city.
    /// </summary>
    /// <value>The city.</value>
    public string City { get; } = city;
    /// <summary>
    /// Gets the state.
    /// </summary>
    /// <value>The state.</value>
    public string Region { get; } = region;

    /// <summary>
    /// The country
    /// </summary>
    private Country _country = country;

    /// <summary>
    /// Gets the country.
    /// </summary>
    /// <value>The country.</value>
    public string Country
        => _country.ToString();

    /// <summary>
    /// Gets a value indicating whether this instance is usa.
    /// </summary>
    /// <value><c>true</c> if this instance is usa; otherwise, <c>false</c>.</value>
    public bool IsUSA
        => _country == Enums.Country.UnitedStates;

    #endregion

    #region Overrides of Object

    /// <summary>
    /// Returns a <see cref="System.String" /> that represents this instance.
    /// </summary>
    /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
    public override string ToString()
    {
        var address = new StringBuilder();

        address.AppendLine(Street);
        address.AppendLine($"{City}, {Region}, {InsertSpaces(Country)}");

        return address.ToString();
    }

    #endregion

    /// <summary>
    /// Inserts the spaces.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>System.String.</returns>
    public static string InsertSpaces(string value)
    {
        if (string.IsNullOrWhiteSpace(value)) return value;

        var result = new System.Text.StringBuilder();
        foreach (var character in value)
        {
            if (char.IsUpper(character) && result.Length > 0) result.Append(' ');

            result.Append(character);
        }

        return result.ToString();
    }

}