using Flyweight.Copy;
using Flyweight.Factory;

class Program
{
    static void Main()
    {
        var factory = new BookFactory();

        var book1 = factory.GetBook(
            "Clean Architecture",
            "Robert C. Martin",
            "Pearson");

        var book2 = factory.GetBook(
            "Clean Architecture",
            "Robert C. Martin",
            "Pearson");

        var copy1 = new BookCopy(1, book1);
        var copy2 = new BookCopy(2, book2);

        copy1.Display();
        copy2.Display();

        Console.WriteLine(
            $"Mesma instância? {ReferenceEquals(book1, book2)}");
    }
}