using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a scripture reference and text for Helaman 5:12
        Reference reference = new Reference("Helaman", 5, 12);
        Scripture scripture = new Scripture(reference, 
            "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation.");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText()); 
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break; 

            scripture.HideRandomWords(3); 

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine("All words are hidden!");
                Console.WriteLine(scripture.GetDisplayText());
                break;
            }
        }
    }
}
