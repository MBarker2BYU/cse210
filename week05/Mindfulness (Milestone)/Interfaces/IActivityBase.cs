namespace Mindfulness.Interfaces;

public interface IActivityBase
{
    public string Name { get; }

    public string Description { get; }

    public int Duration { get; }
    
    public bool Show(out Exception exception);
}