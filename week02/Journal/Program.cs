using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal(); // Create a Journal instance
        PromptGenerator promptGenerator = new PromptGenerator(); // Create a PromptGenerator instance

        bool running = true;
        while (running)
        {
            Console.WriteLine("\n=== JOURNAL MENU ===");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry(journal, promptGenerator);
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    SaveToFile(journal);
                    break;
                case "4":
                    LoadFile(journal);
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

        }

    }

    static void WriteNewEntry(Journal journal, PromptGenerator promptGenerator)
    {
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");

        Console.Write("Enter your response: ");
        string response = Console.ReadLine();

        string date = DateTime.Now.ToString("yyyy-MM-dd");

        Entry newEntry = new Entry(date, prompt, response);
        journal.AddEntry(newEntry);
    }

    static void SaveToFile(Journal journal)
    {
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();

        journal.SaveToFile(filename);
    }

    static void LoadFile(Journal journal)
    {
        Console.Write("Enter name of the file to load: ");
        string filename = Console.ReadLine();

        journal.LoadFromFile(filename);
    }
}