using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Reference references = new Reference("Proverbs", 3, 5,6);
        

        // scripture
        string script = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. 6 In all thy ways acknowledge him, and he shall direct thy paths.";
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