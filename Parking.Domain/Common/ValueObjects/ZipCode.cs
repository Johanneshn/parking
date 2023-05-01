namespace Parking.Domain.Common.ValueObjects;

public class ZipCode : ValueObject
{
    private static readonly Regex regex = new Regex(@"^[0-9]{3}\s?[0-9]{2}$", RegexOptions.Compiled | RegexOptions.Singleline);

    public ZipCode(string zipCode)
    {
        var value = zipCode.Trim();

        if (!IsValid(value))
        {
            throw new ArgumentException($"Zip code '{zipCode}' is in an incorrect format.");
        }

        Value = value;
    }

    public string Value { get; }

    public override string ToString() => Value;

    private static bool IsValid(string value) => regex.IsMatch(value);

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}