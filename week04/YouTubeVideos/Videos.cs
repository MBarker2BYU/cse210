// ***********************************************************************
// Assembly        : YouTubeVideos
// Author            : Matthew D. Barker
// Created           : 03-24-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-24-2025
// ***********************************************************************
// <copyright file="Videos.cs" company="YouTubeVideos">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Reflection;
using YouTubeVideos.Interfaces;

namespace YouTubeVideos;

/// <summary>
/// Class Videos.
/// Implements the <see>
///     <cref>System.Collections.Generic.List{YouTubeVideos.Interfaces.IVideo}</cref>
/// </see>
/// Implements the <see cref="IVideos" />
/// </summary>
/// <seealso>
///     <cref>System.Collections.Generic.List{YouTubeVideos.Interfaces.IVideo}</cref>
/// </seealso>
/// <seealso cref="IVideos" />
public class Videos : List<IVideo>, IVideos
{
    
    
    #region Implementation of IDisplay    
    /// <summary>
    /// Displays this instance.
    /// </summary>
    public void Display()
    {
        foreach (var video in this)
        {
            video.Display();
            Console.WriteLine();
        }
    }

    #endregion

    #region Implementation of IVideos

    /// <summary>
    /// Adds the specified title.
    /// </summary>
    /// <param name="title">The title.</param>
    /// <param name="author">The author.</param>
    /// <param name="length">The length.</param>
    public void Add(string title, Person author, long length)
        => base.Add(new Video(title, author, length));

    /// <summary>
    /// Adds the specified title.
    /// </summary>
    /// <param name="title">The title.</param>
    /// <param name="firstName">The first name.</param>
    /// <param name="lastName">The last name.</param>
    /// <param name="length">The length.</param>
    public void Add(string title, string firstName, string lastName, long length)
        => base.Add(new Video(title, new Person(firstName, lastName), length));
    
    #endregion
}