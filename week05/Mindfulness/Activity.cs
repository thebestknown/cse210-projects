using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    private static Dictionary<string, int> _activityLog = new Dictionary<string, int>();
    private static string _logFilePath = "activity_log.txt"; // File to store activity counts

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        LoadActivityLog();
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like for your session? ");

        while (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive number.");
            Console.Write("\nHow long, in seconds, would you like for your session? ");
        }

        Console.WriteLine("\nGet ready...");
        ShowSpinner(3);
    }

    public void EndActivity()
    {
        Console.WriteLine("\nWell done!!");
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}.");
        ShowSpinner(3);
        LogActivity();
    }

    private void LogActivity()
    {
        if (_activityLog.ContainsKey(_name))
        {
            _activityLog[_name]++;
        }
        else
        {
            _activityLog[_name] = 1;
        }

        SaveActivityLog();
    }

    private void LoadActivityLog()
    {
        if (File.Exists(_logFilePath))
        {
            foreach (string line in File.ReadAllLines(_logFilePath))
            {
                var parts = line.Split(':');
                if (parts.Length == 2 && int.TryParse(parts[1], out int count))
                {
                    _activityLog[parts[0]] = count;
                }
            }
        }
    }

    private void SaveActivityLog()
    {
        using (StreamWriter writer = new StreamWriter(_logFilePath))
        {
            foreach (var entry in _activityLog)
            {
                writer.WriteLine($"{entry.Key}:{entry.Value}");
            }
        }
    }

    public static void DisplayActivityLog()
    {
        Console.WriteLine("\nActivity Log:");
        if (_activityLog.Count == 0)
        {
            Console.WriteLine("No activities logged yet.");
        }
        else
        {
            foreach (var entry in _activityLog)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value} times");
            }
        }
    }

    protected void ShowSpinner(int seconds)
    {
        List<char> spinnerChars = new List<char> { '|', '/', '-', '\\' };
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write($"\r{spinnerChars[i % spinnerChars.Count]} ");
            Thread.Sleep(250);
        }
        Console.Write("\r ");
        Console.WriteLine();
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($" {i} "); 
            Thread.Sleep(1000);
            Console.Write("\b\b\b"); 
        }
        Console.Write(" ");
    }

    protected int GetDuration()
    {
        return _duration;
    }
}
