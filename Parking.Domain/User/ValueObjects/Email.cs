namespace Parking.Domain.User.ValueObjects;

public class Email : ValueObject
{
    private const string RegexExpression =
        @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

    private static readonly Regex Regex = new(RegexExpression, RegexOptions.Compiled | RegexOptions.Singleline);

    public Email(string email)
    {
        if (!IsValid(email)) throw new ArgumentException(nameof(email));

        Value = email;
    }

    public string Value { get; }

    private static bool IsValid(string email)
    {
        return Regex.IsMatch(email);
    }

    public override string ToString()
    {
        return Value;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}