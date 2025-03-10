using System.Globalization;
using Journal.Interfaces;

namespace Journal;

public class JournalEntry(string promptText) : IJournalEntry
{
    #region Overrides of DisplayBase

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {PromptText}");
        Console.WriteLine($"Entry: {EntryText}");
    }

    #endregion

    #region Implementation of IEntry

    public string Date { get; } = DateTime.Now.ToString(CultureInfo.InvariantCulture);
    public string PromptText { get; } = promptText;
    public string EntryText { get; set; }

    #endregion
}