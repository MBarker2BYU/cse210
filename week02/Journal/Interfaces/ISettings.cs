namespace Journal.Interfaces;

public interface ISettings
{
    public string Filename { get; set; }

    public ConsoleColor BackgroundColor { get; set; }
    
    public ConsoleColor ForeColor { get; set; }

    public bool AutoSave { get; set; }
}