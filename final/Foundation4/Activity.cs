public class Activity
{
    protected DateTime _date;
    protected double _minutes;
    protected string _activityName;

    public Activity(DateTime date, string activityName, int minutes)
    {
        _date = date;
        _minutes = minutes;
        _activityName = activityName; 
    }

    public string GetSummary()
    {
        return $"{_date.ToShortDateString()} {_activityName} ({_minutes} min) - Distance {string.Format("{0:0.00}", GetDistance())} km, Speed {string.Format("{0:0.0}", GetSpeed())} kph, Pace: {string.Format("{0:0.0}", GetPace())} min per km";
    }

    public virtual double GetDistance()
    {
        return _minutes;
    }

    public virtual double GetPace()
    {
        return _minutes;
    }

    public virtual double GetSpeed()
    {
        return _minutes;
    }
}