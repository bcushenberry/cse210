public class ChecklistGoal : Goal
{
// --- Attributes ---
    private int _currentCount = 0;
    private int _targetCount;
    private int _bonus;

    public ChecklistGoal(string type, string name, string description, int points, int bonus, int targetCount, int currentCount = 0) : base(type, name, description, points)
    {
        _targetCount = targetCount;
        _bonus = bonus;
        _currentCount = currentCount;
    }

// --- Methods ---
    public override void Display()
    {
        // Three branches:
        // 1. Show completion of the goal (first time) 
        // 2. Show continued progress and subsequent completion(s) of the goal after the first completion
        // 3. Else show current progress toward the goal (before first completion)
        if (_currentCount == _targetCount)
        {
        Console.WriteLine($"[X] {_name} ({_description}) -- Current progress: {_currentCount}/{_targetCount}");
        }
        
        else if (_currentCount > _targetCount)
        {
        Console.WriteLine($"[X] {_name} ({_description}) -- Current progress: {_currentCount-_targetCount}/{_targetCount} (Times completed: {_currentCount/_targetCount})");
        }

        else
        {
        Console.WriteLine($"[ ] {_name} ({_description}) -- Current progress: {_currentCount}/{_targetCount}");
        }
    }

    public override int Record()
    {
        _currentCount++;

        if (_currentCount % _targetCount == 0)
        {
            return _points + _bonus;
        }

        else
        {
            return _points;
        }
    }

    public override string WriteToFile()
    {
        return $"{_type}\t{_name}\t{_description}\t{_points}\t{_bonus}\t{_targetCount}\t{_currentCount}";
    }

}