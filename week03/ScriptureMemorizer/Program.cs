// Exceeding Requirements (Stretch Challenge):
// Added custom user input at the start of the program, allowing the user to enter 
// any book, chapter, verse (with support for an optional ending verse), and custom 
// scripture text to memorize instead of using a single hardcoded scripture.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        
        // get references
        Console.Write("Book: ");
        string book = Console.ReadLine();

        Console.Write("Chapter: ");
        int Chapter = int.Parse(Console.ReadLine());

        Console.Write("Verse: ");
        int verse = int.Parse(Console.ReadLine());


        Console.Write("Endverse: (if there's, if not, press enter): ");
        string endVerse = (Console.ReadLine());
        
        Reference references;
        if (string.IsNullOrWhiteSpace(endVerse))
        {
            references = new Reference(book, Chapter, verse);
        }
        else
        {
            int endverseInt = int.Parse(endVerse);
            references = new Reference(book, Chapter, verse, endverseInt);
        }
        

        // scripture
        Console.Write("Scripture Text: ");
        string script = Console.ReadLine();
        Scripture scripture = new Scripture(references, script);         
        

        // Display
        string displayText = scripture.GetDisplayText();
        Console.WriteLine(displayText);
        
        while (true)
        {
            
            // prompt
            Console.Write("\nPress enter to continue or type 'quit' to finish: ");
            string userInput = Console.ReadLine().ToLower().Trim();
            Console.Clear();
            
            if (userInput == "quit")
            {
                break;
            }            
            else
            {
                Random random = new Random();
                int generateRandomFigure = random.Next(1,10);

                scripture.HideRandomWords(generateRandomFigure);
                string hiddenWords = scripture.GetDisplayText();
                Console.WriteLine(hiddenWords);
                
            }
            if (scripture.IsCompletelyHidden())
            {
                break;
            }
        }
        
    }
}