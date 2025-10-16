using System;


class Program
{
    static void Main(string[] args)
    {
        // Create a list type for Activity(base class)
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("05 Oct 2025", 30, 4.8));
        activities.Add(new Cycling("06 Oct 2025", 45, 20.0));
        activities.Add(new Swimming("07 Oct 2025", 30, 40));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}