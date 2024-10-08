class Book
{
    // Properties
    string Title;
    string Author;
    string ISBN;
    int Pages;

    // Constructor for book object
    public Book(string bookTitle, string bookAuthor, string bookISBN, int noOfPages)
    {
        Title = bookTitle;
        Author = bookAuthor;
        ISBN = bookISBN;
        Pages = noOfPages;
    }

    void DisplayInfo()
    {
        // Output the book information to the console
        Console.WriteLine("Book Information");
        Console.WriteLine("--------------------");
        Console.WriteLine($"Book title: {Title}");
        Console.WriteLine($"Book author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");
        Console.WriteLine($"Number of pages: {Pages}");
        Console.WriteLine("");
    }


    static void Main(string[] args)
    {
        // Create a new instance of the book class
        Book book = new Book("C# for Beginners", "Bill Gates", "123456", 200);

        Book book2 = new Book("C# Methods and Classes", "Microsoft", "123457", 300);

        // Output book information to the console
        book.DisplayInfo();
        book2.DisplayInfo();

    }
}