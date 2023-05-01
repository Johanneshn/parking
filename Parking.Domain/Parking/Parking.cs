using Parking.Domain.Parking.ValueObjects;

namespace Parking.Domain.Parking;

public sealed class Parking : Entity, IAggregateRoot
{
    public Parking(Guid parkingLotId, Guid userId, LicensePlate licensePlate)
    {
        ParkingLotId = parkingLotId;
        UserId = userId;
        LicensePlate = licensePlate;
    }

    public DateTime Started { get; } = DateTime.UtcNow;
    public DateTime? Ended { get; }
    public Guid ParkingLotId { get; }
    public Guid UserId { get; }
    public LicensePlate LicensePlate { get; }
}