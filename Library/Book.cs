namespace Library
{
    class Book
    {

        // private variables
        private string title;
        private string author;
        private string isbn;
        private int noOfPages;

        // Title property to allow access
        // to the title private variable
        public string Title // Property
        {
            get { return title; } // Get method
            set { title = value; } // set method
        }
        public string Author
        {
            get { return author; } // Get method
            set { author = value; } // set method
        }
        public string ISBN
        {
            get { return isbn; } // Get method
            set { isbn = value; } // set method
        }
        public int NoOfPages
        {
            get { return noOfPages; } // Get method
            set { noOfPages = value; } // set method
        }

        // Constructor to add new book
        public Book(string bookTitle, string bookAuthor, string bookISBN, int bookNoOfPages)
        {
            this.title = bookTitle;
            this.author = bookAuthor;
            this.isbn = bookISBN;
            this.noOfPages = bookNoOfPages;
        }
        // Method to display information about a book
        public void DisplayInfo()
        {
            // Outbook the book information to the console
            Console.WriteLine($"Book information");
            Console.WriteLine($"----------------");
            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine($"Number of pages: {NoOfPages}");
            Console.WriteLine();
        }
    }
}
