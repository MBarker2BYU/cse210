using Mindfulness.Base;
using Mindfulness.Interfaces;
using Mindfulness.Sparta.ExtensionMethods;

namespace Mindfulness;

public sealed class ReflectingActivity : RandomQuestionBase, IReflectingActivity
{
    private const string NAME = "Welcome to the Reflecting Activity.";
    private const string DESCRIPTION = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

    public ReflectingActivity() : base(NAME, DESCRIPTION)
    {
        Initialize();
    }
    
    private void Initialize()
    {
        Prompts.Add(new Prompt("Think of a time when you stood up for someone else."));
        Prompts.Add(new Prompt("Think of a time when you did something really difficult."));
        Prompts.Add(new Prompt("Think of a time when you helped someone in need."));
        Prompts.Add(new Prompt("Think of a time when you did something truly selfless."));

        Questions.Add(new Prompt("Why was this experience meaningful to you?"));
        Questions.Add(new Prompt("Have you ever done anything like this before?"));
        Questions.Add(new Prompt("How did you get started?"));
        Questions.Add(new Prompt("How did you feel when it was complete?"));
        Questions.Add(new Prompt("What made this time different than other times when you were not as successful?"));
        Questions.Add(new Prompt("What is your favorite thing about this experience?"));
        Questions.Add(new Prompt("What could you learn from this experience that applies to other situations?"));
        Questions.Add(new Prompt("What did you learn about yourself through this experience?"));
        Questions.Add(new Prompt("How can you keep this experience in mind in the future?"));

        Prompts.Reset();
        Questions.Reset();
    }

    public override bool Show(out Exception exception)
    {
        exception = default;

        try
        {
            if (!base.Show(out exception))
                exception.ThrowIfNotNull();

            

            
            ConsoleHelper.WriteLinePlus("Press enter to continue...");

            while (true)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                    break;
            }

            return true;
        }
        catch (Exception ex)
        {
            exception = ex;
            return false;
        }
    }
}