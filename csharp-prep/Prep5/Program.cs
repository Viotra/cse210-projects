using System;

class Program
{
    static void Welcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string UserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static double FavNumber()
    {
        Console.Write("Please enter your favorite number: ");
        double number = double.Parse(Console.ReadLine());
        return number;
    }

    static double SquareNumbers(double num)
    {
        double squaredNum = Math.Pow(num, 2);
        return squaredNum;
    }
    static void Main(string[] args)
    {
        string uName;
        double uNum;
        double squaredNum;

        Welcome();
        uName = UserName();
        uNum = FavNumber();
        squaredNum = SquareNumbers(uNum);

        Console.Write($"{uName}, the square of your number is {squaredNum}");       
        
    }
}