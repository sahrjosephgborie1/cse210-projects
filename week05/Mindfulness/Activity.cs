public class Activity
{
    private string _name = "Reflecting";
    private string _description = "This activity will help you reflect on times ...";
    private int _duration = 50;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public int SetDuration(int duration)
    {
        _duration = duration;
        return _duration;
    }
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        int sessionTime = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        Console.Clear();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!!");
        Console.WriteLine("");
        // spiner   
        ShowSpinner(3);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
        // spin again for seconds
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        // for (int i = 5; i > 0; i--)
        // {
        //   Console.Write(i);
        //   Thread.Sleep(1000);
        //   Console.Write("\b \b");
        // } 
        
        // for (int i = 5; i > 0; i--)
        // {
        //   Console.Write(".");
        //   Thread.Sleep(1000);
        //   // Console.Write("\b \b");
        // } 

        // |/-\|/-\|
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        // foreach (string s in aminationstrings)
        // {
        //   Console.Write(s);
        //   Thread.Sleep(1000);
        //   Console.Write("\b \b");
        // } 

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {

            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int second)
    {
        for (int i = second; i > 0; i--)
        {
            string text = i.ToString();
            int length = text.Length;

            Console.Write(text);
            Thread.Sleep(1000);

            string backspacess = new string('\b', length);
            string spaces = new string('', length);
            Console.Write($"{backspacess}{backspacess}");
          
        } 

        Console.WriteLine();
    }
}