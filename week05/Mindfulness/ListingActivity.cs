class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void Run()
    {
        StartActivity();
        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
        ShowCountdown(5);

        int count = 0;
        int elapsedTime = 0;
        while (elapsedTime < _duration)
        {
            Console.Write("Enter an item: ");
            Console.ReadLine();
            count++;
            elapsedTime += 3;
        }

        Console.WriteLine($"You listed {count} items!");
        EndActivity();
    }
}
