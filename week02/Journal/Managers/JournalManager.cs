// ***********************************************************************
// Assembly        : Journal
// Author            : Matthew D. Barker
// Created           : 03-13-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-16-2025
// ***********************************************************************
// <copyright file="JournalManager.cs" company="Journal">
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
/// Class JournalManager.
/// Implements the <see cref="IJournalManager" />
/// </summary>
/// <seealso cref="IJournalManager" />
public class JournalManager : IJournalManager
{
    /// <summary>
    /// The title
    /// </summary>
    private const string TITLE = "W02 Project: Journal Program";

    #region Methods

    /// <summary>
    /// Initializes a new instance of the <see cref="JournalManager"/> class.
    /// </summary>
    public JournalManager()
    {
        if (!File.Exists(m_SettingManager!.Settings.Filename))
        {
            m_Journal = new Journal();
            return;
        }

        
    }

    /// <summary>
    /// Runs the specified exception.
    /// </summary>
    /// <param name="exception">The exception.</param>
    /// <returns><c>true</c> if the manager executes and returns properly, <c>false</c> otherwise.</returns>
    public bool Run(out Exception? exception)
    {
        exception = default;

        try
        {
            Console.CursorVisible = false;

            WriteLinePlus(TITLE, true);

            m_CursorPosition = Console.GetCursorPosition();

            var mainMenu = new ConsoleMenu(m_SettingManager!.Settings!.BackgroundColor, m_SettingManager!.Settings.ForegroundColor);
            mainMenu.MenuItems =
                [MenuItem.AddEntry, MenuItem.DisplayAll, MenuItem.LoadFromFile, MenuItem.SaveToFile, MenuItem.Settings, MenuItem.Exit];
            mainMenu.MenuSystemItemEvent += (sender, args) =>
            {
                if (sender is not ConsoleMenu menu) return;

                switch ((MenuItem)args.MenuItem)
                {
                    case MenuItem.AddEntry:
                        {
                            if (!OnAddEntrySelected(out var entryException))
                                entryException.ThrowIfNotNull();

                            break;
                        }
                    case MenuItem.DisplayAll:
                        {
                            if (!OnDisplayAllSelected(out var displayAllException))
                                displayAllException.ThrowIfNotNull();

                            break;
                        }
                    case MenuItem.LoadFromFile:
                        {
                            if (!OnLoadFromFileSelected(out var loadFromFileException))
                                loadFromFileException.ThrowIfNotNull();

                            break;
                        }
                    case MenuItem.SaveToFile:
                        {
                            if (!OnSaveToFileSelected(out var saveToFileException))
                                saveToFileException.ThrowIfNotNull();

                            break;
                        }
                    case MenuItem.Settings:
                        {
                            if (!OnSettingsSelected(out var settingsException))
                                settingsException.ThrowIfNotNull();

                            menu.SelectedBackgroundColor = m_SettingManager.Settings.BackgroundColor;
                            menu.SelectedForegroundColor = m_SettingManager.Settings.ForegroundColor;

                            break;
                        }
                    case MenuItem.Exit:
                        {
                            menu.Exit();

                            if (m_SettingManager.Settings.AutoSave)
                                if (!m_Journal.SerializeToJson(out string json, out var serializeException))
                                {
                                    WriteLinePlus($"Auto Save failed. Exception: {serializeException!.Message}", pressEnterToContinue: true);
                                }

                            break;
                        }
                }

                SetPosition(m_CursorPosition);
            };
            mainMenu.Show();

            return true;
        }
        catch (Exception ex)
        {
            exception = ex;
            return false;
        }
    }

    /// <summary>
    /// Called when [add entry selected].
    /// </summary>
    /// <param name="addEntryException">The add entry exception.</param>
    /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
    /// <exception cref="System.Exception">Cancelled By User.</exception>
    private bool OnAddEntrySelected(out Exception? addEntryException)
    {
        addEntryException = default;

        try
        {
            var journalEntry = m_Journal.NewJournalEntry();

            SetPosition(m_CursorPosition);

            if (!Prompt(journalEntry.PromptText, out var response))
                throw new Exception("Cancelled By User.");

            journalEntry.EntryText = response;

            if (!m_Journal.AddEntry(journalEntry, out var exception))
                exception.ThrowIfNotNull();

            SetPosition(m_CursorPosition);

            WriteLinePlus("Entry added successfully", pressEnterToContinue: true);

            return true;
        }
        catch (Exception ex)
        {
            addEntryException = ex;
            return false;
        }
    }

    /// <summary>
    /// Called when [display all selected].
    /// </summary>
    /// <param name="displayAllException">The display all exception.</param>
    /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
    private bool OnDisplayAllSelected(out Exception? displayAllException)
    {
        displayAllException = default;

        SetPosition(m_CursorPosition);

        if (!m_Journal.DisplayAll(out var exception))
            exception.ThrowIfNotNull();

        PressEnter();

        return true;
    }

