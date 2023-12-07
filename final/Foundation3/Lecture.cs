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
        return $"Title: {_title}\nEvent Type: Lecture\nDescription: {_description}\nDate/Time: {_date}";
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDesc()}\n\nSpeaker: {_speaker}\nCapacity: {_capacity} people";
    }
}