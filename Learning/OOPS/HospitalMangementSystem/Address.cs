namespace ConsoleAppLearning1.Learning.Operator.Learning.OOPS.HospitalMangementSystem;


public class Address
{
    public string City { get; set; }

    public string Street { get; set; }

    public string PostalCode { get; set; }

    public string Country { get; set; }

    public Address()
    {
    }

    public Address(string city,
        string street,
        string postalCode,
        string country)
    {
        City = city;
        Street = street;
        PostalCode = postalCode;
        Country = country;
    }

    // Copy Constructor
    public Address(Address other)
    {
        City = other.City;
        Street = other.Street;
        PostalCode = other.PostalCode;
        Country = other.Country;
    }

    public override string ToString()
    {
        return $"{Street}, {City}, {PostalCode}, {Country}";
    }
}