    /// <summary>
    /// Called when [load from file selected].
    /// </summary>
    /// <param name="loadFromFileException">The load from file exception.</param>
    /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
    private bool OnLoadFromFileSelected(out Exception? loadFromFileException)
    {
        loadFromFileException = default;

        try
        {
            SetPosition(m_CursorPosition);

            var loadMenu = new ConsoleMenu(m_SettingManager!.Settings.BackgroundColor, m_SettingManager.Settings.ForegroundColor);
            loadMenu.MenuItems = [FileCommand.Import, FileCommand.Load, FileCommand.Exit];
            loadMenu.MenuSystemItemEvent += (sender, args) =>
            {
                if (sender is not ConsoleMenu menu) return;

                switch ((FileCommand)args.MenuItem)
                {
                    case FileCommand.Import:
                        {
                            if (!Prompt("What is the name of the file you want to import to without the extension?", out var response, allowPunctuation: false))
                                throw new Exception("Load Cancelled. ");

                            var filename = $"{response}.json";

                            if (!File.Exists(filename))
                                throw new FileNotFoundException(filename);

                            //Load from file
                            //if (!filename.Load<Journal>(out var journal, out var exception))
                            //    exception.ThrowIfNotNull();

                            //if (journal == null)
                            //{
                            //    WriteLinePlus("Journal empty.", pressEnterToContinue: true);
                            //    break;
                            //}

                            //if (!m_Journal.Merge(journal, out var mergeException))
                            //    mergeException.ThrowIfNotNull();

                            WriteLinePlus("Import completed successfully.", pressEnterToContinue: true);

                            break;
                        }
                    case FileCommand.Load:
                        {
                            SetPosition(m_CursorPosition);

                            WriteLinePlus("Warning any unsaved entries will be lost.", pressEnterToContinue: true);

                            if (!Prompt("What is the name of the file you want to import to without the extension?", out var response, allowPunctuation: false))
                                throw new Exception("Load Cancelled. ");

                            var filename = $"{response}.json";

                            if (!File.Exists(filename))
                                throw new FileNotFoundException(filename);

                            //Load from file
                            //if (!filename.Load(out m_Journal, out Exception? exception))
                            //    throw new FileLoadException(filename);

                            WriteLinePlus("Load completed successfully.", pressEnterToContinue: true);

                            break;
                        }
                    case FileCommand.Exit:
                        {
                            menu.Exit();

                            break;
                        }
                }

                ClearRange(m_CursorPosition.Top);

            };

            loadMenu.Show();

            return true;
        }
        catch (Exception ex)
        {
            loadFromFileException = ex;
            return false;
        }
    }

    /// <summary>
    /// Called when [save to file selected].
    /// </summary>
    /// <param name="saveToFileException">The save to file exception.</param>
    /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
    private bool OnSaveToFileSelected(out Exception? saveToFileException)
    {
        saveToFileException = default;

        try
        {
            SetPosition(m_CursorPosition);

            var saveMenu = new ConsoleMenu(m_SettingManager!.Settings.BackgroundColor, m_SettingManager.Settings.ForegroundColor);
            saveMenu.MenuItems = [FileCommand.Export, FileCommand.Save, FileCommand.Exit];
            saveMenu.MenuSystemItemEvent += (sender, args) =>
            {
                if (sender is not ConsoleMenu menu) return;

                SetPosition(m_CursorPosition);

                switch ((FileCommand)args.MenuItem)
                {
                    case FileCommand.Export:
                        {
                            if (Prompt("What is the name of the file you want to export to without the extension?", out var response, allowPunctuation: false))
                            {
                                //Save To File
                                //if (!response.Save($"{response}.json", out var exception, true))
                                //    exception.ThrowIfNotNull();

                                SetPosition(m_CursorPosition);

                                WriteLinePlus($"Journal export to '{response}.json' successfully.", pressEnterToContinue: true);
                            }

                            break;
                        }
                    case FileCommand.Save:
                        {
                            //Load To File
                            //if (!m_Journal.Save(m_SettingManager.Settings.Filename, out var saveException, true))
                            //    saveException.ThrowIfNotNull();

                            WriteLinePlus("Journal saved successfully.", pressEnterToContinue: true);

                            break;
                        }
                    case FileCommand.Exit:
                        {
                            menu.Exit();

                            break;
                        }
                }

                ClearRange(m_CursorPosition.Top);
            };

            saveMenu.Show();

            return true;
        }
        catch (Exception ex)
        {
            saveToFileException = ex;
            return false;
        }

    }

    /// <summary>
    /// Called when [settings selected].
    /// </summary>
    /// <param name="exception">The exception.</param>
    /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
    private bool OnSettingsSelected(out Exception? exception)
    {
        exception = default;

        try
        {
            if (!m_SettingManager!.Run(m_CursorPosition, out var settingsException))
                settingsException.ThrowIfNotNull();

            return true;
        }
        catch (Exception ex)
        {
            exception = ex;
            return false;
        }
    }

    #endregion

    #region Properties

    /// <summary>
    /// The m setting manager
    /// </summary>
    private readonly SettingsManager? m_SettingManager = new();
    /// <summary>
    /// The m journal
    /// </summary>
    private Journal m_Journal;
    /// <summary>
    /// The m cursor position
    /// </summary>
    private (int Left, int Top) m_CursorPosition;

    #endregion
}