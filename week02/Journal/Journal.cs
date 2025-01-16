using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

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

    public void DisplayEntriesByTag(string tag)
    {
        var filteredEntries = _entries.Where(e => e._tags.Contains(tag)).ToList();

        if (filteredEntries.Count == 0)
        {
            Console.WriteLine($"No entries found with the tag: {tag}");
            return;
        }

        Console.WriteLine($"Entries with tag: {tag}");
        foreach (var entry in filteredEntries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }
        public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            _entries.Clear();
            foreach (var line in File.ReadAllLines(file))
            {
                string[] parts = line.Split('|');
                if (parts.Length == 4) // Ensure the line has the expected format
                {
                    List<string> tags = new List<string>(parts[3].Split(',')); // Convert tags back to a list
                    _entries.Add(new Entry(parts[1], parts[2], tags) { _date = parts[0] });
                }
            }
            Console.WriteLine($"Journal successfully loaded from {file}");
        }
        else
        {
            Console.WriteLine($"Error: File '{file}' not found. Please check the file name and try again.");
        }
    }    
    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (var entry in _entries)
            {
                string tags = string.Join(",", entry._tags); // Convert tags to a single string
                writer.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}|{tags}");
            }
        }
        Console.WriteLine($"Journal successfully saved to {file}");
    }
}
