
using Journal.Enums;
using Journal.Sparta.Menus;
using Journal.Sparta.Menus.EventArgs;

class Program
{
    public static void Main(string[] args)
    {
        
    
    }

    public static void PressEnter()
    {
        Console.WriteLine("Press Enter to continue...");
        while (Console.ReadKey(true).Key != ConsoleKey.Enter)
        {
            // Wait for the Enter key to be pressed
        }
    }

}