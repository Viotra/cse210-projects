using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int uNumber = randomGenerator.Next(1, 100);

        int uGuess;

        do{
            Console.Write("What is your guess? ");
            uGuess = int.Parse(Console.ReadLine());

            if (uGuess > uNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (uGuess < uNumber)
            {
                Console.WriteLine("Higher");
            }
            else{
                Console.Write("Congratulations!");
            }
        }
        while (!(uGuess == uNumber));
    }
}