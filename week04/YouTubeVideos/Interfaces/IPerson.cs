// ***********************************************************************
// Assembly         : YouTubeVideos
// Author            : Matthew D. Barker
// Created           : 03-24-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-24-2025
// ***********************************************************************
// <copyright file="IPerson.cs" company="YouTubeVideos">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace YouTubeVideos.Interfaces;

/// <summary>
/// Interface IPerson
/// Extends the <see cref="YouTubeVideos.Interfaces.IDisplay" />
/// </summary>
/// <seealso cref="YouTubeVideos.Interfaces.IDisplay" />
public interface IPerson : IDisplay
{
    /// <summary>
    /// Gets the first name.
    /// </summary>
    /// <value>The first name.</value>
    public string FirstName { get; }
    /// <summary>
    /// Gets the last name.
    /// </summary>
    /// <value>The last name.</value>
    public string LastName { get; }
}