namespace Flyweight;

public class BookFlyweight
{
    public string Title { get; }
    public string Author { get; }
    public string Publisher { get; }
    
    public BookFlyweight(string title, string author, string publisher)
    {
        Title = title;
        Author = author;    
        Publisher = publisher;
    }

    public void Display()
    {
        Console.WriteLine($"{Title} - {Author} ({Publisher})");
    }
}