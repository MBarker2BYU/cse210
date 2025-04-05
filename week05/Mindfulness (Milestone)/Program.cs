using Mindfulness.Enums;
using Mindfulness.Interfaces;
using Mindfulness.Sparta.ExtensionMethods;
using Mindfulness.Sparta.Menus;

namespace Mindfulness;

class Program
{
    private static bool ExitMessage()
    {
        ConsoleHelper.WriteLinePlus("Thank you! Have a blessed day!", true, 2, 2);

        return true;
    }

    static void Main(string[] args)
    {
        
        var activities = new Dictionary<MenuOption, IActivityBase>
        {
            { MenuOption.StartBreathingActivity, new BreathingActivity() },
            { MenuOption.StartReflectingActivity, new ReflectingActivity() },
            { MenuOption.StartListingActivity, new ListingActivity() }
        };

        var menu = new ConsoleMenu();
        menu.MenuSystemItemEvent += (sender, eventArgs) =>
        {
            if (sender is not ConsoleMenu consoleMenu) return;

            switch ((MenuOption)eventArgs.MenuItem)
            {
                case MenuOption.StartBreathingActivity:
                case MenuOption.StartReflectingActivity:
                case MenuOption.StartListingActivity:
                {
                    if (!activities[(MenuOption)eventArgs.MenuItem].Show(out var exception))
                        exception.ThrowIfNotNull();

                    Console.Clear();

                    break;
                }
                case MenuOption.Quit:
                {
                    consoleMenu.Exit();
                    break;
                }
            }

        };
        menu.Show(Enum.GetValues<MenuOption>().Cast<Enum>());

        ExitMessage();


    }
}