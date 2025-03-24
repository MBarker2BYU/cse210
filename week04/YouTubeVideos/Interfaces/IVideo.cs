// ***********************************************************************
// Assembly        : YouTubeVideos
// Author           : Matthew D. Barker
// Created          : 03-24-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-24-2025
// ***********************************************************************
// <copyright file="IVideo.cs" company="YouTubeVideos">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace YouTubeVideos.Interfaces;

/// <summary>
/// Interface IVideo
/// Extends the <see cref="YouTubeVideos.Interfaces.IDisplay" />
/// </summary>
/// <seealso cref="YouTubeVideos.Interfaces.IDisplay" />
public interface IVideo : IDisplay
{
    /// <summary>
    /// Gets the title.
    /// </summary>
    /// <value>The title.</value>
    public string Title { get; }

    /// <summary>
    /// Gets the author.
    /// </summary>
    /// <value>The author.</value>
    public IPerson Author { get; }

    /// <summary>
    /// Gets the length.
    /// </summary>
    /// <value>The length.</value>
    public long Length { get;  }

    /// <summary>
    /// Gets the comments.
    /// </summary>
    /// <value>The comments.</value>
    public IComments Comments  { get; }

    /// <summary>
    /// Adds the comment.
    /// </summary>
    /// <param name="comment">The comment.</param>
    public void AddComment(IComment comment);
}