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

    public void Add(string title, Person author, long length);

    public void Add(string title, string firstName, string lastname, long length);
    
    #endregion
}