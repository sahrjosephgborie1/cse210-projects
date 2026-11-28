public class BreathingActivity : Activity   
{
    public BreathingActivity() : base(
    "Breathing Activity",
    "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 
    50)
    {
       
    }
    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(3);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            // breathe in
            Console.Write("breathe in...");
            ShowCountDown(5);
            Console.Write("Now breathe out...");
            ShowCountDown(5);
            Console.WriteLine();
        }


        DisplayEndingMessage(); 
    }
}