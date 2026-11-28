public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    private List<string> _unusedQuestions = new List<string>();

    public ReflectingActivity() : base(
    "Reflecting Activity",
    "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
    50)
    {
        // prompts
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        // questions
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }
    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(3);

        Console.WriteLine("Consider the following prompt");
        DisplayPrompt();

        Console.WriteLine("When you have something in mind, press enter to continue.");

        Console.ReadLine();
         
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: "); 
        ShowCountDown(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        Console.Clear();

        while (DateTime.Now < endTime)
        {
            DisplayQuestions();
            ShowSpinner(15);
        }
        
        DisplayEndingMessage();
       
    }
    
    public string GetRandomPrompt()
    {   
        Random random = new Random();
        int randomNum = random.Next(0, _prompts.Count);
        return _prompts[randomNum]; 
    }
    public string GetRandomQuestion()
    {   
        
        Random random = new Random();

        if (_unusedQuestions.Count == 0)
        {
            _unusedQuestions.AddRange(_questions);
            
        }
        int randomNum = random.Next(0, _unusedQuestions.Count);
        string question = _unusedQuestions[randomNum];
        _unusedQuestions.RemoveAt(randomNum);
        
        return question;
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
    }
    public void DisplayQuestions()
    {
        Console.Write($"> {GetRandomQuestion()} ");
    }

    
}