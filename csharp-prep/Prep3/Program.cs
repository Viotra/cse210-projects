using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain;

        do{
            Random randomGenerator = new Random();
            int uNumber = randomGenerator.Next(1, 101);

            int uGuess;
            int guessCount = 0;

            do{
                Console.Write("What is your guess? ");
                uGuess = int.Parse(Console.ReadLine());
                guessCount++;

                if (uGuess > uNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (uGuess < uNumber)
                {
                    Console.WriteLine("Higher");
                }
                else{
                    Console.WriteLine($"Congratulations! You guessed the magic number in {guessCount} turn(s).");
                }
            }
            while (!(uGuess == uNumber));
            Console.WriteLine("Would you like to play again? (yes/no) ");
            playAgain = Console.ReadLine();
        }
        while (!(playAgain == "no"));
    }
}