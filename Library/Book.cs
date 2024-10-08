namespace Library
{
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

        public void DisplayInfo()
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
    }
}
