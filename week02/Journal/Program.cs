using System;
using System.IO.Pipes;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {   
        // Journal
        Journal myjournal = new Journal();
        
        // Random prompt
        PromptGenerator newPromptGenerator = new PromptGenerator();
        string promptGenerator = newPromptGenerator.GetRandomPrompt();
        Console.WriteLine($"{promptGenerator} ");
        Console.Write("> ");
        
        // add promptText to entry
        Entry newEntry = new Entry();
        newEntry._promtText = promptGenerator;
        string promttextFromentry = newEntry._promtText;
        
        // add entry text to entry
        string response = Console.ReadLine();
        newEntry._entryText = response;

        // add current date to entry
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        newEntry._date = dateText;

        // add entry to journal
        myjournal._entries.Add(newEntry);

        newEntry.Display();
        myjournal.DisplayAll();
    }
}