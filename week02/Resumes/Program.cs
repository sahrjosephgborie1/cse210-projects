using System;

class Program
{
    static void Main(string[] args)
    {
        // add resume
        Resume myResume = new Resume();
        Console.Write("Name: ");
        myResume._name = Console.ReadLine();

        // jobs
        Job job1 = new Job();

        // setting members Variables
        Console.Write("Job Title: ");
        job1._jobTitle = Console.ReadLine();
        Console.Write("Company: ");
        job1._company = Console.ReadLine();

        // start year
        Console.Write("Start Year: ");
        int startYear = int.Parse(Console.ReadLine());
        job1._startYear = startYear;

        // End year
        Console.Write("End Year: ");
        int endYear = int.Parse(Console.ReadLine());
        job1._endYear = endYear;

        // Second Job (Job2)
        Job job2 = new Job();
        // setting members variables
        job2._jobTitle = "Computer Science";
        job2._company = "Apple";
        job2._startYear = 2020;
        job2._endYear = 2023;

        // add job details to job
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Displaying variables
        myResume.DisplayResume();
        
    }
}