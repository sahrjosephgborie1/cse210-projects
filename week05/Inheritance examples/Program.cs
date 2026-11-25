using System;
using library_demo;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the an example of Inheritance Project.");
        
        // New book
        Book book1 = new Book();
        // set author and title
        book1.SetAuthor("Smith");
        book1.SetTitle("A Great Book");

        Console.WriteLine(book1.GetBookInfo());
    }
}