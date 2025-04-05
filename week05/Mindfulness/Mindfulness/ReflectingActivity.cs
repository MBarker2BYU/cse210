using Mindfulness.Base;
using Mindfulness.Sparta.ExtensionMethods;
using static Mindfulness.Sparta.Helpers.ConsoleHelper;

namespace Mindfulness;

public sealed class ReflectingActivity : RandomQuestionBase
{
    private const string NAME = "Reflecting";
    private const string DESCRIPTION = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    
    #region Overrides of ActivityBase

    protected override bool RunActivity(out Exception exception)
    {
        exception = default!;

        try
        {
            if(!NumberPrompt(out _Duration, "How long would you like to perform this activity? (in seconds)"))
            {
                exception = new Exception("Invalid input");
                return false;
            }
            
            if(!_Prompts.GetRandomPrompt(_Random, out var prompt, out exception))
            {
                exception.ThrowIfNotNull();
                return false;
            }

            WriteLinePlus("With the following prompt in mind what are your thoughts?", true, 1);
            WriteLinePlus(prompt.Text, leadingLines:1);

            PressEnterToContinue();

            StandbyReadyBegin(top: 1, clear: true);

            var timestamp = DateTime.Now;

            while (true)
            {
                if(DateTime.Now.Subtract(timestamp).TotalSeconds >= _Duration)
                    break;
                
                if (!_Questions.GetRandomPrompt(_Random, out var question, out exception))
                {
                    exception.ThrowIfNotNull();
                    return false;
                }

                WriteLinePlus(question.Text, leadingLines: 1);

                Thread.Sleep(3000);
            }

            WriteLinePlus($"Outstanding!  You completed {_Duration:#,##0} seconds of the {NAME} activity.", trailingLines: 1, leadingLines: 1);

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

    /// <summary>
    /// Initializes a new instance of the <see cref="ReflectingActivity"/> class.
    /// </summary>
    public ReflectingActivity() : base(NAME, DESCRIPTION)
    {
        Initialize();
    }

    /// <summary>
    /// Initializes this instance.
    /// </summary>
    private void Initialize()
    {
        _Prompts.Add(new Prompt("Think of a time when you stood up for someone else."));
        _Prompts.Add(new Prompt("Think of a time when you did something really difficult."));
        _Prompts.Add(new Prompt("Think of a time when you helped someone in need."));
        _Prompts.Add(new Prompt("Think of a time when you did something truly selfless."));

        _Questions.Add(new Prompt("Why was this experience meaningful to you?"));
        _Questions.Add(new Prompt("Have you ever done anything like this before?"));
        _Questions.Add(new Prompt("How did you get started?"));
        _Questions.Add(new Prompt("How did you feel when it was complete?"));
        _Questions.Add(new Prompt("What made this time different than other times when you were not as successful?"));
        _Questions.Add(new Prompt("What is your favorite thing about this experience?"));
        _Questions.Add(new Prompt("What could you learn from this experience that applies to other situations?"));
        _Questions.Add(new Prompt("What did you learn about yourself through this experience?"));
        _Questions.Add(new Prompt("How can you keep this experience in mind in the future?"));

        _Prompts.Reset();
        _Questions.Reset();
    }

}