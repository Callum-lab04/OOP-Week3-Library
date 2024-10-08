using Library;
class Program
{
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