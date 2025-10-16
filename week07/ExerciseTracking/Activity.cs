public abstract class Activity
{
    // Attribute
    private string _date;
    private int _minutes;

    // Constructor
    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    // Abstract methods: each class must implement them
    public abstract double GetDistance(); // km
    public abstract double GetSpeed();    // km/h
    public abstract double GetPace();     // minutes/km

    // Concrete method, uses the abstracts to construct the resume
    public string GetSummary()
    {
        // Format: "03 Nov 2022 Running (30 min) - Distance 5.0 km, Speed 10.0 kph, Pace: 6.0 min per km"
        string activityName = this.GetType().Name; // This'll show "Running", "Cycling", etc.
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();

        return $"{_date} {activityName} ({_minutes} min) - Distance {distance:F1} km, Speed {speed:F1} kph, Pace: {pace:F1} min per km";
    }

    // Getters 
    public string GetDate()
    {
        return _date;
    }
    public int GetMinutes()
    {
        return _minutes;
    }
}