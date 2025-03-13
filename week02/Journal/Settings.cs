// ***********************************************************************
// Assembly        : Journal
// Author            : Matthew D. Barker
// Created           : 03-05-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-11-2025
// ***********************************************************************
// <copyright file="Settings.cs" company="Journal">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Journal.Interfaces;
using SpartanSystems;

namespace Journal;

/// <summary>
/// Class Settings.
/// Implements the <see cref="ISettings" />
/// </summary>
/// <seealso cref="ISettings" />
public class Settings : ISettings
{
    #region Implementation of ISettings

    /// <summary>
    /// Gets or sets the filename.
    /// </summary>
    /// <value>The filename.</value>
    public string Filename { get; set; }

    /// <summary>
    /// Gets or sets the color of the background.
    /// </summary>
    /// <value>The color of the background.</value>
    public ConsoleColor BackgroundColor { get; set; } = ConsoleColor.White;
    /// <summary>
    /// Gets or sets the color of the fore.
    /// </summary>
    /// <value>The color of the fore.</value>
    public ConsoleColor ForeColor { get; set; }= ConsoleColor.Black;

    /// <summary>
    /// Gets or sets a value indicating whether [automatic save].
    /// </summary>
    /// <value><c>true</c> if [automatic save]; otherwise, <c>false</c>.</value>
    public bool AutoSave { get; set; } = true;

    #endregion

    public void DisplaySettings(bool pressEnterToContinue = true)
    {
        Utilities.WriteLinePlus("Current Settings:");

        Console.WriteLine($"Filename: {Filename}");
        Console.WriteLine($"Background Color: {BackgroundColor}");
        Console.WriteLine($"Foreground Color: {ForeColor}");
        Utilities.WriteLineWithHighlights("Your current selection colors are: \\!@Selection Example\\@!", BackgroundColor, ForeColor);
        
        var autoSaveStatus = AutoSave ? "Enabled" : "Disabled";
        
        Console.WriteLine($"Auto Save: {autoSaveStatus}");
        Console.WriteLine();

        if (pressEnterToContinue)
            Utilities.PressEnter();
    }

}