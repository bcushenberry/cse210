public class Order
{
// --- Attributes ---
    private List<Product> _products;
    private Customer _customer;
    private double _totalPrice;

// --- Constructor ---
    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

// --- Methods ---
    public void GetPackingLabel()
    {
//        foreach(Product product in _products)
        for (int i = 0; i < _products.Count(); i++)
        {
            if (i+1 < _products.Count())
            {
            Console.WriteLine($"Product Name: {_products[i].GetName()}");
            Console.WriteLine($"Product ID: {_products[i].GetID()}");
            Console.WriteLine($"Quantity: {_products[i].GetQuantity()}");
            Console.WriteLine("");
            }

            else
            {
            Console.WriteLine($"Product Name: {_products[i].GetName()}");
            Console.WriteLine($"Product ID: {_products[i].GetID()}");
            Console.WriteLine($"Quantity: {_products[i].GetQuantity()}");
            }

        }
    }

    public void GetShippingLabel()
    {
        Console.WriteLine($"{_customer.GetName()}");
        Console.WriteLine($"{_customer.GetAddress()}");
    }

    public double GetTotalPrice()
    {
        double shippingCost = 0; 

        foreach (Product product in _products)
        {
            _totalPrice += product.GetOverallPrice();
        }

        if (_customer.LiveInUS())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

        _totalPrice += shippingCost;
        
        return _totalPrice;
    }

    public void Display()
    {
        Console.WriteLine("--------------------");
        Console.WriteLine("Packing Label");
        Console.WriteLine("--------------------");
        GetPackingLabel();

        Console.WriteLine("--------------------");
        Console.WriteLine("Shipping Label");
        Console.WriteLine("--------------------");
        GetShippingLabel();

        Console.WriteLine("--------------------");
        Console.WriteLine($"Order Total: ${Math.Round(GetTotalPrice(),2)}");
        Console.WriteLine("--------------------");
        Console.WriteLine("");
    }

}