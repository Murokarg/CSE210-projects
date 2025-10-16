

public class ChecklistGoal : Goal
{
    // Additional attributes
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    // Constructor
    public ChecklistGoal(string name, string description, int points, int target, int bonus) 
        : base(name, description, points)
    {
        _amountCompleted = 0;   // Starts at 0
        _target = target;       // How many times it must be done to be completed
        _bonus = bonus;         // Extra points when is completed all the times
    }

    // Register an event: it adds to the counter and checks completed if it's applicable
    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            // Note: we don't add the points here
            // GoalManager will decide how many point to give (normal + the bonus if it's the last time)
        }
    }

    // It's completed if it finishes the objective number of times
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    // It shows the progress 
    public override string GetDetailsString()
    {
        string checkBox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkBox} {GetName()} ({GetPoints()} pts each, bonus {_bonus}) — Completed {_amountCompleted}/{_target}";
    }

    // Format to save the file
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal,{GetName()},{GetDescription()},{GetPoints()},{_bonus},{_target},{_amountCompleted}";
    }

    // Getters
    public int GetBonus()
    {
        return _bonus;
    }

    public int GetTarget()
    {
        return _target;
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
}