

public class Running : Activity
{
    private double _distance;

    public Running(string date, int minutes, double distance)
        : base(date, minutes) // calls the constructor in Activity
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        
        return (_distance / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        
        return GetMinutes() / _distance;
    }
}