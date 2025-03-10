using Journal.Enums;
using SpartanMenuSystems.EventArgs;
using SpartanMenu = SpartanMenuSystems.SpartanMenu;

namespace Journal;

class Program
{
    private static readonly Journal sm_MyJournal = new();
    private static readonly string sm_Title = "W02 Project: Journal Program";
    
    static void Main(string[] args)
    {
        var menu = new SpartanMenu(sm_Title, "Please select one of the following options:", SpartanMenuEvent);
        
        menu.Run([MenuItem.LoadFromFile, SpartanMenu.SpartanMenuItem.Exit], selectedForegroundColor: ConsoleColor.DarkRed);
    }

    private static void SpartanMenuEvent(object sender, SpartanMenuEventArgs e)
    {
        if (sender is not SpartanMenu spartanMenu)
        {
            Console.WriteLine("Invalid Menu Object!");
            return;
        }

        Console.CursorVisible = false;
        var skipReadLine = false;

        if (spartanMenu.IsExit(e))
        {
            spartanMenu.Exit();
        }
        else
        {
            Console.Clear();

            if (Enum.TryParse(e.MenuItem.Replace(" ", ""), out MenuItem menuItem))
            {
                switch (menuItem)
                {
                    case MenuItem.AddEntry:

                        NewScreen(sm_Title);

                        var journalEntry = sm_MyJournal.NewJournalEntry();

                        Console.CursorVisible = true;

                        Console.WriteLine(journalEntry.PromptText);
                        journalEntry.EntryText = Console.ReadLine();

                        sm_MyJournal.AddEntry(journalEntry);

                        skipReadLine = true;

                        break;
                    case MenuItem.DisplayAll:

                        NewScreen(sm_Title);

                        sm_MyJournal.DisplayAll();

                        break;
                    case MenuItem.SaveToFile:

                        NewScreen(sm_Title);

                        if (sm_MyJournal.SaveToFile(global::Journal.Journal.JOURNAL_FILE))
                        {
                            Console.WriteLine("Journal saved successfully!");
                        }

                        break;
                    case MenuItem.LoadFromFile:

                        NewScreen(sm_Title);

                        if (sm_MyJournal.LoadFromFile(global::Journal.Journal.JOURNAL_FILE))
                        {
                            Console.WriteLine("Journal loaded successfully!");
                        }

                        spartanMenu.UpdateMenu([
                            MenuItem.AddEntry, MenuItem.DisplayAll, MenuItem.SaveToFile, MenuItem.LoadFromFile,
                            SpartanMenu.SpartanMenuItem.Exit
                        ]);

                        break;
                    default:
                        Console.WriteLine("Invalid Menu Item!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid Menu Item!");
            }

            if (!skipReadLine)
            {
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }
    }

    private static void NewScreen(string title)
    {
        Console.Clear();
        Console.WriteLine(title);
        Console.WriteLine();
    }
    
}