namespace Parking.Domain.Common.ValueObjects;

public class Address : ValueObject
{
    public Address(string street, string city, ZipCode zipCode, LongitudeLatitude lngLat)
    {
        Street = street;
        City = city;
        ZipCode = zipCode;
        LngLat = lngLat;
    }

    public string Street { get; set; }
    public string City { get; set; }
    public ZipCode ZipCode { get; set; }
    public LongitudeLatitude LngLat { get; }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Street;
        yield return City;
        yield return ZipCode;
        yield return LngLat;
    }
}