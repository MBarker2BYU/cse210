using System.Text;
using Mindfulness.Sparta.ExtensionMethods;
using Mindfulness.Sparta.Helpers;

namespace Mindfulness.Base;

public abstract class ActivityBase(string name, string description)
{
    private const string EXIT_MESSAGE = "Thank you for using this Mindfulness Activity. Keep up the good work!";

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

    protected abstract bool RunActivity(out Exception exception);
    
    public bool Show(out Exception exception)
    {
        exception = default!;

        try
        {
            ConsoleHelper.WriteLinePlus($"Welcome to the {Name} activity.", true, trailingLines:1);
            ConsoleHelper.WriteLinePlus(FormatToFit(Description), trailingLines:1);

            if(!RunActivity(out exception))
                exception.ThrowIfNotNull();

            ConsoleHelper.WriteLinePlus(EXIT_MESSAGE, true);

            ConsoleHelper.PressEnterToContinue();

            return true;
        }
        catch (Exception ex)
        {
            exception = ex;
            return false;
        }
    }

    #endregion
    
    protected string Name { get; } = name;

    protected string Description { get; } = description;

    protected int _Duration = 0;
}