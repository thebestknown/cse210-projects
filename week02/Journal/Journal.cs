using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    // Add a new entry to the journal
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Display all entries
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
            return;
        }

        foreach (var entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    // Save the journal to a file
    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
        Console.WriteLine($"Journal successfully saved to {file}");
    }

    // Load the journal from a file
    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            _entries.Clear();
            foreach (var line in File.ReadAllLines(file))
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3) // Ensure the line has the expected format
                {
                    _entries.Add(new Entry(parts[1], parts[2]) { _date = parts[0] });
                }
            }
            Console.WriteLine($"Journal successfully loaded from {file}");
        }
        else
        {
            Console.WriteLine($"Error: File '{file}' not found. Please check the file name and try again.");
        }
    }
}
