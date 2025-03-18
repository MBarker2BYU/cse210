// ***********************************************************************
// Assembly        : Journal2
// Author            : Matthew D. Barker
// Created           : 03-05-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-14-2025
// ***********************************************************************
// <copyright file="Settings.cs" company="Journal2">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Journal.Interfaces;

using static SpartanSystems.Utilities;

namespace Journal;

/// <summary>
/// Class Settings.
/// Implements the <see cref="ISettings" />
/// </summary>
/// <seealso cref="ISettings" />
public class Settings : ISettings
{
    /// <summary>
    /// The journal file
    /// </summary>
    private const string JOURNAL_FILE = "MyJournal.json";
    /// <summary>
    /// The settings filename
    /// </summary>
    public const string SETTINGS_FILENAME = "Settings.json";

    #region Implementation of ISettings

    #region Methods

    /// <summary>
    /// Displays the settings.
    /// </summary>
    /// <param name="pressEnterToContinue">if set to <c>true</c> [press enter to continue].</param>
    public void DisplaySettings(bool pressEnterToContinue = true)
    {
        WriteLinePlus("Current Settings:");

        WriteLinePlus($"Filename: {Filename}", spacingAfter: 0);
        WriteLinePlus($"Background Color: {BackgroundColor}", spacingAfter: 0);
        WriteLinePlus($"Foreground Color: {ForegroundColor}");

        WriteLineWithHighlights("Your current selection colors are: \\!@Selection Example\\@!", BackgroundColor, ForegroundColor);

        var autoSaveStatus = AutoSave ? "Enabled" : "Disabled";

        WriteLinePlus($"Auto Save: {autoSaveStatus}", spacingBefore: 1);

        if (pressEnterToContinue)
            PressEnter();
    }

    #endregion

    #region Properties

    /// <summary>
    /// Gets or sets the filename.
    /// </summary>
    /// <value>The filename.</value>
    public string Filename { get; set; } = JOURNAL_FILE;

    /// <summary>
    /// Gets or sets the color of the background.
    /// </summary>
    /// <value>The color of the background.</value>
    public ConsoleColor BackgroundColor { get; set; } = ConsoleColor.White;

    /// <summary>
    /// Gets or sets the color of the foreground.
    /// </summary>
    /// <value>The color of the foreground.</value>
    public ConsoleColor ForegroundColor { get; set; } = ConsoleColor.Black;

    /// <summary>
    /// Gets or sets a value indicating whether [automatic save].
    /// </summary>
    /// <value><c>true</c> if [automatic save]; otherwise, <c>false</c>.</value>
    public bool AutoSave { get; set; } = true;

    #endregion

    #endregion
}