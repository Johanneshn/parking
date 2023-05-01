namespace Parking.Domain.User.ValueObjects;

public class Email : ValueObject
{
    private const string regexExpression = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
    private static readonly Regex regex = new Regex(regexExpression, RegexOptions.Compiled | RegexOptions.Singleline);

    public Email(string email)
    {
        if (!IsValid(email))
        {
            throw new ArgumentException(nameof(email));
        }

        Value = email;
    }

    public string Value { get; }

    private static bool IsValid(string email) => regex.IsMatch(email);

    public override string ToString() => Value;

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}