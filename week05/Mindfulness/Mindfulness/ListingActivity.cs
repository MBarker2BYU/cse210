using Mindfulness.Base;
using Mindfulness.Sparta.ExtensionMethods;
using System.Threading.Tasks;
using static Mindfulness.Sparta.Helpers.ConsoleHelper;

namespace Mindfulness;

public class ListingActivity : RandomPromptBase
{
    private const string NAME = "Listing";
    private const string DESCRIPTION = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    
    #region Overrides of ActivityBase

    protected override bool RunActivity(out Exception exception)
    {
        exception = default!;

        try
        {
            if (!NumberPrompt(out _Duration, "How long would you like to perform this activity? (in seconds)"))
            {
                exception = new Exception("Invalid input");
                return false;
            }

            if (!_Prompts.GetRandomPrompt(_Random, out var prompt, out exception))
            {
                exception.ThrowIfNotNull();
                return false;
            }

            StandbyReadyBegin(top: 1, clear: true);

            WriteLinePlus("List as many thoughts below as possible given this prompt.", true, 1);
            WriteLinePlus(prompt.Text, leadingLines: 1);
            
            var timestamp = DateTime.Now;
            var entries = new List<string>();

            while (true)
            {
                var elapsedTime = DateTime.Now.Subtract(timestamp).TotalSeconds;

                if(elapsedTime > _Duration * 1000)
                    break;

                var input = ReadLine((_Duration * 1000) - (int)(elapsedTime * 1000));

                if(input == null)
                    break;

                entries.Add(input);
            }
            
            WriteLinePlus($"Outstanding! You completed {entries.Count} entries in {_Duration:#,##0} seconds of the {NAME} activity.", trailingLines: 1, clear: true);

            PressEnterToContinue();

            return true;
        }
        catch (Exception ex)
        {
            exception = ex;
            return false;
        }
    }

    #endregion

    public ListingActivity() : base(NAME, DESCRIPTION)
    {
        Initialize();
    }

    private void Initialize()
    {
        _Prompts.Add(new Prompt("Who are people that you appreciate?"));
        _Prompts.Add(new Prompt("What are personal strengths of yours?"));
        _Prompts.Add(new Prompt("Who are people that you have helped this week?"));
        _Prompts.Add(new Prompt("When have you felt the Holy Ghost this month?"));
        _Prompts.Add(new Prompt("Who are some of your personal heroes?"));

        _Prompts.Reset();
    }
}