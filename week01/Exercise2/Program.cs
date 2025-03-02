//Author: Matthew D. Barker
//Course: CSE 210 : Programming with classes
//Assignment: C# Programming Exercise 2: If Statements


public class CalculateGrade()
{
    #region Constants

    public const int A_CUT_OFF = 90;
    public const int B_CUT_OFF = 80;
    public const int C_CUT_OFF = 70;
    public const int D_CUT_OFF = 60;

    public readonly int PASSING_GRADE = C_CUT_OFF;

    public const int PLUS_GRADE_CUT_OFF = 7;
    public const int MINUS_GRADE_CUT_OFF = 3;

    public const string UNSIGNED_GRADE = "";
    public const string PLUS_SIGNED_GRADE = "+";
    public const string MINUS_SIGNED_GRADE = "-";

    public const string PASSED_MESSAGE = "Congratulations! You passed";
    public const string FAILED_MESSAGE = "I'm sorry you failed";

    #endregion

    #region Utility Code

    private string PromptUser(string prompt)
    {
        Console.WriteLine(prompt);
        return Console.ReadLine();
    }

    private void AddLines(int lineCount = 1)
    {
        for (var index = 0; index < lineCount; index++)
        {
            Console.WriteLine();
        }
    }

    #endregion

    public string AorAn(string grade)
    {
        char base_grade = char.ToUpper(grade[0]);
        return (base_grade == 'A' || base_grade == 'F') ? "an" : "a";
    }

    public string SignGrade(double grade)
    {
        if (grade >= A_CUT_OFF + MINUS_GRADE_CUT_OFF || grade < D_CUT_OFF)
        {
            return UNSIGNED_GRADE;
        }

        // get the last digit
        int last_digit = ((int)grade) % 10;

        // check values agaist constants
        if (last_digit >= PLUS_GRADE_CUT_OFF)
        {
            return PLUS_SIGNED_GRADE;
        }
        else if (last_digit < MINUS_GRADE_CUT_OFF)
        {
            return MINUS_SIGNED_GRADE;
        }
        else
        {
            return UNSIGNED_GRADE;
        }
    }

    public void Run()
    {

        double score;

        while (true)
        {
            Console.Clear();

            var userInput = PromptUser("What score did you receive?");

            if (double.TryParse(userInput, out score))
            {
                if (score >= 0 && score <= 100)
                    break;
            }

            Console.WriteLine($"'{score}' is an invalid answer. Please enter a value between '0' and '100'.");
            Console.WriteLine($"Press enter to continue...");
            Console.ReadLine();
        }

        string grade = "F";

        if (score >= A_CUT_OFF)
        {
            grade = ($"A{SignGrade(score)}").Trim();
        }
        else if (score >= B_CUT_OFF)
        {
            grade = ($"B{SignGrade(score)}").Trim();
        }
        else if (score >= C_CUT_OFF)
        {
            grade = ($"C{SignGrade(score)}").Trim();
        }
        else if (score >= D_CUT_OFF)
        {
            grade = ($"D{SignGrade(score)}").Trim();
        }

        // Decide which const message to use
        string resultMessage = score >= PASSING_GRADE ? PASSED_MESSAGE : FAILED_MESSAGE;

        AddLines(2);

        // post the results
        Console.WriteLine($"{resultMessage} with {AorAn(grade)} {grade} ({score}%).");

        AddLines(2);

    }
}

class Program
{
    static void Main(string[] args)
    {
        new CalculateGrade().Run();
    }
}