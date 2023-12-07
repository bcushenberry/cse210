public class Event
{
// --- Attributes ---
    protected string _title;
    protected string _description;
    protected string _date;
    protected Address _address;

// --- Constructor
    public Event(string title, string desc, string date, Address address)
    {
        _title = title;
        _description = desc;
        _date = date;
        _address = address;
    }

// --- Behaviors
    public string GetStandardDesc()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate/Time: {_date}\n\nAddress: {_address.GetAddress()}";
    }

    public virtual string GetShortDesc()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate/Time: {_date}";
    }

    public virtual string GetFullDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate/Time: {_date}\n\nAddress: {_address.GetAddress()}";
    }
}