namespace Parking.Application.Contracts
{
    public record CreateParkingLotRequest(
        string street,
        string city,
        string zipCode,
        double longitude,
        double latitude);

    public record CreateParkingLotResponse(
        Guid id,
        string street,
        string city,
        string zipCode,
        double longitude,
        double latitude);
}