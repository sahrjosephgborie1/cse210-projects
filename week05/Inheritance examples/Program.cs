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

        // book 2
        PictureBook book2 = new PictureBook();
        book2.SetAuthor("Gborie");
        book2.SetTitle("Programming Language");

        // illustrator 
        book2.SetIllustrator("Fayia");

        Console.WriteLine(book2.GetBookInfo());
        Console.WriteLine(book2.GetPictureBookInfo());

        // book 3 and 4
        Book book3 = new Book("Edwards", "Another Book");
        Console.WriteLine(book3.GetBookInfo());

        PictureBook book4 = new PictureBook("Fayia", "Rokel Love", "Martha");
        Console.WriteLine(book4.GetPictureBookInfo());
        
    }
}