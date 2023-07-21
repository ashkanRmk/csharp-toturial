using System;

// Abstraction: Define a base Book class with common properties and methods
abstract class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }

    public Book(string title, string author, int pages)
    {
        Title = title;
        Author = author;
        Pages = pages;
    }

    // Abstract method to get additional information about the book
    public abstract void GetAdditionalInfo();

    // Common method to display basic information about the book
    public void DisplayBasicInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Pages: {Pages}");
    }
}

// Derived classes for specific book types
class FictionBook : Book
{
    public string Genre { get; set; }

    public FictionBook(string title, string author, int pages, string genre) : base(title, author, pages)
    {
        Genre = genre;
    }

    // Implementation of the abstract method for FictionBook
    public override void GetAdditionalInfo()
    {
        Console.WriteLine($"Genre: {Genre}");
    }
}

class NonFictionBook : Book
{
    public string Topic { get; set; }

    public NonFictionBook(string title, string author, int pages, string topic) : base(title, author, pages)
    {
        Topic = topic;
    }

    // Implementation of the abstract method for NonFictionBook
    public override void GetAdditionalInfo()
    {
        Console.WriteLine($"Topic: {Topic}");
    }
}

class Library
{
    // Method to display information about all the books in the library
    public static void DisplayBooks(Book[] books)
    {
        foreach (var book in books)
        {
            Console.WriteLine("----------");
            book.DisplayBasicInfo();
            book.GetAdditionalInfo();
            Console.WriteLine("----------");
        }
    }
}

class Program
{
    static void Main()
    {
        // Create an array of books with different types
        Book[] libraryCatalog = new Book[]
        {
            new FictionBook("The Great Gatsby", "F. Scott Fitzgerald", 180, "Classic"),
            new FictionBook("Dune", "Frank Herbert", 412, "Science Fiction"),
            new NonFictionBook("Sapiens", "Yuval Noah Harari", 512, "History"),
            new NonFictionBook("Atomic Habits", "James Clear", 320, "Self-Help")
        };

        // Display information about all the books in the library
        Library.DisplayBooks(libraryCatalog);
    }
}
