using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        StartActivity();
        int elapsedTime = 0;

        while (elapsedTime < _duration)
        {
            Console.Write("Breathe in..."); 
            ShowCountdown(4);
            Console.WriteLine(); 
            
            Console.Write("Now breathe out...");
            ShowCountdown(6);
            Console.WriteLine(); 

            elapsedTime += 10;
        }
        EndActivity();
    }
}
