public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string desc, string date, Address address, string speaker, int capacity) : base (title, desc, date, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string GetShortDesc()
    {
        return $"Event Type: Lecture\nTitle: {_title}\nDescription: {_description}\nDate/Time: {_date}";
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDesc()}\nSpeaker: {_speaker}\nCapacity: {_capacity} people";
    }
}