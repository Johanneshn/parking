using Parking.Domain.Common.ValueObjects;

namespace Parking.UnitTests.Domain.Common.Address;

public class ZipCodeTests
{
    public static IEnumerable<object[]> GetInvalidZipCodes =>
        new List<object[]>
        {
            new object[] { "" },
            new object[] { "AAAA" },
            new object[] { "111" },
            new object[] { "111111" }
        };

    [Theory]
    [MemberData(nameof(GetInvalidZipCodes))]
    public void ZipCode_ShouldThrowArgumentException_WhenInputIsInvalid(string input)
    {
        // Arrange & Act
        Action act = () => new ZipCode(input);

        // Assert
        act.Should().Throw<ArgumentException>();
    }

    [Fact]
    public void ZipCode_ShouldCreateNew_WhenInputIsValid()
    {
        // Arrange
        const string input = "702 18";
        // Act
        var sut = new ZipCode(input);
        // Assert
        sut.Value.Should().BeEquivalentTo(input);
    }
}