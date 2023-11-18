public class SimpleGoal : Goal
{
// --- Attributes ---
    private bool _isCompleted;

    public SimpleGoal(string type, string name, string description, int points, bool isCompleted = false) : base(type, name, description, points)
    {
        _isCompleted = isCompleted;
    }

// --- Methods ---
    public override void Display()
    {
        if (_isCompleted)
        {
        Console.WriteLine($"[X] {_name} ({_description})");
        }
        
        else
        {
        Console.WriteLine($"[ ] {_name} ({_description})");
        }
    }

    public override int Record()
    {
        _isCompleted = true;
        return _points;
    }

    public override string WriteToFile()
    {
        return $"{_type}\t{_name}\t{_description}\t{_points}\t{_isCompleted}";
    }
}