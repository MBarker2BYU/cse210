using EternalQuest.Base;
using EternalQuest.Enums;
using EternalQuest.ExtensionMethods;
using Action = EternalQuest.Enums.Action;

namespace EternalQuest;

class Program
{
    private static Player sm_PlayerOne;
    private static readonly Dictionary<Action, ActionBase> sm_Actions = new();

    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to Eternal Quest!");
        Console.Write("Enter your name: ");

        sm_PlayerOne = new Player(Console.ReadLine());

        Console.WriteLine($"\nGreetings, {sm_PlayerOne.Name}! Your journey to return to our Father in Heaven begins...");

        DisplayHeader(true);

        var menu = new Sparta.Menu.ConsoleMenu();
        menu.MenuSystemItemEvent += (sender, eventArgs) =>
        {
            if (sender is not Sparta.Menu.ConsoleMenu consoleMenu) return;

            var action = (Action)eventArgs.MenuItem;

            switch (action)
            {
                case Action.Pray:
                case Action.ServeOthers:
                case Action.Study:
                case Action.FaceTrial:
                case Action.Rest:
                    {

                        if (!sm_Actions.ContainsKey(action))
                        {
                            switch (action)
                            {
                                case Action.Pray:
                                    sm_Actions.Add(action, new Pray());
                                    break;
                                case Action.Study:
                                    sm_Actions.Add(action, new Study());
                                    break;
                                case Action.ServeOthers:
                                    sm_Actions.Add(action, new ServeOthers());
                                    break;
                                case Action.FaceTrial:
                                    sm_Actions.Add(action, new FaceTrial());
                                    break;
                                case Action.Rest:
                                    sm_Actions.Add(action, new Rest());
                                    break;
                            }
                        }

                        sm_Actions[action].UpdatePlayer(sm_PlayerOne);

                        sm_Actions[action].DisplayActionMessage();

                        if (sm_PlayerOne.LevelUp)
                        {
                            if ((int)sm_PlayerOne.Level < (int)Level.TheCelestialVictory)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Congratulation! You have leveled up!");

                                Console.WriteLine();
                                Console.WriteLine($"You are now at level {sm_PlayerOne.Level.GetLevelDescription().Name}.");
                                Console.WriteLine($"Level Description: {sm_PlayerOne.Level.GetLevelDescription().Reward}");
                                Console.WriteLine($"You have {sm_PlayerOne.FaithPoints} Faith Points.");

                                sm_PlayerOne.ResetLevelUp();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine();
                                Console.WriteLine("Congratulations! You have reached the Celestial Victory!");
                                Console.WriteLine("You have completed your quest and returned to our Father in Heaven.");
                                Console.WriteLine("You are now at the highest level of faith and righteousness.");
                                Console.WriteLine($"You have {sm_PlayerOne.FaithPoints} Faith Points.");
                                Console.WriteLine();
                                Console.WriteLine("Thank you for playing Eternal Quest!");
                                Console.WriteLine();

                                PressEnterToContinue();

                                menu.Exit();
                            }
                        }

                        break;
                    }
                case Action.CheckProgress:
                    {
                        DisplayStatus();
                        break;
                    }
                case Action.LevelInformation:
                    {
                        LevelInformation();
                        break;
                    }
                case Action.Exit:
                    {
                        consoleMenu.Exit();
                        break;
                    }
            }

            if ((Action)eventArgs.MenuItem == Action.Exit) return;

            Console.WriteLine();
            PressEnterToContinue();

            DisplayHeader(true);

        };
        menu.Show(Enum.GetValues<Action>().Cast<Enum>());

        Console.Clear();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Thank you for playing! Have a blessed day!");
        Console.WriteLine();
        Console.WriteLine();

    }

    public static void PressEnterToContinue()
    {

        Console.WriteLine("Press enter to continue...");
        Console.WriteLine();

        while (true)
        {
            if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                break;

            Thread.Sleep(250);
        }
    }

    static void DisplayHeader(bool clear = false)
    {
        if (clear)
            Console.Clear();

        Console.WriteLine();
        Console.WriteLine("Choose your Action: ");
        Console.WriteLine();
    }

    static void DisplayStatus()
    {
        Console.WriteLine();
        Console.WriteLine("Player Status:");
        Console.WriteLine($"Name: {sm_PlayerOne.Name}");

        var description = sm_PlayerOne.Level.GetLevelDescription();

        Console.WriteLine($"Level: {description.Name}");
        Console.WriteLine($"Level Description: {description.Reward}");

        Console.WriteLine($"Faith Points: {sm_PlayerOne.FaithPoints}");

        //Console.WriteLine("\n=== Player Status ===");
        //Console.WriteLine($"Name: {sm_PlayerOne}");
        //Console.WriteLine($"Level: {sm_Level} - {GetLevelName()}");
        //Console.WriteLine($"Faith Points: {sm_FaithPoints}");
        //Console.WriteLine("=====================\n");
    }

    static void LevelInformation()
    {
        Console.WriteLine();
        Console.WriteLine("Level Information:");
        Console.WriteLine();

        foreach (Level level in Enum.GetValues(typeof(Level)))
        {
            var ld = level.GetLevelDescription();
            Console.WriteLine($"Level {(int)level}: {ld.Name}");
            Console.WriteLine($"Faith Points Required: {ld.FaithPointsRequired}");
            Console.WriteLine();
        }
    }

}