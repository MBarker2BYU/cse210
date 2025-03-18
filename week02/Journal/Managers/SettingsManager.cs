// ***********************************************************************
// Assembly        : Journal
// Author            : Matthew D. Barker
// Created           : 03-13-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-16-2025
// ***********************************************************************
// <copyright file="SettingsManager.cs" company="Journal">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Journal.Enums;
using Journal.ExtensionMethods;
using Journal.Managers.Interfaces;
using SpartanSystems.Extensions;
using SpartanSystems.Menus;

using static SpartanSystems.Utilities;

namespace Journal.Managers;

/// <summary>
/// Class SettingsManager.
/// Implements the <see cref="ISettingsManager" />
/// </summary>
/// <seealso cref="ISettingsManager" />
public class SettingsManager : ISettingsManager
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SettingsManager"/> class.
    /// </summary>
    public SettingsManager()
    {
        if (!File.Exists(Settings.SETTINGS_FILENAME))
        {
            m_Settings = new Settings();
            
            return;
        };

        var json = File.ReadAllText(Settings.SETTINGS_FILENAME);

        if(!json.DeserializeFromJson<Settings>(out m_Settings, out var exception ))
            exception.ThrowIfNotNull();
    }

    #region Implementation of ISettingsManager

    /// <summary>
    /// Runs the specified exception.
    /// </summary>
    /// <param name="cursorLocation">The cursor location.</param>
    /// <param name="exception">The exception.</param>
    /// <returns><c>true</c> if the manager executes and returns properly, <c>false</c> otherwise.</returns>
    public bool Run((int Left, int Top) cursorLocation, out Exception? exception)
    {
        exception = default;

        try
        {
            SetPosition(cursorLocation);

            var settingsMenu = new ConsoleMenu(m_Settings!.BackgroundColor, m_Settings.ForegroundColor);
            settingsMenu.MenuItems = [Setting.EditSettings, Setting.ViewSettings, Setting.Exit];
            settingsMenu.MenuSystemItemEvent += (sender, args) =>
            {
                if (sender is not ConsoleMenu menu) return;

                switch ((Setting)args.MenuItem)
                {
                    case Setting.EditSettings:
                        {
                            if (!OnEditSettings(cursorLocation, out var editSettingsException))
                                editSettingsException.ThrowIfNotNull();

                            menu.SelectedBackgroundColor = m_Settings.BackgroundColor;
                            menu.SelectedForegroundColor = m_Settings.ForegroundColor;

                            break;
                        }
                    case Setting.ViewSettings:
                        {
                            if (!OnViewSettings(cursorLocation, out var viewSettingsException))
                                viewSettingsException.ThrowIfNotNull();

                            break;
                        }
                    case Setting.Exit:
                        {
                            menu.Exit();

                            break;
                        }
                }

                ClearRange(cursorLocation.Top);

            };
            settingsMenu.Show();
            return true;
        }
        catch (Exception ex)
        {
            exception = ex;
            return false;
        }
    }

    /// <summary>
    /// Called when [view settings].
    /// </summary>
    /// <param name="cursorLocation">The cursor location.</param>
    /// <param name="viewSettingsException">The view settings exception.</param>
    /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
    private bool OnViewSettings((int Left, int Top) cursorLocation, out Exception? viewSettingsException)
    {
        viewSettingsException = default;

        try
        {
            SetPosition(cursorLocation);

            m_Settings.DisplaySettings();

            return true;
        }
        catch (Exception ex)
        {
            viewSettingsException = ex;
            return false;
        }
    }

    /// <summary>
    /// Called when [edit settings].
    /// </summary>
    /// <param name="cursorLocation">The cursor location.</param>
    /// <param name="editSettingsException">The edit settings exception.</param>
    /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
    private bool OnEditSettings((int Left, int Top) cursorLocation, out Exception? editSettingsException)
    {
        editSettingsException = default;

        try
        {
            SetPosition(cursorLocation);

            var settingsMenu = new ConsoleMenu(m_Settings.BackgroundColor, m_Settings.ForegroundColor);
            settingsMenu.MenuItems = [Setting.Filename, Setting.BackgroundColor, Setting.ForegroundColor, Setting.AutoSave, Setting.Exit];
            settingsMenu.MenuSystemItemEvent += (sender, args) =>
            {
                if (sender is not ConsoleMenu menu) return;

                switch ((Setting)args.MenuItem)
                {
                    case Setting.Filename:
                        {
                            if (!OnUpdateFilename(cursorLocation, out var updateFilenameException))
                                updateFilenameException.ThrowIfNotNull();

                            break;
                        }
                    case Setting.BackgroundColor:
                        {
                            if (!OnUpdateBackgroundColor(cursorLocation, out var updateBackgroundColorException))
                                updateBackgroundColorException.ThrowIfNotNull();

                            menu.SelectedBackgroundColor = m_Settings.BackgroundColor;

                            break;
                        }
                    case Setting.ForegroundColor:
                        {
                            if (!OnUpdateForegroundColor(cursorLocation, out var updateForegroundColorException))
                                updateForegroundColorException.ThrowIfNotNull();

                            menu.SelectedForegroundColor = m_Settings.ForegroundColor;

                            break;
                        }
                    case Setting.AutoSave:
                        {
                            if (!OnUpdateAutoSave(cursorLocation, out var updateAutoSaveException))
                                updateAutoSaveException.ThrowIfNotNull();

                            break;
                        }
                    case Setting.Exit:
                        {
                            menu.Exit();
                            break;
                        }
                }

                ClearRange(cursorLocation.Top);

            };
            settingsMenu.Show();

           if(!this.SerializeToJson(out var json, out var exception ))
               exception.ThrowIfNotNull();
           
           File.WriteAllText(Settings.SETTINGS_FILENAME, json);

            WriteLinePlus("Settings saved.", pressEnterToContinue: true);

            ClearRange(cursorLocation.Top);

            return true;
        }
        catch (Exception ex)
        {
            editSettingsException = ex;
            return false;
        }
    }

    /// <summary>
    /// Called when [update filename].
    /// </summary>
    /// <param name="cursorLocation">The cursor location.</param>
    /// <param name="updateFilenameException">The update filename exception.</param>
    /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
    /// <exception cref="System.Exception">Filename failed to update.</exception>
    private bool OnUpdateFilename((int Left, int Top) cursorLocation, out Exception? updateFilenameException)
    {
        updateFilenameException = default;

        try
        {
            SetPosition(cursorLocation);

            if (!Prompt("Please enter the filename you want to use without an extension.", out var response, allowPunctuation: false))
                throw new Exception($"Filename failed to update.");

            m_Settings.Filename = $"{response}.json";

            SetPosition(cursorLocation);

            WriteLinePlus($"Filename updated to '{m_Settings.Filename}.json'.", spacingBefore: 1, pressEnterToContinue: true);

            return true;
        }
        catch (Exception ex)
        {
            updateFilenameException = ex;
            return false;
        }
    }

    /// <summary>
    /// Called when [update background color].
    /// </summary>
    /// <param name="cursorLocation">The cursor location.</param>
    /// <param name="updateBackgroundColorException">The update background color exception.</param>
    /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
    private bool OnUpdateBackgroundColor((int Left, int Top) cursorLocation, out Exception? updateBackgroundColorException)
    {
        updateBackgroundColorException = default;

        try
        {
            SetPosition(cursorLocation);

            var colorPicker = new ConsoleColorMenu(m_Settings.BackgroundColor, m_Settings.ForegroundColor);
            colorPicker.MenuSystemItemEvent += (sender, args) =>
            {
                if (sender is not ConsoleColorMenu menu) return;

                m_Settings.BackgroundColor = (ConsoleColor)args.MenuItem;
                menu.Exit();
            };
            colorPicker.Show();

            SetPosition(cursorLocation);

            WriteLinePlus($"Background color has been changed to {m_Settings.BackgroundColor}.", spacingBefore: 1, pressEnterToContinue: true);

            return true;
        }
        catch (Exception ex)
        {
            updateBackgroundColorException = ex;
            return false;
        }
    }

    /// <summary>
    /// Called when [update foreground color].
    /// </summary>
    /// <param name="cursorLocation">The cursor location.</param>
    /// <param name="updateForegroundColorException">The update foreground color exception.</param>
    /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
    private bool OnUpdateForegroundColor((int Left, int Top) cursorLocation, out Exception? updateForegroundColorException)
    {
        updateForegroundColorException = default;

        try
        {
            SetPosition(cursorLocation);

            var colorPicker = new ConsoleColorMenu(m_Settings.BackgroundColor, m_Settings.ForegroundColor);
            colorPicker.MenuSystemItemEvent += (sender, args) =>
            {
                if (sender is not ConsoleColorMenu menu) return;

                m_Settings.ForegroundColor = (ConsoleColor)args.MenuItem;
                menu.Exit();
            };
            colorPicker.Show();

            SetPosition(cursorLocation);

            WriteLinePlus($"Foreground color has been  changed to {m_Settings.ForegroundColor}.", spacingBefore: 1, pressEnterToContinue: true);

            return true;
        }
        catch (Exception ex)
        {
            updateForegroundColorException = ex;
            return false;
        }
    }

    /// <summary>
    /// Called when [update automatic save].
    /// </summary>
    /// <param name="cursorLocation">The cursor location.</param>
    /// <param name="updateAutoSaveException">The update automatic save exception.</param>
    /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
    private bool OnUpdateAutoSave((int Left, int Top) cursorLocation, out Exception? updateAutoSaveException)
    {
        updateAutoSaveException = default;

        try
        {
            m_Settings.AutoSave = YesNoPrompt("Enable Auto Save?");

            var autoSaveStatus = m_Settings.AutoSave ? "Enabled" : "Disabled";

            WriteLinePlus($"Auto Save is {autoSaveStatus}.", pressEnterToContinue: true);

            return true;
        }
        catch (Exception ex)
        {
            updateAutoSaveException = ex;
            return false;
        }
    }

    /// <summary>
    /// The m settings
    /// </summary>
    private readonly Settings m_Settings;

    /// <summary>
    /// Gets the settings.
    /// </summary>
    /// <value>The settings.</value>
    public Settings Settings
        => m_Settings;

    #endregion
}