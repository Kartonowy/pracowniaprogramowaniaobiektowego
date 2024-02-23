namespace jan29;
class Book : IComparable<Book> {
    string title;
    public string Author;
    public int Published;
    public double Price;

    public Book(string _title, string _author, int _published, double _price) {
        title = _title;
        Author = _author;
        Published = _published;
        Price = _price;
    }

    public override string ToString() {
       return $"{title}, {Author}, {Published}, {Price} zł";
    }

    public int CompareTo(Book other) {
        if (other == null) return 1;
        return Price.CompareTo(other.Price);
    }
}
class Program
{
   static void Main(string[] args)
    {
        List<Book> books = new List<Book>();

        books.Add(new Book("Hobbit", "J. R. R. Tolkien", 1937, 45.99));
        books.Add(new Book("Invisible Life of Addie LaRue", "V. E. Schwab", 2019, 32.79));
        books.Add(new Book("Poppy war. Trilogy.", "R. F. Kuang", 2018, 56.99));
        books.Add(new Book("Mistborn", "Brandon Sanderson", 2014, 45.99));
        Console.WriteLine("Lista książek: ");

        foreach (Book book in books) {
            Console.WriteLine(book);
        }

        books.Sort();
        Console.WriteLine("\nPosortowane książki według ceny");

        foreach (Book book in books) {
            Console.WriteLine(book);
        }

        var sortedBy  = books.OrderBy(e => e.Published);

        Console.WriteLine("\nPosortowanie książi według publikacji");

        foreach (Book book in sortedBy) {
            Console.WriteLine(book);
        }

        var sortedByAuth  = books.OrderByDescending(e => e.Author);

        Console.WriteLine("\nPosortowanie książi według publikacji");

        foreach (Book book in sortedByAuth) {
            Console.WriteLine(book);
        }

        var sortedd = books.OrderByDescending(book => book.Price).ThenBy(book => book.Published);
    }
}
