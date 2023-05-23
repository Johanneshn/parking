using Parking.Domain.Common.ValueObjects;

namespace Parking.UnitTests.Domain.Common.ValueObjects;

public class LongitudeLatitudeTests
{
    public static IEnumerable<object[]> GetInvalidCoordinates =>
        new List<object[]>
        {
            new object[] { -181, 0 },
            new object[] { 181, 0 },
            new object[] { 0, -91 },
            new object[] { 0, 91 }
        };

    [Fact]
    public void LongitudeLatitude_ShouldCreateValidObject_WhenInputIsValid()
    {
        // Arrange
        const double validLongitude = 45.00;
        const double validLatitude = 50.00;

        // Act
        var sut = new LongitudeLatitude(validLongitude, validLatitude);

        // Assert
        sut.Longitude.Should().Be(validLongitude);
        sut.Latitude.Should().Be(validLatitude);
    }

    [Theory]
    [MemberData(nameof(GetInvalidCoordinates))]
    public void LongitudeLatitude_ShouldThrowInvalidArgumentException_WhenLongitudeIsInvalid(double longitude,
        double latitude)
    {
        // Arrange & Act 
        Action act = () => new LongitudeLatitude(longitude, latitude);

        // Assert
        act.Should().Throw<ArgumentException>();
    }
}