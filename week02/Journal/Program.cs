namespace Journal;

class Program
{
    private static Journal sm_MyJournal;
    private const string TITLE = "W02 Project: Journal Program";
    private const string JOURNAL_FILE = "MyJournal.json";
    private const string SETTINGS_FILENAME = "Settings.json";
    private const string WELCOME_TO_SETUP = "Welcome Journal to Setup";

    private static Settings sm_Settings;
    
    static void Main(string[] args)
    {
        try
        {
            if (HandleLoadingSettingsFile())
            {
                
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    private static bool HandleLoadingSettingsFile()
    {
        
    }

    private static bool HandleSettingsUpdate()
    {
    }

}