using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace sqlserverApp;
internal partial class Program
{
    [ModuleInitializer]
    public static void Init()
    {
        AnsiConsole.MarkupLine("[cyan]Results[/]");
        Console.Title = "DateOnly and TimeOnly handler test";
        WindowUtility.SetConsoleWindowPosition(WindowUtility.AnchorWindow.Center);
    }
}
