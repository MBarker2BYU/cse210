namespace Journal.Interfaces;

public interface IJournal
{
    public void AddEntry(IJournalEntry entry);

    public JournalEntry NewJournalEntry();
    
    public bool SaveToFile(string filename, out Exception exception);
    public bool LoadFromFile(string filename, out Exception exception);
    public void DisplayAll();
}