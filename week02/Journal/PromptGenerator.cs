using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What made you smile today?",
        "What was the most interesting thing you learned today?",
        "Who did you interact with today and why was it meaningful?",
        "What are you grateful for today?",
        "What could you have done differently today?"
    };

    // To get a random prompt
    public string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }
}
