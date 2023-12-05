public class Swimming : Activity
{
    private double _numLaps;

    public Swimming(DateTime date, string activityName, int minutes, double numLaps) : base(date, activityName, minutes)
    {
        _date = date;
        _minutes = minutes;
        _numLaps = numLaps;
    }

    public override double GetDistance()
    {
        return _numLaps * 50 / 1000;
    }

    public override double GetPace()
    {
        return _minutes / GetDistance();
    }

    public override double GetSpeed()
    {
        return 60 / GetPace();
    }
}