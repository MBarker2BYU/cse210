// ***********************************************************************
// Assembly        : Journal
// Author            : Matthew D. Barker
// Created           : 03-05-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-14-2025
// ***********************************************************************
// <copyright file="ISettings.cs" company="Journal">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Journal.Interfaces;

/// <summary>
/// Interface ISettings
/// </summary>
public interface ISettings
{
    /// <summary>
    /// Gets or sets the filename.
    /// </summary>
    /// <value>The filename.</value>
    public string Filename { get; set; }

    /// <summary>
    /// Gets or sets the color of the background.
    /// </summary>
    /// <value>The color of the background.</value>
    public ConsoleColor BackgroundColor { get; set; }

    /// <summary>
    /// Gets or sets the color of the foreground.
    /// </summary>
    /// <value>The color of the foreground.</value>
    public ConsoleColor ForegroundColor { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether [automatic save].
    /// </summary>
    /// <value><c>true</c> if [automatic save]; otherwise, <c>false</c>.</value>
    public bool AutoSave { get; set; }

    /// <summary>
    /// Displays the settings.
    /// </summary>
    /// <param name="pressEnterToContinue">if set to <c>true</c> [press enter to continue].</param>
    public void DisplaySettings(bool pressEnterToContinue = true);
}