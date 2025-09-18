using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public PromptGenerator()
    {
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("How did I help someone today?");
        _prompts.Add("What was the most challenging part of my day?");
        _prompts.Add("What is one thing I could have done to make today better?");
        _prompts.Add("If I had one thing I could do over today, what could it be?");
        _prompts.Add("What am I grateful for today?");
        _prompts.Add("What did I learn today?");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}