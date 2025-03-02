//Author: Matthew D. Barker
//Course: CSE 210 : Programming with classes
//Assignment: C# Programming Exercise 3: Loops

class Program
{
    public class GuessThatNumber()
    {
        private static Random m_Random = new Random();

        #region Utility Code

        private string PromptUser(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        private void PressEnterToContinue()
        {
            Console.WriteLine("Please press enter...");
            Console.ReadLine();
        }

        private int PropmptUserForInteger(string prompt = "", int minimum = 0, int maximum = 100)
        {
            prompt = prompt == string.Empty ? $"Please enter a value between'{minimum}' and '{maximum}'." : prompt;

            if (maximum <= minimum)
                throw new ArgumentException($"Maximum must be greater than minimum. Minimum: {minimum} and Maximum: {maximum} provided.");

            while (true)
            {
                Console.Clear();
                var userInput = PromptUser(prompt);

                if (int.TryParse(userInput, out var value))
                {
                    if (value >= minimum && value <= maximum)
                        return value;
                }

                Console.WriteLine($"'{userInput}' is an invalid value.");
                PressEnterToContinue();

            }
        }

        private string PropmtUserForString(string prompt, bool caseInsensitive = false, params string[] parameters)
        {
            while (true)
            {
                Console.Clear();
                var userInput = PromptUser(prompt);

                var value = caseInsensitive ? userInput.ToUpper() : userInput;

                foreach (var parameter in parameters)
                {
                    if ((caseInsensitive ? parameter.ToUpper() : parameter) != value)
                        continue;

                    return userInput;
                }

                Console.WriteLine($"'{userInput}' is an invalid value.");
                PressEnterToContinue();
            }
        }

        private void AddLines(int lineCount = 1)
        {
            for (var index = 0; index < lineCount; index++)
            {
                Console.WriteLine();
            }
        }

        #endregion

        public void Run()
        {
            while (true)
            {
                var magicNumber = m_Random.Next(1, 101);
                var guesses = 0;

                while (true)
                {
                    Console.Clear();

                    var guess = PropmptUserForInteger("Guess and number between 1 and 100!", 1);

                    guesses++;

                    if (guess == magicNumber)
                    {
                        AddLines();
                        Console.WriteLine($"Congratulations! The number was '{magicNumber}'. You guessed the number in {guesses} {(guesses > 1 ? "guesses" : "guess")}.");
                        PressEnterToContinue();
                        break;
                    }
                    else if (guess < magicNumber)
                    {
                        Console.WriteLine("You're a little low.");
                    }
                    else if (guess > magicNumber)
                    {
                        Console.WriteLine("You're a little high.");
                    }

                    PressEnterToContinue();
                }

                var userInput = PropmtUserForString("Would you like to play again? (Y/N)", true, "Y", "N").ToUpper();

                if (userInput == "N")
                {
                    AddLines(2);

                    Console.WriteLine("Goodbye! Have a blessed day.");

                    AddLines(2);

                    break;
                }

            }
        }
    }

    static void Main(string[] args)
    {
        new GuessThatNumber().Run();
    }
}