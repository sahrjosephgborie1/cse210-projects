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
    public int GetTotalPrice()
    {
        int totalPrice = 0;
        foreach (Product item in _products)
        {   
            int totalCost = item.GetTotalCost();
            totalPrice += totalCost;


            if (_customer.IsInUSA() == true)
            {
                totalPrice += 5;
                return totalPrice;
            }
            else
            {
                totalPrice += 35;
                return totalPrice;
            }


        }

        return totalPrice;
    }
    // code here
    // public string GetPackingLabel()
    // { 
    //     foreach (Product item in _products)
    //     { 
    //         return $"{item.GetName()} + {item.GetProductId().ToString()}";
    //     }
    // }
    public string GetShippingLabel()
    {
        return $"{_customer.GetName()} {_customer.GetAddress()}";
    }


}