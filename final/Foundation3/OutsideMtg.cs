public class OutsideMtg : Event
{
    private string _forecast;

    public OutsideMtg(string title, string desc, string date, Address address, string forecast) : base (title, desc, date, address)
    {
        _forecast = forecast;
    }

    public override string GetShortDesc()
    {
        return $"Title: {_title}\nEvent Type: Outside Meeting\nDescription: {_description}\nDate/Time: {_date}";
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDesc()}\n\nForecast: {_forecast}";
    }
}