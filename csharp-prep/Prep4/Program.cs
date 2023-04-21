using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int uNumber;

        do
        {
            Console.Write("Please enter a number to add to our list. (To stop, enter 0.) ");
            uNumber = int.Parse(Console.ReadLine());
            
            if (uNumber != 0)
            {
                numbers.Add(uNumber);
            }
        }
        while (!(uNumber == 0));

        int sum = numbers.Sum();
        double average = numbers.Average();
        int max = numbers.Max();

        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

    }
}