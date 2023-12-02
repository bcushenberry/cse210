public class Address
{
// --- Attributes ---    
    private string _building;
    private string _street;
    private string _city;
    private string _state;

// --- Constructor ---
    public Address(string street, string city, string state, string building = "")
    {
        _street = street;
        _city = city;
        _state = state;
        _building = building;
    }

// --- Getters ---
    public string GetAddress()
    {
        return $"\n{_building}{_street}\n{_city}, {_state}";
    }

/* 320 Science & Technology Center
510 S Center St
Rexburg, ID 83460
 */

}