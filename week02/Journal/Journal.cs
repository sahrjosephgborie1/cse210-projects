public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void DisplayAll()
    {
        foreach (Entry enty in _entries)
        {
            // display methods
        Console.WriteLine($"Date: {enty._date}");
        Console.WriteLine($"Promt-Text: {enty._promtText}");
        Console.WriteLine($"EntryText: {enty._entryText}");
        }
    }

}