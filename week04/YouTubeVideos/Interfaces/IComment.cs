namespace YouTubeVideos.Interfaces;

public interface IComment : IDisplay
{
    public IPerson Person { get; }
    
    public string Text { get; }
    
    public byte Stars { get; }
}