using System;
using System.Runtime;

class Program
{
    static void Main(string[] args)
    {
        int userResponse = 0;
        while (userResponse != 4)
        {
            
            // Exceeding Requirements:
            // 1. Non-Repeating Question Pool: In ReflectingActivity, a secondary list (_unusedQuestions)
            // tracks remaining questions so every question is asked once before any question repeats
            // during longer sessions.
            // Field-Level Random Instance & Empty-Input Filtering: Reused a single Random instance at the
            // class level for better randomness, and filtered out blank/whitespace entries in
            // ListingActivity so accidental empty presses do not inflate the user's item count.
            

            Console.WriteLine("Menu Options:");
    
            Console.WriteLine("     1. Start breathing activity");
            Console.WriteLine("     2. Start reflecting activity");
            Console.WriteLine("     3. Start listing activity");
            Console.WriteLine("     4. Quit");
            Console.Write("Select a choice from the menu: ");

            userResponse = int.Parse(Console.ReadLine());
            if (userResponse == 4)
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else if (userResponse == 1)
            {
                // 1 Start breathing activity
                BreathingActivity breathingActivity1 = new BreathingActivity();
                breathingActivity1.Run();

            }
            else if (userResponse == 2)
            {
                ReflectingActivity reflectingActivity1 = new ReflectingActivity();
                reflectingActivity1.Run();
            }
            else if (userResponse == 3)
            {
                ListingActivity listingActivity1 = new ListingActivity();
                listingActivity1.Run();
            }
            else
            {
                Console.WriteLine("Invalid input!, try again.");
                continue;
            }
        }        
    }
    
}