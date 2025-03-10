namespace Journal.Interfaces;

public interface IJournal
{
    public void AddEntry(IJournalEntry entry);

    public JournalEntry NewJournalEntry();
    
    public bool SaveToFile(string filename);
    public bool LoadFromFile(string filename);
    public void DisplayAll();
}