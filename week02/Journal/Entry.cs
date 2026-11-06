public class Entry
{
    public string _date;
    public string _promtText;
    public string _entryText;

    // display function
    public void Display()
    {
        // display methods
        Console.WriteLine($"Promt: {_promtText}");
        Console.WriteLine($"EntryText: {_entryText}");
        Console.WriteLine($"Date: {_date}");
    }
}