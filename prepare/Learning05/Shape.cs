public abstract class Shape
{
// --- Attributes ---
    private string _color;

// --- Constructor ---
    public Shape(string color)
    {
        _color = color;
    }

// --- Methods ---
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    // If the class wasn't abstract, we would make a virtual method like this: 
    // public virtual double GetArea()
    // {
    //     return 0;
    // }

    // But since it is abstract, we make an abstract method like this:
    public abstract double GetArea();

}