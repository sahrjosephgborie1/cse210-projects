public class Person
{
    private string _title = "IT";
    private string _firstName = "Sahr";
    private string _lastName = "Gborie";

    // private
    private string GetFullName(){
        return _title + " " + _firstName + " " +  _lastName;
    }
    // getinformalsignature function Public
    public string GetInformalSignature()
    {
        return "Thanks, " + _firstName;
    }
    
    public string GetFormalSignature()
    {
        return "Sincerely " + GetFullName();
    }
    public string GetFirstName()
    {
        return _firstName;
    }
    public void SetFirstName(string firstName)
    {
        _firstName = firstName;
    }
    public Person()
    {
        _title = "";
        _firstName = "Anonnymous";
        _lastName = "Unknown";

    }
    public Person(string first, string last)
    {
        _title = "";
        _firstName = first;
        _lastName = last;
    }
    public Person(string title, string first, string last)
    {
        _title = title;
        _firstName = first;
        _lastName = last;
    }
}

