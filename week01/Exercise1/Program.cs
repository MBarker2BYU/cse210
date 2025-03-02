using System;

class Program
{
    static void Main(string[] args)
    {
        //Cleanup to look nice.
        Console.Clear();

        //Ask the user for their fisrt and last name.
        var firstName = Program.PromptUser("What is your first name?");
        var lastName = Program.PromptUser("What is your last name?");

        //Format their answers in to a response.
        Console.WriteLine($"Your name is {firstName}, {firstName} {lastName}.");
    }

    //Reusable Code
    private static string PromptUser(string prompt)
    {
        Console.WriteLine(prompt);
        return Console.ReadLine();
    }
}