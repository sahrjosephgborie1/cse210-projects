public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    
    }
    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    // GetTotalPrice()
    public decimal GetTotalPrice()
    {
          decimal totalCost = 0m;

        foreach (Product product in _products)
        {
            totalCost += product.GetTotalCost();
        }
        decimal shippingCost = _customer.IsInUSA() ? 5m : 35m;
        return totalCost + shippingCost;    
    }
 
    public string GetPackingLabel()
    { 
        List<string> lines = new List<string>();

        foreach (Product product in _products)
        { 
            lines.Add( $"{product.GetName()}  (ID: {product.GetProductId().ToString()})");
        }
        return string.Join("\n", lines);
    }
    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress()}";
    }


}