class Book
{

    // Properties
    string Title;
    string Author;
    string ISBN;
    int NoOfPages;

    // Constructor for book object
    // add new instance of the book class
    public Book(string bookTitle, string bookAuthor, string bookISBN, int bookNoOfPages)
    {
        Title = bookTitle;
        Author = bookAuthor;
        ISBN = bookISBN;
        NoOfPages = bookNoOfPages;
    }

    void DisplayInfo()
    {
        // Outbook the book information to the console
        Console.WriteLine("Book information");
        Console.WriteLine("----------------");
        Console.WriteLine($"Book Title: {Title}");
        Console.WriteLine($"Book Author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");
        Console.WriteLine($"Number of pages: {NoOfPages}");
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        // Create a new instance of the book class
        Book book = new Book("C# for beginners", "Bill Gates", "12345", 200);

        // another instance?
        Book book2 = new Book("Visual Studio 2022", "Microsoft", "123", 70);

        // Output book information to the console
        book.DisplayInfo();
        book2.DisplayInfo();

    }
}