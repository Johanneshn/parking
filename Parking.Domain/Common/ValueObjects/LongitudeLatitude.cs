namespace Parking.Domain.Common.ValueObjects;

public class LongitudeLatitude : ValueObject
{
    public LongitudeLatitude(double longitude, double latitude)
    {
        if (IsLongitudeValid(longitude) is false)
        {
            throw new ArgumentException("Longitude must be between -180 and 180 degrees.", nameof(longitude));
        }
        if (IsLatitudeValid(latitude) is false)
        {
            throw new ArgumentException("Latitude must be between -90 and 90 degrees.", nameof(latitude));
        }
        Longitude = longitude;
        Latitude = latitude;
    }

    private static bool IsLongitudeValid(double value) => value is >= -180 and <= 180;
    private static bool IsLatitudeValid(double value) => value is >= -90 and <= 90;
    
    public double Longitude { get; }
    public double Latitude { get; }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Longitude;
        yield return Latitude;
    }
}