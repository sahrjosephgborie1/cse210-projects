using System; 
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        // Lists and Generics
        List<int> numbers; numbers = new List<int>();
        List<string> words; words = new List<string>();
        int sum = 0;
        int largestNumbber = 0;
        int smallestPositive = 1000;

        Console.Write("Enter number: ");
        string userInput = Console.ReadLine();
        int userNumber = int.Parse(userInput);

        // Ask the user for a series of numbers
        while (userNumber != 0)
        {
                // Append
            numbers.Add(userNumber);
            Console.Write("Enter number: ");
            userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);        
        }

        
        // Compute the sum 
        foreach (int number in numbers)
        {
            sum += number;

            // largest numbers
            if (number > largestNumbber)
            {
                largestNumbber = number;
            }
            
            // Smallest Positive number
            if (number >= 1)
            {
                if (number < smallestPositive)
                {
                    smallestPositive = number; 
                }
            }
        }
        // Compute the average of the numbers in the list.
        double average = (double)sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumbber}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        

        // sorting list
        numbers.Sort();
        // print sorted list
        Console.WriteLine("The sorted list is: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}