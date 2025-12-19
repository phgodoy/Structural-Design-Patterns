namespace Flyweight.Copy;
public class BookCopy
{
    public int ShelfNumber { get; }
    public BookFlyweight Book { get; }

    public BookCopy(int shelfNumber, BookFlyweight book)
    {
        ShelfNumber = shelfNumber;
        Book = book;
    }

    public void Display()
    {
        Book.Display();
        Console.WriteLine($"Prateleira: {ShelfNumber}");
    }
}
