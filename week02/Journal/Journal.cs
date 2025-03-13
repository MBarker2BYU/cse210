using System.Text.Json.Serialization;
using Journal.Interfaces;

namespace Journal;

public class Journal : IJournal
{
    #region Implementation of IJournal

    public void AddEntry(IJournalEntry entry)
        => m_JournalEntries.Add((JournalEntry)entry);

    public IJournalEntry NewJournalEntry()
        => new JournalEntry();

    public bool SaveToFile(string filename, out Exception exception)
    {
        throw new NotImplementedException();
    }

    public bool LoadFromFile(string filename, out Exception exception)
    {
        throw new NotImplementedException();
    }

    public void DisplayAll()
    {
        foreach (var entry in m_JournalEntries)
        {
            entry.Display();
            Console.WriteLine(); // Add a blank line between entries for better readability
        }
    }

    #endregion
    [JsonInclude]
    private List<JournalEntry> m_JournalEntries = [];

}