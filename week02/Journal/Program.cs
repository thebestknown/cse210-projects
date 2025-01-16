using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("Welcome to your Journal!");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Display entries by tag");
            Console.WriteLine("4. Save journal to a file");
            Console.WriteLine("5. Load journal from a file");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                // Create a new entry
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Your response: ");
                string response = Console.ReadLine();

                Console.WriteLine("Enter tags for this entry (comma-separated): ");
                string tagsInput = Console.ReadLine();
                List<string> tags = new List<string>(tagsInput.Split(','));

                Entry newEntry = new Entry(prompt, response, tags);
                theJournal.AddEntry(newEntry);
            }
            else if (choice == "2")
            {
                // Display all entries
                theJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                // Display entries by tag
                Console.Write("Enter the tag to filter by: ");
                string tag = Console.ReadLine();
                theJournal.DisplayEntriesByTag(tag);
            }
            else if (choice == "4")
            {
                // Save to a file
                Console.Write("Enter filename to save to: ");
                string fileName = Console.ReadLine();
                theJournal.SaveToFile(fileName);
            }
            else if (choice == "5")
            {
                // Load from a file
                Console.Write("Enter filename to load from: ");
                string fileName = Console.ReadLine();
                theJournal.LoadFromFile(fileName);
            }
            else if (choice == "6")
            {
                // Exit the program
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

            Console.WriteLine();
        }
    }
}
