using System;
using System.Collections.Generic;
public class ListingActivity : Activity
{
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by listing as many as you can in a given time.")
    {
        // Name and description are defined in the base class
    }

    private static List<string> _prompts = new List<string>
    {
        "Who are peple that you appreciate?",
        "What are personal strengths of your?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of you personal heroes?"
    };

    // It gets a random prompt from the list
    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        return _prompts[index];
    }

    protected override void PerformActivity()
    {
        // Step one: show a random prompt
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.WriteLine();

        // Step two: Give the time to think about the prompt
        Console.WriteLine("Take a moment to think about the answer...");
        ShowCountDown(5); // three seconds to prepare

        int totalSeconds = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(totalSeconds);
        List<string> items = new List<string>();

        Console.WriteLine($"\nYou have {totalSeconds} seconds. Start listing now!");
        Console.WriteLine("(Press Enter after each item)\n");

        // While there is still time, user enters the prompts
        while (DateTime.Now < endTime)
        {
            // Waits for the next item
            Console.Write("Next item: ");
            string input = Console.ReadLine();

            // If time runs out, the program exits the activity
            if (DateTime.Now >= endTime)
            {
                Console.WriteLine("\nTime's up!");
                break;
            }

            // Saves items if it's not empty
            if (!string.IsNullOrWhiteSpace(input))
            {
                items.Add(input);
                Console.WriteLine($"✓ Added! Total: {items.Count}");
            }
        }

        // Shows the result
        Console.WriteLine($"\nYou listed {items.Count} item(s):");
        foreach (string item in items)
        {
            Console.WriteLine($"- {item}");
        }

    }
}