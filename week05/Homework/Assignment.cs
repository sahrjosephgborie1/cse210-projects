public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // getters
    public string GetStudentName()
    {
        return _studentName;
    }
    public string Gettopic()
    {
        return _topic;
    }

    // // Setters
    // public void SetStudentName(string studentName)
    // {
    //     _studentName = studentName;
    // }
    
    // public void SetTopic(string topic)
    // {
    //     _topic = topic;
    // }

    // GetSummary()
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}