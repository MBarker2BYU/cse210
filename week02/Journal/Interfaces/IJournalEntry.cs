namespace Journal.Interfaces;

public interface IJournalEntry
{
    public string Date { get; }
    public string PromptText { get; }
    public string EntryText { get; }
    public void Display();
}