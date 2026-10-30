using System;
using System.Formats.Asn1;
using System.IO.Pipelines;

class Program
{
    static void Main(string[] args)
    {
        // Name 
        DisplayMessage();
        string userName = PromptUserName();
        int favNumber = PromptUserNumber();
        int squared = SquareNumber(favNumber);
        DisplayResult(userName, squared);

        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string input = Console.ReadLine();
            
            return input;
        }

        // PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            
            return number;
        }

        // SquareNumber
        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }
        
        static void DisplayResult(string userName, int squaredNumber)
        {
            Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
        }
        
    }
}