public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();
    private Random _random = new Random();
 
    public ListingActivity() : base(
    "Listing Activity",
    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 
    50)
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }
    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(3);

        string prompt = GetRandomPrompt();

        Console.WriteLine("List as many responses you can to the following prompt");
        Console.WriteLine($" --- {prompt} ---");
        Console.Write("You may begin in: "); ShowCountDown(5);
        
        List<string> responses = GetListFromUser();
        _count = responses.Count;

        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine();

        DisplayEndingMessage();

    }
    public string GetRandomPrompt()
    {
        int randomNum = _random.Next(0, _prompts.Count);
        return $"{_prompts[randomNum]}";

    }
    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            
            Console.Write("> "); 
            string userResponse = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(userResponse))
            {
                items.Add(userResponse);
            }
        }

        return items;
    }
}