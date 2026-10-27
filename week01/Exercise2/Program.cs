using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine();

        // Ask the user for their grade percentage
        Console.Write("What is Your grade percentage? ");
        string userInput = Console.ReadLine();

        // Convert to int
        int number = int.Parse(userInput);

        // convert to string
        //  int number = 42; string textVersion = number.ToString();
        
        // last digit
        int lastDigit = number % 10;

        // letter and sign Variables
        string letter;
        string sign;

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            // B
            letter = "B";
        }
        else if (number >= 70)
        {
            // C
            letter = "C";
        }
        else if (number >= 60)
        {
            // D
            letter = "D";
        }
        else
        {
            // Fail 
            letter = "F";
        }
        

        // add a separate if statement to determine if the user passed the course
        if (number >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else

        {
            Console.WriteLine("Better luck next time!");
        }

        // Last digit if statement
        if (number >= 90)
        {
            sign = ""; // No A+
        }
        else if (number < 60)
        {
            sign = ""; // No F+ or F-
        }
        else if (lastDigit >= 7)
        {
            sign = "+"; 
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        // Display the grade
        Console.WriteLine($"Grade: {letter}{sign}");
    }
}