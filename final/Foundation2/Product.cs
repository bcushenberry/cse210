public class Product
{
// --- Attributes ---    
    private string _name;
    private int _id;
    private double _price;
    private int _quantity;

// --- Constructor ---
    public Product(string name, int id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

// --- Getters ---
    public double GetOverallPrice()
    {
        return _price * _quantity;
    }
    
    public string GetName()
    {
        return _name;
    }
    
    public int GetID()
    {
        return _id;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
}