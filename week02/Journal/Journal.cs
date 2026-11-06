public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void DisplayAll()
    {
        foreach (Entry enty in _entries)
        {
            // display methods
            Console.WriteLine($"Promt-Text: {enty._promtText}, EntryText: {enty._entryText}, Date: {enty._date}");
        }
    }

}