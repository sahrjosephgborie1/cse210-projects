using System;

class Program
{
    static void Main(string[] args)
    {
        // This is a comment
        Console.WriteLine("Hello World! This is the Exercise1 Project..");
        // Console.Write("There will not be a Newline after this.");

        //display a prompt and get user input
        Console.Write("What is your first name? ");
        string firstname = Console.ReadLine();

        // Last name
        Console.Write("What is your last name? ");
        string lastname = Console.ReadLine();

        

        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}.");

    }
}