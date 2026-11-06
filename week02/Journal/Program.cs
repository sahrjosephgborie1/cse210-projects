using System;
using System.IO.Pipes;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Random prompt
        PromptGenerator newPromptGenerator = new PromptGenerator();
        string randomGeneratorText = newPromptGenerator.GetRandomPrompt();

        // add promptText to entry
        Entry newEntry = new Entry();
        newEntry._promtText = randomGeneratorText;
        
        // add prompttext to the list of promptgenerated
        PromptGenerator newPromptgen = new PromptGenerator();
        // to dooooooooooo
        

        // add current date to entry
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        newEntry._date = dateText;

        // add entry text to entry
        string textEntry = Console.ReadLine();
        newEntry._entryText = textEntry;

        newEntry.Display();
        
    }
}