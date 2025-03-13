using System.Globalization;
using Journal.Interfaces;

namespace Journal;

public class JournalEntry : IJournalEntry
{
    #region Implementation of IJournalEntry

    public string Date { get; } = DateTime.Now.ToString(CultureInfo.InvariantCulture);
    public string PromptText { get; } = "A prompt";
    public string EntryText { get; set; }
    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {PromptText}");
        Console.WriteLine($"Entry: {EntryText}");
    }

    #endregion
}