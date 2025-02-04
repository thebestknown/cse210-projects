class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", 
        "This activity will help you relax by walking you through breathing in and out slowly.")
    {
    }

    public void Run()
    {
        StartActivity();
        int elapsedTime = 0;
        while (elapsedTime < _duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(3);
            Console.WriteLine("Breathe out...");
            ShowCountdown(3);
            elapsedTime += 6;
        }
        EndActivity();
    }
}
