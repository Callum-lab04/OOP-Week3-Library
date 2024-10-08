class Book
{
    string Title;
    string Author;
    string ISBN;
    int NoOfPages;
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
        Book book = new Book();

        book.Title = "C# for beginners";
        book.Author = "Bill Gates";
        book.ISBN = "12345";
        book.NoOfPages = 200;

        Book book2 = new Book();
        book2.Title = "C# Methods and Classes";
        book2.Author = "Microsoft";
        book2.ISBN = "234145";
        book2.NoOfPages = 50;

        // Output book information to the console
        book.DisplayInfo();
        book2.DisplayInfo();

    }
}