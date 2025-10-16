

public class EternalGoal : Goal
{
    // Constructor
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
        // It doesn't need additional attributes .
        // It is never completed, there is no state to save!
    }

    // Overwrites RecordEvent
    // (It's declared so GoalManager knows it's valid)
    public override void RecordEvent()
    {
        // We don't chance any state
        // Final score will be managed by GoalManager when it calls GetPoints().
    }

    // It always returns false
    public override bool IsComplete()
    {
        return false;
    }

    // Always shows [ ] it never ends
    public override string GetDetailsString()
    {
        return $"[ ] {GetName()} ({GetPoints()} pts)";
    }

    // Format to save the file
    public override string GetStringRepresentation()
    {
        return $"EternalGoal,{GetName()},{GetDescription()},{GetPoints()}";
    }
}