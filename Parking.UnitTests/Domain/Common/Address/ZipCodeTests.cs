using Parking.Domain.Common.ValueObjects;

namespace Parking.UnitTests.Domain.Common.Address;

public class ZipCodeTests
{
    [Theory]
    [InlineData("")]
    [InlineData("AAAA")]
    [InlineData("1111")]
    [InlineData("111111")]
    public void ZipCode_ShouldThrowArgumentException_WhenInputIsInvalid(string input)
    {
        // Arange
        // Act
        Action act = () => new ZipCode(input);

        // Assert
        act.Should().Throw<ArgumentException>();
    }

    [Fact]
    public void ZipCode_ShouldCreatew_WhenInputIsValid()
    {
        // Arange
        var input = "702 18";
        // Act
        var sut = new ZipCode(input);
        // Assert
        sut.Value.Should().BeEquivalentTo(input);
    }
}