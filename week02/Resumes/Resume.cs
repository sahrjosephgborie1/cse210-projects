public class Resume
{
    // member variables
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    // method to display
    public void DisplayResume()
    {   
        // display name
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }

    }
}