using TaskManager.Models;

class Program
{
    static void Main()
    {
        var buyMilk = new TaskItem("Comprar leite");
        var buyBread = new TaskItem("Comprar pão");
        var cleanHouse = new TaskItem("Limpar a casa");

        var shopping = new TaskGroup("Compras");
        shopping.Add(buyMilk);
        shopping.Add(buyBread);

        var today = new TaskGroup("Tarefas do dia");
        today.Add(shopping);
        today.Add(cleanHouse);

        var cleanKitchen = new TaskItem("Limpar cozinha");
        var cleanLivingRoom = new TaskItem("Limpar sala");
        var cleaningGroup = new TaskGroup("Limpeza Detalhada");
        cleaningGroup.Add(cleanKitchen);
        cleaningGroup.Add(cleanLivingRoom);

        today.Remove(cleanHouse); 
        today.Add(cleaningGroup);

        Console.WriteLine("== Estado inicial ==");
        today.Print();
        Console.WriteLine();

        buyMilk.MarkComplete();
        cleanKitchen.MarkComplete();

        Console.WriteLine("== Depois de completar Comprar leite e Limpar cozinha ==");
        today.Print();
        Console.WriteLine();

        shopping.MarkComplete();

        Console.WriteLine("== Depois de marcar Compras como completo ==");
        today.Print();
        Console.WriteLine();

        Console.WriteLine($"Progresso geral (em %): {today.GetProgress() * 100:N1}%");
    }
}
