// ***********************************************************************
// Assembly        : YouTubeVideos
// Author            : Matthew D. Barker
// Created           : 03-24-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-24-2025
// ***********************************************************************
// <copyright file="IComment.cs" company="YouTubeVideos">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace YouTubeVideos.Interfaces;

/// <summary>
/// Interface IComment
/// Extends the <see cref="YouTubeVideos.Interfaces.IDisplay" />
/// </summary>
/// <seealso cref="YouTubeVideos.Interfaces.IDisplay" />
public interface IComment : IDisplay
{
    /// <summary>
    /// Gets the person.
    /// </summary>
    /// <value>The person.</value>
    public IPerson Person { get; }

    /// <summary>
    /// Gets the text.
    /// </summary>
    /// <value>The text.</value>
    public string Text { get; }

    /// <summary>
    /// Gets the stars.
    /// </summary>
    /// <value>The stars.</value>
    public byte Stars { get; }
}