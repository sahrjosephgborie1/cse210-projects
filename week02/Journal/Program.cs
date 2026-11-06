using System;
using System.IO.Pipes;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // create prompts
        string p1 = "Who was the most interesting person I interacted with today? ";
        string p2 = "What was the best part of my day? ";
        string p3 = "How did I see the hand of the Lord in my life today? ";
        string p4 = "What was the strongest emotion I felt today? ";
        string p5 = "If I had one thing I could do over today, what would that be? ";

        // add to promtlist
        List<string> promptList = new List<string>();
        promptList.Add(p1);
        promptList.Add(p2);
        promptList.Add(p3);
        promptList.Add(p4);
        promptList.Add(p5);
        
        // prompt generator 
        Random randomgen = new Random();
        int randomGeneratorNumber = randomgen.Next(0, 5);

        // find the index in the list
        string randomGeneratorText = promptList[randomGeneratorNumber];
        // display the prompt
        Console.WriteLine(randomGeneratorText);

        // add promptText to entry
        Entry newEntry = new Entry();
        newEntry._promtText = randomGeneratorText;

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