using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

public class Library
{
    private List<Book> books;

    public Library()
    {
        books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine($"Book added: {book}");
    }

    public void DisplayAllBooks()
    {
        Console.WriteLine("Library Catalog:");
        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
    }

    public void CheckOutBook(string isbn)
    {
        var book = books.FirstOrDefault(b => b.ISBN == isbn && b.IsAvailable);
        if (book != null)
        {
            book.IsAvailable = false;
            Console.WriteLine($"Book checked out: {book}");
        }
        else
        {
            Console.WriteLine("Book not found or already checked out.");
        }
    }

    public void ReturnBook(string isbn)
    {
        var book = books.FirstOrDefault(b => b.ISBN == isbn && !b.IsAvailable);
        if (book != null)
        {
            book.IsAvailable = true;
            Console.WriteLine($"Book returned: {book}");
        }
        else
        {
            Console.WriteLine("Book not found or already available.");
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var book in books)
            {
                writer.WriteLine($"{book.Title},{book.Author},{book.ISBN},{book.IsAvailable}");
            }
        }
        Console.WriteLine("Library data saved to file.");
    }

    public void LoadFromFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            books.Clear();
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 4)
                    {
                        Book book = new Book(parts[0], parts[1], parts[2]);
                        book.IsAvailable = bool.Parse(parts[3]);
                        books.Add(book);
                    }
                }
            }
            Console.WriteLine("Library data loaded from file.");
        }
        else
        {
            Console.WriteLine("No existing library data file found.");
        }
    }
}