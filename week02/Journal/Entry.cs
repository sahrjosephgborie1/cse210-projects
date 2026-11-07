public class Entry
{
    public string _date;
    public string _promtText;
    public string _entryText;

    // Added category and moodRating
    public string _Category;
    public int _moodRating;

    // display function
    public void Display()
    {
        // display methods
        Console.WriteLine($"Date: {_date} - Promt: {_promtText}");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine($"Category: {_Category} | MoodRating: {_moodRating}");
        
    }
}