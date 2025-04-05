using System.Text;
using Mindfulness.Interfaces;

namespace Mindfulness.Base;

public abstract class ActivityBase(string name, string description, int duration = 30) : IActivityBase
{
    #region Methods

    protected string FormatToFit(string text)
    {
        var bufferWidth = Console.BufferWidth;
        var words = text.Split(' ');

        var stringBuilder = new StringBuilder();
        var lineLength = 0;

        foreach (var word in words)
        {
            if (lineLength + word.Length + 30 > bufferWidth)
            {
                stringBuilder.AppendLine();
                lineLength = 0;
            }
            
            stringBuilder.Append($"{word} ");

            lineLength += word.Length;
        }

        return stringBuilder.ToString();
    }

    public virtual bool Show(out Exception exception)
    {
        exception = default;

        try
        {
            ConsoleHelper.WriteLinePlus(Name, true, trailingLines:1);
            ConsoleHelper.WriteLinePlus(FormatToFit(Description), trailingLines:1);
            
            return true;
        }
        catch (Exception ex)
        {
            exception = ex;
            return false;
        }
    }

    #endregion

    /// <summary>
    /// The m random
    /// </summary>
    protected readonly Random m_Random = new();

    public string Name { get; } = name;

    public string Description { get; } = description;

    public int Duration { get; } = duration;
}