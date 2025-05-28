using System;
using System.Collections.Generic;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public override string ToString()
    {
        return $"{Title} by {Author}";
    }
}

public class Library
{
    public List<Book> Books { get; set; }

    public Library()
    {
        Books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
        Console.WriteLine($"{book} has been added to the library.");
    }

    public void RemoveBook(string title)
    {
        Book bookToRemove = Books.Find(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        if (bookToRemove != null)
        {
            Books.Remove(bookToRemove);
            Console.WriteLine($"{bookToRemove} has been removed from the library.");
        }
        else
        {
            Console.WriteLine($"Book with title '{title}' not found in the library.");
        }
    }

    public void DisplayBooks()
    {
        Console.WriteLine("Library Books:");
        foreach (Book book in Books)
        {
            Console.WriteLine($"- {book}");
        }
    }
}

public class Program
{
    public static void Main()
    {
        Library library = new Library();

        Console.WriteLine("Enter books to add (type 'done' to finish):");
        string title, author;
        while (true)
        {
            Console.Write("Enter book title (or 'done' to finish): ");
            title = Console.ReadLine();
            if (title.ToLower() == "done") break;

            Console.Write("Enter book author: ");
            author = Console.ReadLine();

            Book book = new Book(title, author);
            library.AddBook(book);
        }

        library.DisplayBooks();

        Console.WriteLine("Enter book titles to remove (type 'done' to finish):");
        while (true)
        {
            Console.Write("Enter book title to remove (or 'done' to finish): ");
            title = Console.ReadLine();
            if (title.ToLower() == "done") break;

            library.RemoveBook(title);
        }

        library.DisplayBooks();
    }
}
