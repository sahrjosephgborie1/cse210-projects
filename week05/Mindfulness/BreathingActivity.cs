public class BreathingActivity : Activity   
{
    public BreathingActivity(int duration) : base(
    "Breathing Activity",
    "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", duration)
    {
    }
    public void Run()
    {
        ShowSpinner(3);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now >= endTime) break;
        {
            // breathe in
            Console.WriteLine("breathe in");
            ShowCountDown(5);
            Console.WriteLine("Now breathe out...");
            ShowCountDown(5);
        }


        DisplayEndingMessage(); 
    }
}