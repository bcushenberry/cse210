public class Address
{
// --- Attributes ---    
    private string _street;
    private string _city;
    private string _state;
    private string _country;

// --- Constructor ---
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

// --- Getters ---
    public string GetAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }

    public string GetCountry()
    {
        return _country;
    }

}