namespace Parking.Domain.Common.ValueObjects;

public class LongitudeLatitude : ValueObject
{
    public LongitudeLatitude(double longitude, double latitude)
    {
        Longitude = longitude;
        Latitude = latitude;
    }

    public double Longitude { get; }
    public double Latitude { get; }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Longitude;
        yield return Latitude;
    }
}