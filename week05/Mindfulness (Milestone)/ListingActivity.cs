using Mindfulness.Base;
using Mindfulness.Interfaces;
using Mindfulness.Sparta.ExtensionMethods;

namespace Mindfulness;

public sealed class ListingActivity : RandomPromptBase, IListingActivity
{
    private const string NAME = "Welcome to the Listing Activity.";
    private const string DESCRIPTION = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

    public ListingActivity() : base(NAME, DESCRIPTION)
    {
       Initialize();
    }
    
    private void Initialize()
    {
        Prompts.Add(new Prompt("Who are people that you appreciate?"));
        Prompts.Add(new Prompt("What are personal strengths of yours?"));
        Prompts.Add(new Prompt("Who are people that you have helped this week?"));
        Prompts.Add(new Prompt("When have you felt the Holy Ghost this month?"));
        Prompts.Add(new Prompt("Who are some of your personal heroes?"));

        Prompts.Reset();
    }

    public override bool Show(out Exception exception)
    {
        exception = default;

        try
        {
            if (!base.Show(out exception))
                exception.ThrowIfNotNull();

            Console.WriteLine();
            Console.WriteLine("Press enter to continue...");

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