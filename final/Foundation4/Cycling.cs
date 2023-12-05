public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, string activityName, int minutes, double speed) : base(date, activityName, minutes)
    {
        _date = date;
        _minutes = minutes;
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _minutes / GetPace();
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }
}