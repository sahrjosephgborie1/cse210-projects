public class Job
{
    // Variables
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear;
    public int _endYear;

    public void DisplayJobDetails()
    {
        // A method that displays job details
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}