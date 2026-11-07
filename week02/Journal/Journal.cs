public class Journal
    
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        
    }

    public void DisplayAll()
    {
        foreach (Entry enty in _entries)
        {
            // display methods
            Console.WriteLine($"Date: {enty._date} - Promt: {enty._promtText},");
            Console.WriteLine($"{enty._entryText}");
            Console.WriteLine();
        }
    }

    // a function to save to a file
    public static void Savetofile (List<Entry> journals)
    {
        Console.WriteLine("What is the filename (E.g. filename.txt or journal.csv)");
        string nameofFile = Console.ReadLine();
        string filename = nameofFile;

        Console.WriteLine("Saving the file...");

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry enty in journals)
            {
                outputFile.WriteLine($"Promt-Text: {enty._promtText}~~EntryText: {enty._entryText}~~Date: {enty._date}");
            }
        }
        Console.WriteLine("File Sucessfully Saved.");
    }

    // Load from file function
    public static List<Entry> LoadFromFile()
    {
        List<Entry> listLoaded = new List<Entry>();
        Console.WriteLine("What is the filename (E.g. filename.txt or journal.csv)");
        string nameofFile = Console.ReadLine();
        string filename = nameofFile;

        if (!File.Exists(filename))
        {
            Console.WriteLine("No file saved with that. try again");
            return new List<Entry>();
        }
        else
        {
            Console.WriteLine("Reading the file...");

            // reading all the line in filename
            Journal theJournal = new Journal();

            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                // spilt line into part (prompttext~~entrytext)
                string[] parts = line.Split("~~");

                // parts[0] - prompttext
                // part[1] - entrytext
                // part[2] - date

                Entry newEntry = new Entry();
                newEntry._promtText = parts[0];
                newEntry._entryText = parts[1];
                newEntry._date = parts[2];

                // add newentry to listloaded and the journal
                listLoaded.Add(newEntry);
            }
            Console.WriteLine("Finished Reading.");
            return listLoaded;
        }
        
    }
}