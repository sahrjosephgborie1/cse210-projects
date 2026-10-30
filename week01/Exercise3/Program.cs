using System;
    // Guess My Number Game
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.WriteLine("Guess My Number Game");     


        // Random Number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 301);
        

        // guesscount
        int guessCount = 0;

        while (true)
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            int numberGuess = int.Parse(guess);

            if (numberGuess == magicNumber)
            {
                Console.WriteLine("You guessed it!");
                guessCount = guessCount + 1;
                Console.WriteLine($" Congrats! Your guessed Count: {guessCount}");
                Console.WriteLine();
            }
            else if (numberGuess < magicNumber)
            {
                guessCount = guessCount + 1;
                Console.WriteLine($"Higher, guessed Count: {guessCount}");
                continue;
            }
            else if (numberGuess > magicNumber)
            {
                guessCount = guessCount + 1;
                Console.WriteLine($"Lower, guessed Count: {guessCount}");
                continue;
            }

            // Play again
            while (true)
            {
                Console.Write("Do you want to continue? (yes/no): ");
                string response = Console.ReadLine().ToLower();
                
                if (response == "yes" || response == "y")
                {
                    Random randomGen = new Random();
                    magicNumber = randomGen.Next(1, 301);
                    guessCount = 0;
                    break;
                }
                else if (response == "no" || response == "n")
                {
                    Console.WriteLine("Goodbye!");
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid Input!");
                    continue;
                }
            }
        }
    }
    
}