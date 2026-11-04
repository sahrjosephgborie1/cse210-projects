using System;
using System.IO.Pipes;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // // new person object
        // Person p1 = new Person();
        // // set variables
        // p1._firstName = "Mary";
        // p1._lastName = "Smith";
        // p1._age = 25;

        // Person p2 = new Person();
        // p2._firstName = "john";
        // p2._lastName = "Gborie";
        // p2._age = 30;


        // // list
        // List<Person> people = new List<Person>();

        // // add to list
        // people.Add(p1);
        // people.Add(p2);

        // // dispaly
        // foreach (Person p in people)
        // {
        //     Console.WriteLine(p._lastName);
        // }

        // SaveToFile(people);

        // read through the file
        List<Person> newPeople = ReadFromFile();

        foreach (Person p in newPeople)
        {
            Console.WriteLine(p._lastName);
        }
        
    }

    // create a funtion to save to a file
    public static void SaveToFile (List<Person> people)
    {
        // let me know the code is running
        Console.WriteLine("Saving the file...");

        string filename = "people.txt";

        
        //using (using (streamwriter)) system.io 
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Person p in people)
            {
                outputFile.WriteLine($"{p._firstName}~~{p._lastName}~~{p._age}");
            }
        }
        Console.WriteLine("File Sucessfully Saved.");
    }

    // New funtion to read through the file
    public static List<Person> ReadFromFile()
    {
        Console.WriteLine("Reading list from file...");

        List<Person> people = new List<Person>();
        string filename = "people.txt";

        // Read through a file
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            // Console.WriteLine(line);
            // line will have something like this: "Mary~~Smith~~25"
            string[] parts = line.Split("~~");

            // parts[0] - Mary
            // parts[1] - Smith
            // parts[2] - 25

            Person newperson = new Person();
            newperson._firstName = parts[0];
            newperson._lastName = parts[1];
            newperson._age = int.Parse(parts[2]);

            people.Add(newperson);
        }

        return people;
    }
}