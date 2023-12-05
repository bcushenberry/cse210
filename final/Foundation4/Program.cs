using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        activities.AddRange(new List<Activity>
        {
            new Running(new DateTime(2023, 12, 09), "Running", 50, 7.5),
            new Cycling(new DateTime(2023, 12, 10), "Cycling", 30, 20),
            new Swimming(new DateTime(2023, 12, 11), "Swimming", 45, 45)
        });

        Console.WriteLine();
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}