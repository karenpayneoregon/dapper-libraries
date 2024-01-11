namespace sqlserverApp.Models;

public class Test1
{
    public int Id { get; set; }
    public DateOnly? DateOnly { get; set; }
    public TimeOnly? TimeOnly { get; set; }
    public override string ToString() => $"{Id,-4}{DateOnly,-12:MM/dd/yyyy}{TimeOnly:hh:mm tt}";

}