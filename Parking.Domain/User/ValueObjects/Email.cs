namespace Parking.Domain.User.ValueObjects;

public partial class Email : ValueObject
{
    private static readonly Regex Regex = EmailValidationRegex();

    public Email(string email)
    {
        if (!IsValid(email))
        {
            throw new ArgumentException(nameof(email));
        }

        Value = email;
    }

    public string Value { get; }

    private static bool IsValid(string email) => Regex.IsMatch(email);

    public override string ToString() => Value;

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    [GeneratedRegex("^([\\w-\\.]+)@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([\\w-]+\\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$", RegexOptions.Compiled | RegexOptions.Singleline)]
    private static partial Regex EmailValidationRegex();
}