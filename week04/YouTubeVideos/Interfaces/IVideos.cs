// ***********************************************************************
// Assembly        : YouTubeVideos
// Author            : Matthew D. Barker
// Created           : 03-24-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-24-2025
// ***********************************************************************
// <copyright file="IVideos.cs" company="YouTubeVideos">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace YouTubeVideos.Interfaces;

/// <summary>
/// Interface IVideos
/// </summary>
public interface IVideos : IList<IVideo>, IDisplay
{
    #region Implementation of ICollection<IVideo>    
    
    /// <summary>
    /// Adds the specified title.
    /// </summary>
    /// <param name="title">The title.</param>
    /// <param name="author">The author.</param>
    /// <param name="length">The length.</param>
    public void Add(string title, Person author, long length);

    /// <summary>
    /// Adds the specified title.
    /// </summary>
    /// <param name="title">The title.</param>
    /// <param name="firstName">The first name.</param>
    /// <param name="lastname">The lastname.</param>
    /// <param name="length">The length.</param>
    public void Add(string title, string firstName, string lastname, long length);
    
    #endregion
}