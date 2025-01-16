using System;
using System.Collections.Generic;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public List<string> _tags; // New attribute for tags

    // Initialize a new entry
    public Entry(string promptText, string entryText, List<string> tags)
    {
        _date = DateTime.Now.ToString("yyyy-MM-dd");
        _promptText = promptText;
        _entryText = entryText;
        _tags = tags;
    }

    // Display the entry
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine($"Tags: {string.Join(", ", _tags)}"); // Display tags
    }
}
