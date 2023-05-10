using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment something = new Assignment("Tim", "Distance Formula");
        Console.WriteLine(something.GetSummary().Item1 + " - " + something.GetSummary().Item2);

        MathAssignment mathAssignment = new MathAssignment("Alex", "Algebra", "18.3", "Problem 1 - 35 (Odd Numbers Only)");
        Console.Write(mathAssignment.GetSummary().Item1 + " - " + mathAssignment.GetSummary().Item2 + " ");
        Console.WriteLine(mathAssignment.GetHomeworkList()[0] + ": " + mathAssignment.GetHomeworkList()[1]);

        WritingAssignment wAssignment = new WritingAssignment("Why Does the Albatross Fly", "Jenny", "Poetry");
        Console.WriteLine(wAssignment.GetSummary().Item1 + " - " + wAssignment.GetSummary().Item2 + " ");
        Console.WriteLine(wAssignment.GetWritingInformation().Item1 + " by " + wAssignment.GetWritingInformation().Item2);
    }
}