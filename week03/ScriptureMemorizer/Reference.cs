public class Reference
{
    private string _book = "Proverbs";
    private int _chapter;
    private int _verse;
    private int _endVerse;

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