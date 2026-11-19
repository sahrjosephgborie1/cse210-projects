public class Customer
{
    private string _name;
    private Address _address;

    public Customer(Address address)
    {
        _name = "";
        _address = address;
    }
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public bool IsInUSA()
    {
        if (_address.IsInUSA())
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // getters
    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address.GetFullAddress();
    }
}