using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();

        // setting members Variables
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // Second Job (Job2)
        Job job2 = new Job();
        // setting members variables
        job2._jobTitle = "Computer Science";
        job2._company = "Apple";
        job2._startYear = 2020;
        job2._endYear = 2023;


        // add resume
        Resume myResume = new Resume();

        // add job details to job
        myResume._name = "Sahr Joseph Gborie";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Displaying variables
        myResume.DisplayResume();
        Console.WriteLine("Jobs:");
        job1.DisplayJobDetails();
        job2.DisplayJobDetails();
        // Console.WriteLine($"{myResume._jobs[0]._jobTitle}");
        
        
    }
}