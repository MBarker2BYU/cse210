// ***********************************************************************
// Assembly        : OnlineOrdering
// Author            : Matthew D. Barker
// Created           : 03-24-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-24-2025
// ***********************************************************************
// <copyright file="Items.cs" company="OnlineOrdering">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using OnlineOrdering.Interfaces;

namespace OnlineOrdering;

/// <summary>
/// Class Items.
/// Implements the <see>
///     <cref>System.Collections.Generic.List{OnlineOrdering.Interfaces.IProduct}</cref>
/// </see>
/// </summary>
/// <seealso>
///     <cref>System.Collections.Generic.List{OnlineOrdering.Interfaces.IProduct}</cref>
/// </seealso>
public class Items : List<IProduct>
{}