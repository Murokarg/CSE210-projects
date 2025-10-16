public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {   // Convert laps to km: (laps * 50 meters) / 1000
        return (_laps * 50) / 1000.0;
    }

    public override double GetSpeed()
    {
        double distance = GetDistance();
        return (distance / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        return GetMinutes() / distance;
    }

}