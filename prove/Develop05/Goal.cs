using System;

public class Goal
{
// --- Attributes ---
    protected int _points;
    protected string _type;
    protected string _name;
    protected string _description;

// --- Constructor ---
    public Goal(string type, string name, string description, int points)
    {
        _type = type;
        _name = name;
        _description = description;
        _points = points;
    }

// --- Methods ---
    public virtual void Display()
    {

    }

    public virtual int Record()
    {
        return _points;
    }

    public virtual string WriteToFile()
    {
        return $"{_type}\t{_name}\t{_description}\t{_points}";
    }

// --- Getters ---
    // Exclusively used to list the goals when a user chooses "Record"
    public string GetName()
    {
        return _name;
    }
}