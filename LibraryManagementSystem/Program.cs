using System;

class Program
{
    private const string DATA_FILE = "library_data.csv";

    static void Main(string[] args)
    {
        Library library = new Library();
        library.LoadFromFile(DATA_FILE);

        while (true)
        {
            Console.WriteLine("\nLibrary Management System");
            Console.WriteLine("1. Add a book");
            Console.WriteLine("2. Display all books");
            Console.WriteLine("3. Check out a book");
            Console.WriteLine("4. Return a book");
            Console.WriteLine("5. Save data");
            Console.WriteLine("6. Load data");
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddBook(library);
                    break;
                case "2":
                    library.DisplayAllBooks();
                    break;
                case "3":
                    CheckOutBook(library);
                    break;
                case "4":
                    ReturnBook(library);
                    break;
                case "5":
                    library.SaveToFile(DATA_FILE);
                    break;
                case "6":
                    library.LoadFromFile(DATA_FILE);
                    break;
                case "7":
                    library.SaveToFile(DATA_FILE);
                    Console.WriteLine("Data saved. Thank you for using the Library Management System. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

    }
}

    static void AddBook(Library library)
    {
        Console.Write("Enter book title: ");
        string title = Console.ReadLine();
        Console.Write("Enter book author: ");
        string author = Console.ReadLine();
        Console.Write("Enter book ISBN: ");
        string isbn = Console.ReadLine();

        Book book = new Book(title, author, isbn);
        library.AddBook(book);
    }

    static void CheckOutBook(Library library)
    {
        Console.Write("Enter the ISBN of the book to check out: ");
        string isbn = Console.ReadLine();
        library.CheckOutBook(isbn);
    }

    static void ReturnBook(Library library)
    {
        Console.Write("Enter the ISBN of the book to return: ");
        string isbn = Console.ReadLine();
        library.ReturnBook(isbn);
    }
}