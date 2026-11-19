public class Product
{
    public string _name;
    private int _productId;
    private int _price;
    private int _quantity;

    public Product(string name, int productId, int price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    // return the total cost
    public int GetTotalCost()
    {
        return _price * _quantity;
    }
    public string GetName()
    {
        return _name;
    }
    public int GetProductId()
    {
        return _productId;
    }
}