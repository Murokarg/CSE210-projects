


public class SimpleGoal : Goal
{
    // Additional attribute: is it completed?
    private bool _isComplete;

    // Constructor
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    // we overwrite RecordEvent: it only give poinst if it's not completed
    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            // Here we add points directly
            // Score is managed in GoalManager
            // It only checks that is completed
        }
    }

    // Overwrites IsComplete to reflect the real state
    public override bool IsComplete()
    {
        return _isComplete;
    }

    // It shows [X] if it's completed, [ ] if not
    public override string GetDetailsString()
    {
        string checkBox = _isComplete ? "[X]" : "[ ]";
        return $"{checkBox} {GetName()} ({GetPoints()} pts)";
    }

    // Format to save the file
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal,{GetName()},{GetDescription()},{GetPoints()},{_isComplete}";
    }
}