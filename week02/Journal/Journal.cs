using System.Text.Json;
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

    public bool SaveToFile(string filename, out Exception exception)
        => SaveToJson(filename, out exception);

    public bool LoadFromFile(string filename, out Exception exception)
        => LoadFromJson(filename, out exception);

    #endregion

    private bool SaveToJson(string filename, out Exception exception)
    {
        exception = default;
        
        try
        {
            var json = JsonSerializer.Serialize(m_Entries,
                new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(filename, json);
            return true;
        }
        catch (Exception ex)
        {
            exception = ex;
            return false;
        }
    }

    public bool LoadFromJson(string filename, out Exception exception)
    {
        exception = default;
        
        try
        {
            if (!File.Exists(filename))
            {
                m_Entries.Clear();
                throw new Exception($"File '{filename}' not found.");
            }
            var json = File.ReadAllText(filename);
            
            var options = new JsonSerializerOptions
            {
                Converters = { new JournalEntryConverter() }
            };
            
            var entries = JsonSerializer.Deserialize<List<IJournalEntry>>(json, options);

            if (entries == null) return true;
            
            m_Entries.Clear();
            m_Entries.AddRange(entries);
            
            return true;
        }
        catch (Exception ex)
        {
            exception = ex;
            
            return false;
        }
    }

}