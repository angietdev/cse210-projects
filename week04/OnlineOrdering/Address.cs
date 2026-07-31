public class Address
{
    // All member variables are private
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    // Constructor
    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    // Getters and Setters
    public string GetStreet() { return _street; }
    public void SetStreet(string street) { _street = street; }

    public string GetCity() { return _city; }
    public void SetCity(string city) { _city = city; }

    public string GetStateProvince() { return _stateProvince; }
    public void SetStateProvince(string stateProvince) { _stateProvince = stateProvince; }

    public string GetCountry() { return _country; }
    public void SetCountry(string country) { _country = country; }

    // Method: check if in USA
    public bool IsInUSA()
    {
        return _country.ToLower() == "usa";
    }

    // Method: return full address as string
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_stateProvince}\n{_country}";
    }
}