public class Video
{
    private string _title;
    private string _author;
    private int _length;
    
    private List<Comment> _comments = new List<Comment>();

    public void AddVideo(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        // _comments = comments;
    }
    public string GetTitle()
    {
        return _title;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public int GetLength()
    {
        return _length;
    }
    

    public void AddComment(Comment c)
    {
        _comments.Add(c);
    }
    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }
}