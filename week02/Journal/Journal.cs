using System.Text.Json;
using System.Text.Json.Serialization;
using Journal.Converters;
using Journal.Interfaces;

namespace Journal;

public class Journal : IJournal
{
    public const string JOURNAL_FILE = "MyJournal.json";
    
    private IPromptGenerator PromptGenerator { get; } = new PromptGenerator();
    
    #region Overrides of DisplayBase

    public void DisplayAll()
    {
        foreach (var entry in m_Entries) entry.Display();
    }

    #endregion

    #region Implementation of IJournal

    private List<IJournalEntry> m_Entries { get; } = [];

    public void AddEntry(IJournalEntry entry)
        => m_Entries.Add(entry);

    public JournalEntry NewJournalEntry() 
        => new(PromptGenerator.GetRandomPrompt());

    public bool SaveToFile(string filename)
        => SaveToJson(filename);

    public bool LoadFromFile(string filename)
        => LoadFromJson(filename);

    #endregion

    private bool SaveToJson(string filename)
    {
        try
        {
            var json = System.Text.Json.JsonSerializer.Serialize(m_Entries,
                new System.Text.Json.JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(filename, json);
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal to JSON: {ex.Message}");
            return false;
        }
    }

    public bool LoadFromJson(string filename)
    {
        try
        {
            if (!File.Exists(filename))
            {
                m_Entries.Clear();
                return true;
            }
            var json = File.ReadAllText(filename);
            var options = new JsonSerializerOptions
            {
                Converters = { new JournalEntryConverter() }
            };
            var entries = JsonSerializer.Deserialize<List<IJournalEntry>>(json, options);
            
            if (entries != null)
            {
                m_Entries.Clear();
                m_Entries.AddRange(entries);
            }
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal from JSON: {ex.Message}");
            return false;
        }
    }


}