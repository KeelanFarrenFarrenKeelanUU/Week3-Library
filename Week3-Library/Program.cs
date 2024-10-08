class Book
{
    string Title;
    string Author;
    string ISBN;

    void DisplayInfo()
    {
        // Output the book information to the console
        Console.WriteLine("Book Information");
        Console.WriteLine("--------------------");
        Console.WriteLine($"Book title: {Title}");
        Console.WriteLine($"Book author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");
        Console.WriteLine("--------------------");
    }


    static void Main(string[] args)
    {
        // Create a new instance of the book class
        Book book = new Book();
        book.Title = "C# for Beginners";
        book.Author = "Bill Gates";
        book.ISBN = "123456";

        Book book2 = new Book();
        book2.Title = "C# Methods and Classes";
        book2.Author = "Microsoft";
        book2.ISBN = "123457";

        // Output book information to the console
        book.DisplayInfo();
        book2.DisplayInfo();

    }
}