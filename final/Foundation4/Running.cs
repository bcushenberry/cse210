public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, string activityName, int minutes, double distance) : base(date, activityName, minutes)
    {
        _date = date;
        _minutes = minutes;
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetPace()
    {
        return _minutes / _distance;
    }

    public override double GetSpeed()
    {
        return _distance / _minutes * 60;
    }
}