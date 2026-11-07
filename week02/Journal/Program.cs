using System;
using System.IO.Pipes;
using System.Collections.Generic;
using System.IO;

class Program
{   
    // Exceeding Requirements (100%): Added custom Categories (e.g., Gratitude, Goals, Work) and a 1–5 Mood Rating
    static void Main(string[] args)
    {   
        // Journal
        Journal theJournal = new Journal();
        

        Console.WriteLine("Welcome to the Journal Program!");

        while (true)
        {
            
            Console.WriteLine("Please Select one of the following Choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string userInput = Console.ReadLine();
            int choice = int.Parse(userInput);

            if (choice == 1)
            {
                // Random prompt
                PromptGenerator newPromptGenerator = new PromptGenerator();
                string promptGenerator = newPromptGenerator.GetRandomPrompt();
                Console.WriteLine($"{promptGenerator} ");
                Console.Write("> ");
                
                // add promptText to entry
                // Entry
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

                // Added category and moodRating
                Console.WriteLine("What category is this entry? (e.g., Gratitude, Goals, Work, Personal): ");
                string category = Console.ReadLine();
                newEntry._Category = category;

                while (true)
                {   
                    // moodrating 
                    Console.Write("Rate your mood from 1 to 5: ");
                    string ratingResponse = Console.ReadLine();
                    int moodRating = int.Parse(ratingResponse);
                    if (moodRating >= 1 && moodRating <=5)
                    {
                        // add mood rating to entry
                        newEntry._moodRating = moodRating;

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please make sure it's a number between 1 and 5.");

                        continue;
                    }
                }

                // add entry to journal
                theJournal.AddEntry(newEntry);

                continue;
            }
            else if (choice == 2)
            {
                theJournal.DisplayAll();

                continue;
            }
            else if (choice == 3)
            {
                // read fromfile
                List<Entry> ReadFile = Journal.LoadFromFile();

                // add the fileRead to journal for displaying
                theJournal._entries = ReadFile;
                continue;
            }
            else if (choice == 4)
            {
                // call savetofile
                Journal.Savetofile(theJournal._entries);
                
                continue;
            }
            else if (choice == 5)
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