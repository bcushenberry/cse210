public class EternalGoal : Goal
{
// --- Attributes ---
    private int _timesCompleted = 0;

    public EternalGoal(string type, string name, string description, int points, int timesCompleted = 0) : base(type, name, description, points)
    {
        _timesCompleted = timesCompleted;
    }

// --- Methods ---
    public override void Display()
    {
        Console.WriteLine($"[ ] {_name} ({_description}) -- Times completed: {_timesCompleted}");        
    }

    public override int Record()
    {
        _timesCompleted++;
        return _points;
    }

    public override string WriteToFile()
    {
        return $"{_type}\t{_name}\t{_description}\t{_points}\t{_timesCompleted}";
    }    
}