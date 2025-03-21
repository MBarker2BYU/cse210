// ***********************************************************************
// Assembly        : ScriptureMemorizer
// Author            : Matthew D. Barker
// Created           : 03-20-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-21-2025
// ***********************************************************************
// <copyright file="Scriptures.cs" company="ScriptureMemorizer">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using ScriptureMemorizer.Sparta.Menus;
using ScriptureMemorizer.Sparta.Menus.Interfaces;

namespace ScriptureMemorizer.Advanced;

/// <summary>
/// Class Scriptures.
/// Implements the <see cref="System.Collections.Generic.List{ScriptureMemorizer.Advanced.Scripture}" />
/// </summary>
/// <seealso cref="System.Collections.Generic.List{ScriptureMemorizer.Advanced.Scripture}" />
public class Scriptures : List<Scripture>
{
    /// <summary>
    /// Converts to menuitems.
    /// </summary>
    /// <returns>IEnumerable&lt;IStringMenuItem&gt;.</returns>
    public IEnumerable<IStringMenuItem> ToMenuItems()
    {
        List<IStringMenuItem> items = [];
        
        items.AddRange(this.Select(scripture => new StringMenuItem(scripture, scripture.Reference)).Cast<IStringMenuItem>());

        return items;
    }
}