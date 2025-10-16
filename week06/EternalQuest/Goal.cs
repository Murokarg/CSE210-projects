



public class Goal
{

    private string _shortName;
    private string _description;
    private int _points;

    // Constructor: it is called when user creates a new goal
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // Method to register an event(it'll be overwritten by the child classes)
    public virtual void RecordEvent()
    {
    }

    // Checks if the goal is completed (it'll be overwritten)
    public virtual bool IsComplete()
    {
        // By default, it's assumed is not completed
        // Child classes will decide it's own logic
        return false;
    }

    // It returns a string with the details to show in the list
    public virtual string GetDetailsString()
    {
        // Replaced by each type of goal
        return $"[ ] {_shortName} ({_points} pts)";
    }

    // Returns a string to be saved in a file
    public virtual string GetStringRepresentation()
    {
        // This too will be overwritten
        return "";
    }

    // Getters
    public string GetName()
    {
        return _shortName;
    }

    public int GetPoints()
    {
        return _points;
    }

    public string GetDescription()
    {
        return _description;
    }
}