using Homework;
using Homework.Interfaces;

class Program
{
    static void Main(string[] args)
    {

        var students = new List<IStudent>
        {
            new Student("Jonas", "Blane"),
            new Student("Kimberly", "Brown"),
            new Student("Mack", "Gerhardt")
        };


        Console.Clear();
        
        var assignment1 = new Assignment(students[0], "Quantum Mechanics");
        Console.WriteLine(assignment1.GetSummary());
        
        Console.WriteLine();
        
        var mathAssignment = new MathAssignment(students[1], "Trigonometry", "3:14", "7-13");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        Console.WriteLine();

        var writingAssignment = new WritingAssignment(students[2], "Combat Tactics","Tactics of George Patton" );
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());

    }
}