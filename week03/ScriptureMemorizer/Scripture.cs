public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        // Spilt the incoming text string
        foreach (string wordtext in text.Split())
        {
            Word newword = new Word(wordtext);

            _words.Add(newword);
        }
    }
    // HideRandomWords(numberToHide : int) : void
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(_words.Count());
            _words[index].Hide();
        }
    }
    // GetDisplayText() : string
    public string GetDisplayText()
    {
        string text = _reference.GetDisplayText() + "  ";
        foreach (Word word in _words)
        {
            text += word.GetDisplayText()+" ";
            
        }

        return text.Trim();
    }
    // IsCompletelyHidden() : bool
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}