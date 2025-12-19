namespace Flyweight.Factory;

public class BookFactory
{
    private readonly Dictionary<string, BookFlyweight> _books = new ();

    public BookFlyweight GetBook(string Title, string Author, string Publisher)
    {
        string  Key = $"{Title}_{Author}_{Publisher}";

        if (!_books.ContainsKey(Key))
        {
            _books[Key] = new BookFlyweight(Title, Author, Publisher);
        }

        return _books[Key];
    }
}