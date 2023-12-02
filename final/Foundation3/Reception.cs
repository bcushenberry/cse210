public class Reception : Event
{
    private string _rsvp;

    public Reception(string title, string desc, string date, Address address, string rsvp) : base (title, desc, date, address)
    {
        _rsvp = rsvp;
    }

    public override string GetShortDesc()
    {
        return $"Event Type: Reception\nTitle: {_title}\nDescription: {_description}\nDate/Time: {_date}";
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDesc()}\nRSVP to {_rsvp}";
    }
}