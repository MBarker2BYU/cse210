using System.Text.Json.Serialization;
using Journal.Converters;
using Journal.Enums;
using SpartanSystems;
using SpartanSystems.Extensions;
using SpartanSystems.Menus;

namespace Journal;

class Program
{
    private static Journal sm_MyJournal;
    private const string TITLE = "W02 Project: Journal Program";
    private const string JOURNAL_FILE = "MyJournal.json";
    private const string SETTINGS_FILENAME = "Settings.json";
    
    private static Settings sm_Settings;
    
    static void Main(string[] args)
    {
        try
        {
            Utilities.WriteLinePlus(TITLE, true);

            var cursorPosition = Console.GetCursorPosition();

            if (HandleLoadingSettingsFile(cursorPosition))
            {
                if (File.Exists(sm_Settings.Filename))
                {
                    if(!sm_Settings.Filename.Load(out sm_MyJournal, out var exception, [new JournalEntryConverter()]))
                        exception.ThrowIfNotNull();
                }
                else
                {
                    sm_MyJournal = new Journal();
                }

                SetPosition(cursorPosition);
                var journalMenu = new ConsoleMenu();
                journalMenu.MenuSystemItemEvent += (sender, e) =>
                {
                    if (sender is not ConsoleMenu menu) return;

                    SetPosition(cursorPosition);
                    
                    switch ((MenuItem)e.MenuItem)
                    {
                        case MenuItem.AddEntry:
                        {
                            var newJournalEntry = sm_MyJournal.NewJournalEntry();
                            if(Utilities.Prompt(newJournalEntry.PromptText, out var response))
                                newJournalEntry.EntryText = response;
                                
                            sm_MyJournal.AddEntry(newJournalEntry);
                            
                            break;
                        }
                        case MenuItem.DisplayAll:
                        {
                            SetPosition(cursorPosition);
                            sm_MyJournal.DisplayAll();
                            
                            Utilities.PressEnter();
                            
                            break;
                        }
                        case MenuItem.LoadFromFile:
                        {
                            if (Utilities.Prompt(
                                    "Please enter the name of the file to load without the file extension.",
                                    out var response, allowPunctuation: false))
                            {
                                var filename = $"{response}.json";
                                if (!File.Exists(filename))
                                {
                                    SetPosition(cursorPosition);
                                        Utilities.WriteLinePlus($"File '{filename}' not found.",
                                        pressEnterToContinue: true);
                                }
                                else
                                {
                                    SetPosition(cursorPosition);
                                        Utilities.WriteLinePlus($"File '{filename}' successfully loaded.");
                                }
                            }
                            else
                            {
                                SetPosition(cursorPosition);
                                    Utilities.WriteLinePlus("Load Cancelled.", pressEnterToContinue: true);
                            }

                            break;
                        }
                        case MenuItem.SaveToFile:
                        {
                            if (Utilities.Prompt(
                                    "Please enter the name of the file to save without the file extension.",
                                    out var response, allowPunctuation: false))
                            {
                                if (!sm_MyJournal.Save(sm_Settings.Filename, out var exception, true))
                                {
                                    exception.ThrowIfNotNull();
                                }
                                else
                                {
                                    SetPosition(cursorPosition);
                                    Utilities.WriteLinePlus("File saved successfully.", pressEnterToContinue: true);
                                }
                            }
                            else
                            {
                                SetPosition(cursorPosition);
                                Utilities.WriteLinePlus("Save Cancelled.", pressEnterToContinue: true);
                            }

                            break;
                        }
                        case MenuItem.Settings:
                        {

                            var settingsMenu = new ConsoleMenu();
                            settingsMenu.MenuSystemItemEvent += (sender, e) =>
                            {
                                if (sender is not ConsoleMenu settingsMenu) return;

                                SetPosition(cursorPosition);

                                switch ((Setting)e.MenuItem)
                                {
                                    case Setting.UpdateSettings:
                                    {
                                        HandleSettingsUpdate(cursorPosition);

                                        menu.SelectedBackgroundColor = sm_Settings.BackgroundColor;
                                        menu.SelectedForegroundColor = sm_Settings.ForeColor;
                                        
                                        break;
                                    }
                                    case Setting.ViewSettings:
                                    {
                                        sm_Settings.DisplaySettings();
                                        break;
                                    }
                                    case Setting.Exit:
                                    {
                                        settingsMenu.Exit();
                                        break;
                                    }
                                    default:
                                        break;
                                }

                                SetPosition(cursorPosition);
                            };
                            
                            settingsMenu.MenuItems = [Setting.UpdateSettings, Setting.ViewSettings, Setting.Exit];
                            settingsMenu.Show();
                            
                            break;
                        }
                        case MenuItem.Exit:
                        {
                            menu.Exit();

                            if (sm_Settings.AutoSave)
                                sm_MyJournal.Save(sm_Settings.Filename, out _, true);
                            
                            break;
                        }
                        default:
                            break;
                    }

                    SetPosition(cursorPosition);

                };
                
                journalMenu.MenuItems = Enum.GetValues<MenuItem>().Cast<Enum>();
                journalMenu.SelectedBackgroundColor = sm_Settings.BackgroundColor;
                journalMenu.SelectedForegroundColor = sm_Settings.ForeColor;
                
                journalMenu.Show();

            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        finally
        {
            Utilities.WriteLinePlus("Have a blessed day!", true, 2, 2);
        }
    }

    private static bool HandleLoadingSettingsFile((int Left, int Top) currentPosition)
    {
        try
        {
            if (File.Exists(SETTINGS_FILENAME))
            {
                if (!SETTINGS_FILENAME.Load(out sm_Settings, out var exception))
                    exception.ThrowIfNotNull();
            }
            else
            {
                sm_Settings = new Settings{Filename = JOURNAL_FILE};
                if(!sm_Settings.Save(SETTINGS_FILENAME, out var exception , true))
                    exception.ThrowIfNotNull();
                
                Utilities.SetPosition(currentPosition);
                Utilities.WriteLinePlus("Default settings loaded.", pressEnterToContinue: true);
            }

            return true;
        }
        catch (Exception ex)
        {
            ex.ThrowIfNotNull();
            return false;
        }
    }

    private static bool HandleSettingsUpdate((int Left, int Top) currentPosition)
    {
        try
        {
            SetPosition(currentPosition);

            var settingsMenu = new ConsoleMenu();
            settingsMenu.MenuSystemItemEvent += (sender, args) =>
            {
                if(sender is not ConsoleMenu menu) return;
                
                switch (args.MenuItem)
                {
                    case Setting.Filename:
                        //HandleFilenameSetting();
                        break;
                    case Setting.BackgroundColor:
                        //HandleBackgroundColorSetting();
                        break;
                    case Setting.ForegroundColor:
                        //HandleForegroundColorSetting();
                        break;
                    case Setting.AutoSave:
                        //HandleAutoSaveSetting();
                        break;
                    case Setting.Exit:
                        menu.Exit();
                        break;
                }
            };
            settingsMenu.MenuItems = [Setting.Filename, Setting.BackgroundColor, Setting.ForegroundColor, Setting.AutoSave, Setting.Exit];
            settingsMenu.Show();

            return true;
        }
        catch (Exception ex)
        {
            ex.ThrowIfNotNull();
            return false;
        }
    }

    private static void SetPosition((int Left, int Top) cursorPosition, bool clear = true, int end = -1)
        => Utilities.SetPosition(cursorPosition, clear, end);

}