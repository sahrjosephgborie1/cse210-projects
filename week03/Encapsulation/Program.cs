using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
    
        Person person = new Person();
        string GetFormalSignature = person.GetFormalSignature();
        string InformalSignature = person.GetInformalSignature();

        Console.WriteLine(GetFormalSignature);
        Console.WriteLine(InformalSignature);

        person.SetFirstName("peter");
        Console.WriteLine(person.GetFirstName());
        
        Person p2 = new Person("King", "Josh");
        Person p3 = new Person("Mr. ", "Alpha", "Sankoh");
        Console.WriteLine(p3.GetFirstName());
    }
}