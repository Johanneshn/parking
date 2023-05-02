using Parking.Domain.SeedWork;

namespace Parking.UnitTests.SeedWork;

public class ValueObjectTests
{
    private static readonly ValueObject APrettyValueObject = new ValueObjectA(1, "2",
        Guid.Parse("97ea43f0-6fef-4fb7-8c67-9114a7ff6ec0"), new ComplexObject(2, "3"));

    public static readonly TheoryData<ValueObject?, ValueObject?, string> EqualValueObjects =
        new()
        {
            {
                null,
                null,
                "they should be equal because they are both null"
            }
        };

    public static readonly TheoryData<ValueObject, ValueObject, string> NonEqualValueObjects =
        new()
        {
            {
                new ValueObjectA(1, "2", Guid.Parse("97ea43f0-6fef-4fb7-8c67-9114a7ff6ec0"),
                    new ComplexObject(2, "3")),
                new ValueObjectA(2, "2", Guid.Parse("97ea43f0-6fef-4fb7-8c67-9114a7ff6ec0"),
                    new ComplexObject(2, "3")),
                "they should not be equal because the 'A' member on ValueObjectA is different among them"
            }
        };

    [Theory]
    [MemberData(nameof(EqualValueObjects))]
    public void Equals_WhenEqualValueObjects_ShouldReturnsTrue(ValueObject instanceA, ValueObject instanceB,
        string reason)
    {
        // Act
        var result = EqualityComparer<ValueObject>.Default.Equals(instanceA, instanceB);

        // Assert
        Assert.True(result, reason);
    }

    [Theory]
    [MemberData(nameof(NonEqualValueObjects))]
    public void Equals_WhenNotEqualValueObjects_ShouldReturnsFalse(ValueObject instanceA, ValueObject instanceB,
        string reason)
    {
        // Act
        var result = EqualityComparer<ValueObject>.Default.Equals(instanceA, instanceB);

        // Assert
        Assert.False(result, reason);
    }

    private class ValueObjectA : ValueObject
    {
        public ValueObjectA(int a, string b, Guid c, ComplexObject d, string notAnEqualityComponent = null)
        {
            A = a;
            B = b;
            C = c;
            D = d;
            NotAnEqualityComponent = notAnEqualityComponent;
        }

        public int A { get; }
        public string B { get; }
        public Guid C { get; }
        public ComplexObject D { get; }
        public string NotAnEqualityComponent { get; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return A;
            yield return B;
            yield return C;
            yield return D;
        }
    }

    private class ValueObjectB : ValueObject
    {
        public ValueObjectB(int a, string b, params int[] c)
        {
            A = a;
            B = b;
            C = c.ToList();
        }

        public int A { get; }
        public string B { get; }

        public List<int> C { get; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return A;
            yield return B;

            foreach (var c in C) yield return c;
        }
    }

    private class ComplexObject : IEquatable<ComplexObject>
    {
        public ComplexObject(int a, string b)
        {
            A = a;
            B = b;
        }

        public int A { get; }

        public string B { get; }

        public bool Equals(ComplexObject? other)
        {
            return other != null &&
                   A == other.A &&
                   B == other.B;
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ComplexObject);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(A, B);
        }
    }
}