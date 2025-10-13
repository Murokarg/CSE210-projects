using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    // Constructor
    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. It will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        // Name and description are defined in the base class
    }

    private static List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was completed?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    

    // Method to pick a random element
    private string GetRandomItem(List<string> items)
    {
        Random random = new Random();
        int index = random.Next(0, items.Count);
        return items[index];
    }

    // Overwrite the activity - main logic

    protected override void PerformActivity()
    {
        // First step: Show a random prompt
        string prompt = GetRandomItem(_prompts);
        Console.WriteLine(prompt);
        Console.WriteLine();

        // Second step: Initial pause for the user to think about an experience
        Console.WriteLine("Take a moment to think about this experience...");
        ShowSpinner(5); // 3 seconds of spinner

        // Third step: Show questions until timer runs out
        int totalSeconds = GetDuration();
        int timeElapsed = 0;
        int questionPauseSeconds = 5; // How much time to show on each question

        Console.WriteLine();

        while (timeElapsed < totalSeconds)
        {
            // Program chooses a random question
            string question = GetRandomItem(_questions);
            Console.WriteLine(question);

            // It then calculates how much time we can really use
            int remainingTime = totalSeconds - timeElapsed;
            int actualPause = Math.Min(questionPauseSeconds, remainingTime);

            // Shows a spinner during the pause
            ShowSpinner(actualPause);

            // Updates elapsed time
            timeElapsed += actualPause;

            Console.WriteLine();
        }

    }
    
}