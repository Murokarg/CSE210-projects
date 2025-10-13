using System;


public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity()
    {
        _name = "Default Activity";
        _description = "This is a default mindfulness activity";
        _duration = 0;
    }

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    // Getters
    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    // Setters
    public void SetName(string name)
    {
        _name = name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public void SetDuration(int duration)
    {
        if (duration > 0)
            _duration = duration;
        else
            Console.WriteLine("Duration must be positive.");
    }

    // Shows initial message
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"--- {GetName()} ---");
        Console.WriteLine(GetDescription());
        Console.WriteLine();
    }

    // Show final message

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done! You have completed the activity.");
        Console.WriteLine($"Activity: {GetName()}");
        Console.WriteLine($"Duration: {GetDuration} seconds");
    }

    // Shows spinner during n amount of seconds 
    public void ShowSpinner(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int spinIndex = 0;
        char[] spinner = { '|', '/', '-', '\\' };

        while (DateTime.Now < endTime)
        {
            Console.Write($"\r{spinner[spinIndex]}");
            spinIndex = (spinIndex + 1) % spinner.Length;
            Thread.Sleep(150);
        }
        Console.WriteLine();
    }

    // Shows the countdown
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"\r{i}...");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    // Generic Run() method (It can be overridden, but here it's defined as a base version)
    public virtual void Run()
    {
        DisplayStartingMessage();

        // Asks for duration
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        string input = Console.ReadLine();
        int duration;

        while (!int.TryParse(input, out duration) || duration <= 0)
        {
            Console.Write("Please enter a valid positive number of seconds: ");
            input = Console.ReadLine();

        }
        SetDuration(duration);

        // Prep
        Console.WriteLine("\nGet Ready...");
        ShowSpinner(3); // Three seconds to prepare

        // Each class would perform their logic
        PerformActivity();

        // Final Message
        DisplayEndingMessage();
        ShowSpinner(3); // Three seconds to finish up
    }

    // Method that is going to be overridden by the sub-classes
    protected virtual void PerformActivity()
    {
        Console.WriteLine("Performin generic activity... (This should be overridden by subclasses)");
    }
}
    
    

