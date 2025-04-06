using System;
using System.Reflection.Emit;

namespace EternalQuest;

class Program
{
    private static int sm_FaithPoints = 0;
    private static int sm_Level = 1;
    private static string sm_PlayerName = "";
    private static Random sm_Random = new Random();


    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Eternal Quest!");
        Console.Write("Enter your name: ");
        sm_PlayerName = Console.ReadLine();
        Console.WriteLine($"\nGreetings, {sm_PlayerName}! Your journey to return to our Father in Heaven begins...");
        
        DisplayHeader(true);

        var menu = new Sparta.Menu.ConsoleMenu();
        menu.MenuSystemItemEvent += (sender, eventArgs) =>
        {
            if (sender is not Sparta.Menu.ConsoleMenu consoleMenu) return;
            
            switch ((Enums.Action)eventArgs.MenuItem)
            {
                case Enums.Action.Pray:
                    {
                        var prayerPoints = sm_Random.Next(10, 21);
                        sm_FaithPoints += prayerPoints;

                        Console.WriteLine();
                        Console.WriteLine($"You kneel in prayer and feel peace. Gained {prayerPoints} Faith Points.");
                        CheckLevelUp();

                        break;
                    }
                case Enums.Action.ServeOthers:
                    {
                        var servicePoints = sm_Random.Next(15, 31);
                        sm_FaithPoints += servicePoints;

                        Console.WriteLine();
                        Console.WriteLine($"You help a neighbor in need. Gained {servicePoints} Faith Points.");
                        CheckLevelUp();

                        break;
                    }
                case Enums.Action.Study:
                    {
                        var studyPoints = sm_Random.Next(10, 21);
                        sm_FaithPoints -= studyPoints;

                        Console.WriteLine();
                        Console.WriteLine($"You study the scriptures. Gained {studyPoints} Faith Points.");
                        if (sm_FaithPoints < 0) sm_FaithPoints = 0;
                        CheckLevelUp();
                        break;
                    }
                case Enums.Action.FaceTrial:
                    {
                        FaceTrial();
                        break;
                    }
                case Enums.Action.Rest:
                    {

                        Console.WriteLine();
                        Console.WriteLine("You rest and reflect on your journey. Your spirit feels renewed.");
                        sm_FaithPoints += 5;

                        break;
                    }
                case Enums.Action.CheckProgress:
                    {
                        DisplayStatus();
                        break;
                    }
                case Enums.Action.Exit:
                    {
                        consoleMenu.Exit();
                        break;
                    }
            }

            if ((Enums.Action)eventArgs.MenuItem == Enums.Action.Exit) return;
            
            Console.WriteLine();
            PressEnterToContinue();

            DisplayHeader(true);
            
        };
        menu.Show(Enum.GetValues<Enums.Action>().Cast<Enum>());

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

    static void DisplayHeader(bool clear=false)
    {
        if(clear)
            Console.Clear();

        Console.WriteLine();
        Console.WriteLine("Choose your Action: ");
        Console.WriteLine();
    }

    static void DisplayStatus()
    {
        Console.WriteLine();
        Console.WriteLine("\n=== Player Status ===");
        Console.WriteLine($"Name: {sm_PlayerName}");
        Console.WriteLine($"Level: {sm_Level} - {GetLevelName()}");
        Console.WriteLine($"Faith Points: {sm_FaithPoints}");
        Console.WriteLine("=====================\n");
    }

    static void FaceTrial()
    {
        Console.WriteLine();
        Console.WriteLine("\nA trial stands before you! Will you face it? (y/n)");
        var answer = Console.ReadLine().ToLower();

        if (answer == "y")
        {
            var trialDifficulty = sm_Random.Next(1, 11);
            Console.WriteLine($"Trial Strength: {trialDifficulty}");
            if (sm_FaithPoints >= trialDifficulty * 10)
            {
                var reward = trialDifficulty * 15;
                sm_FaithPoints += reward;
                Console.WriteLine();
                Console.WriteLine($"Victory! You overcame the trial and gained {reward} Faith Points!");
                CheckLevelUp();
            }
            else
            {
                var loss = trialDifficulty * 5;
                sm_FaithPoints -= loss;

                Console.WriteLine();
                Console.WriteLine($"The trial overwhelmed you. Lost {loss} Faith Points.");
                if (sm_FaithPoints < 0) sm_FaithPoints = 0;
            }
        }
        else
        {
            Console.WriteLine("You step back from the trial, preserving your strength.");
        }
    }

    static string GetLevelName()
    {
        switch (sm_Level)
        {
            case 1: return "Seeker of Truth";
            case 2: return "Disciple of Faith";
            case 3: return "Servant of Charity";
            case 4: return "Overcomer of Trials";
            case 5: return "Saint of Light";
            default: return "Celestial Champion";
        }
    }

    static void CheckLevelUp()
    {
        var pointsNeeded = sm_Level * 50; // Level-up threshold increases per level
        if (sm_FaithPoints >= pointsNeeded)
        {
            sm_Level++;
            Console.WriteLine($"\nGlorious news, {sm_PlayerName}! You have ascended to Level {sm_Level}: {GetLevelName()}!");
            if (sm_Level >= 6)
            {
                Console.WriteLine("Congratulations! You have reached the Celestial Kingdom and returned to our Father in Heaven!");
                Environment.Exit(0);
            }
        }
    }

}