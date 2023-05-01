namespace Parking.Domain.Parking.ValueObjects;

public class LicensePlate : ValueObject
{
    public LicensePlate(string licensePlate)
    {
        Value = licensePlate;
    }

    public string Value { get; }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}