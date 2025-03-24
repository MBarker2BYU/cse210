// ***********************************************************************
// Assembly        : YouTubeVideos
// Author            : Matthew D. Barker
// Created           : 03-24-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-24-2025
// ***********************************************************************
// <copyright file="IComments.cs" company="YouTubeVideos">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace YouTubeVideos.Interfaces;

/// <summary>
/// Interface IComments
/// Extends the <see>
///     <cref>System.Collections.Generic.IReadOnlyList{YouTubeVideos.Interfaces.IComment}</cref>
/// </see>
/// </summary>
/// <seealso>
///     <cref>System.Collections.Generic.IReadOnlyList{YouTubeVideos.Interfaces.IComment}</cref>
/// </seealso>
public interface IComments : IReadOnlyList<IComment>
{}