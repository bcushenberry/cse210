public class OutsideMtg : Event
{
    private string _forecast;

    public OutsideMtg(string title, string desc, string date, Address address, string forecast) : base (title, desc, date, address)
    {
        _forecast = forecast;
    }

    public override string GetShortDesc()
    {
        return $"Event Type: Outside Meeting\nTitle: {_title}\nDescription: {_description}\nDate/Time: {_date}";
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDesc()}\nForecast: {_forecast}";
    }
}