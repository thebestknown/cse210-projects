using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // List of scriptures from the Book of Mormon
        var scriptures = new List<(Reference, string)>
        {
            (new Reference("2 Nephi", 2, 25), "Adam fell that men might be; and men are, that they might have joy."),
            (new Reference("Mosiah", 2, 17), "When ye are in the service of your fellow beings ye are only in the service of your God."),
            (new Reference("Ether", 12, 27), "If men come unto me I will show unto them their weakness."),
            (new Reference("Moroni", 10, 4), "And when ye shall receive these things, I would exhort you that ye would ask God."),
            (new Reference("Helaman", 5, 12), "And now, my sons, remember, remember that it is upon the rock of our Redeemer.")
        };

        // Select a random scripture
        Random random = new Random();
        var randomScripture = scriptures[random.Next(scriptures.Count)];
        Reference reference = randomScripture.Item1;
        string text = randomScripture.Item2;

        Scripture scripture = new Scripture(reference, text);

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
