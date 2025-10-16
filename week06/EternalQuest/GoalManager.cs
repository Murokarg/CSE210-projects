using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    // Attributes
    private List<Goal> _goals;
    private int _score;

    // Constructor
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool running = true;
        while (running)
        {
            DisplayMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoalDetails(); break;
                case "3": RecordEvent(); break;
                case "4": DisplayPlayerInfo(); break;
                case "5":
                    Console.WriteLine("Enter the name of the file (eg. goals.txt):");
                    string saveFileName = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(saveFileName)) saveFileName = "goals.txt";
                    SaveGoals(saveFileName);
                    break;
                case "6":
                    Console.WriteLine("Enter the name of the file to load (eg. goals.txt): ");
                    string loadFileName = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(loadFileName)) loadFileName = "goals.txt";
                    LoadGoals(loadFileName);
                    break;
                case "7": running = false; Console.WriteLine("Good Bye!"); break;
                default: Console.WriteLine("Invalid option."); break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nTotal Score: {_score}");
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("\nYour Goals:");
        if (_goals.Count == 0)
        {
            Console.WriteLine("You don't have goals");
            return;
        }
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nWhat type of goal do you want to create?");
        Console.WriteLine("1. Simple goal");
        Console.WriteLine("2. Eternal goal");
        Console.WriteLine("3. Checklist Goal");

        string type = Console.ReadLine();
        Console.Write("What is the name of your goal?: ");
        string name = Console.ReadLine();
        Console.Write("What is the description of the goal?: ");
        string description = Console.ReadLine();
        Console.Write("How many points does it worth?: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("How many times do you need to do it to complete the goal?: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus points ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid type.");
                break;
        }
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("There are no goals");
            return;
        }

        ListGoalDetails();
        Console.Write("Choose the number of the goal: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index < 0 || index >= _goals.Count)
        {
            Console.WriteLine("Invalid Number.");
            return;
        }

        Goal goal = _goals[index];
        goal.RecordEvent();

        int earned = goal.GetPoints();

        if (goal is ChecklistGoal cg && cg.GetAmountCompleted() == cg.GetTarget())
        {
            earned += cg.GetBonus();
        }

        _score += earned;
        Console.WriteLine($"You earned {earned} points, Total: {_score}");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {   
            // First Line: total score
            writer.WriteLine(_score);
            // Then, a line per goal
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Saved.");
    }

    public void LoadGoals(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found");
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        // First line: score
        _score = int.Parse(lines[0]);
        // Cleans actual goals
        _goals.Clear();

        // process each goal (line 1 forward)
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(',');

            string type = parts[0];

            if (type == "SimpleGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool isComplete = bool.Parse(parts[4]);


                SimpleGoal goal = new SimpleGoal(name, description, points);
                if (isComplete)
                {
                    goal.RecordEvent(); 
                }
                _goals.Add(goal);
            }
            else if (type == "EternalGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                _goals.Add(new EternalGoal(name, description, points));
            }
            else if (type == "ChecklistGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                int bonus = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int amountCompleted = int.Parse(parts[6]);

                ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);

                for (int j = 0; j < amountCompleted; j++)
                {
                    goal.RecordEvent();
                }

                _goals.Add(goal);
            }
        }
    Console.WriteLine("Loaded Goals");
    }

    private void DisplayMenu()
    {
        Console.WriteLine("\n========== ETERNAL QUEST ==========");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Record Event");
        Console.WriteLine("4. Show Score");
        Console.WriteLine("5. Save Goals");
        Console.WriteLine("6. Load Goals");
        Console.WriteLine("7. Exit");
        Console.Write("Select an option: ");
    }

}