public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address()
    {
        _street = "";
        _city = "";
        _state = "";
        _country = "";
    }
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country.ToLower();
    }
    // Return true is country is USA
    public bool IsInUSA()
    {
        if (_country == "usa")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetFullAddress()
    {
        return $"\nAddress: {_street}, \n{_city}, {_state}, \n{_country} ";
    }
}