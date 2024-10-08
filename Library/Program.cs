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
        Console.WriteLine("Currently available books");
        book.DisplayInfo();
        book2.DisplayInfo();

        /* Create new instances of the member class
         * These new members are created using the
         * member constructor in the Members class
         */
        Member member = new Member(1, "John Smith", "1 High Street", 0790090090);
        // Create second instance of Member class
        Member member1 = new Member(2, "Mary Jones", "102 Garden Road", 0734662991);

        Console.WriteLine("Current library members");
        member.DisplayInfo();
        member1.DisplayInfo();

    }
}