public class Comment
{
    private string _commenter;
    private string _Texts;

    public void AddComment(string commenterName, string text)
    {
        _commenter = commenterName;
        _Texts = text;
    }
    // return the comments data (commenter and the commented text)
    public string GetCommenter()
    {
        return _commenter;
    }
    public string GetText()
    {
        return _Texts;
    }
}