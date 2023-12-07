public class Reception : Event
{
    private string _rsvp;

    public Reception(string title, string desc, string date, Address address, string rsvp) : base (title, desc, date, address)
    {
        _rsvp = rsvp;
    }

    public override string GetShortDesc()
    {
        return $"Title: {_title}\nEvent Type: Reception\nDescription: {_description}\nDate/Time: {_date}";
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDesc()}\n\nRSVP to {_rsvp}";
    }
}