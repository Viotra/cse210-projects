using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int numericPercentage = int.Parse(gradePercentage);

        char letterGrade;

        if (numericPercentage >= 90)
        {
            letterGrade = 'A';
        }
        else if (numericPercentage >= 80)
        {
            letterGrade = 'B';
        }
        else if (numericPercentage >= 70)
        {
            letterGrade = 'C';
        }
        else if (numericPercentage >= 60)
        {
            letterGrade = 'D';
        }
        else
        {
            letterGrade = 'F';
        }

        string gradeModifier = "";

        if (letterGrade == 'F')
        {

        }
        else if (letterGrade == 'A' && numericPercentage % 10 >= 7)
        {

        }
        else if (numericPercentage % 10 >= 7)
        {
            gradeModifier = "+";
        }
        else if (numericPercentage % 10 < 3)
        {
            gradeModifier = "-";
        }

        Console.WriteLine($"Your grade is {gradeModifier}{letterGrade}");

        if (numericPercentage >= 70)
        {
            Console.Write("Congratulations on passing the class!");
        }
        else
        {
            Console.Write("Make sure to keep studying and I'm sure you'll get it next time!");
        }
    }
}