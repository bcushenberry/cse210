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

// Example of DateTime in constructor:
// Animal pet = new Animal("a12344", new DateTime(2013, 1, 23), "Fluffy");
// var date1 = new DateTime(2008, 3, 1, 7, 0, 0);
// Console.WriteLine(date1.ToString());
// For en-US culture, displays 3/1/2008 7:00:00 AM

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