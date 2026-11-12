public class Word
{
    private string _text;
    private bool _isHidden;


    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    // Hide() : void
    public void Hide()
    {
        _isHidden = true;
    }

    // Show() : void
    public void Show()
    {
        _isHidden = false;
    }
    // IsHidden() : bool
    public bool IsHidden()
    {
        return _isHidden;
    }
    // GetDisplayText() : string
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('-', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}