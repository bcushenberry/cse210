public class Customer
{
// --- Attributes ---    
    private string _name;
    private Address _address;
    private bool _inUS;

// --- Constructor ---
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

// --- Methods ---
    public bool LiveInUS()
    {
        if (_address.GetCountry() == "USA")
        {
            _inUS = true;
        }

        else _inUS = false;

        return _inUS;
    }

// --- Getters ---
    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address.GetAddress();
    }
}