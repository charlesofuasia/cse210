using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine();

        MathAssignment maths = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8 - 19");
        string summary = maths.GetSummary();
        string problem = maths.GetHomeworkList();
        Console.WriteLine(summary);
        Console.WriteLine(problem);
        Console.WriteLine();

        string title = "The Causes of World War II";

        WritingAssignment writing = new WritingAssignment("Mary Waters", "European History", title);
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());

    }
}