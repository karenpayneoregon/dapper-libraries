using sqlserverApp.Classes;

namespace sqlserverApp;

internal partial class Program
{
    static void Main(string[] args)
    {
        Operations operations = new();
        operations.GetAll().ForEach(Console.WriteLine);
        AnsiConsole.MarkupLine("[cyan]Press ENTER to exit[/]");
        Console.ReadLine();
    }
}