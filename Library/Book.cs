namespace Library
{
    class Book
    {

        // Properties
        private string Title;
        private string Author;
        private string ISBN;
        private int NoOfPages;

        // Title property to allow access
        // to the title private variable
        public string Title
        {
            get { return Title; } // Get method
            set { Title = value; } // set method
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
            get { return noofpages; } // Get method
            set { noofpages = value; } // set method
        }

        // Constructor for book object
        // add new instance of the book class
        public Book(string bookTitle, string bookAuthor, string bookISBN, int bookNoOfPages)
        {
            this.title = bookTitle;
            this.author = bookAuthor;
            this.isbn = bookISBN;
            this.noofpages = bookNoOfPages;
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
