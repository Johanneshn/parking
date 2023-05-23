public class ZipCode : ValueObject
{
    private static readonly Regex
        Regex = new(@"^[0-9]{3}\s?[0-9]{2}$", RegexOptions.Compiled | RegexOptions.Singleline);

    public ZipCode(string zipCode)
    {
        var value = zipCode.Trim();

        if (!IsValid(value))
            throw new ArgumentException($"Zip code '{zipCode}' is in an incorrect format.", nameof(zipCode));

        Value = value;
    }

    public string Value { get; }

    public override string ToString()
    {
        return Value;
    }

    private static bool IsValid(string value)
    {
        return Regex.IsMatch(value);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}