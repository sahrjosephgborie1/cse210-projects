public class Reference
{
    private string _book = "Proverbs";
    private int _chapter = 3;
    private int _verse = 5;
    private int _endVerse = 6;

    // Reference
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    // GetDisplayText() : string
    public string GetDisplayText()
    {
        string book = _book;
        int chapter = _chapter;
        int verse = _verse;
        int endVerse = _endVerse;
        return book +" "+ chapter +":" + verse+"-"+endVerse;
    }
    // Possible getters and setters
}