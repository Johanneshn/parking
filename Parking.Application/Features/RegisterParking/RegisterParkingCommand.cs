using MediatR;
using Parking.Application.Contracts;

namespace Parking.Application.Features.RegisterParking;

public sealed class RegisterParkingCommand : IRequest<CreateParkingLotResponse>
{
    public RegisterParkingCommand(Guid parkingLotId, Guid userId, string licensePlate)
    {
        ParkingLotId = parkingLotId;
        UserId = userId;
        LicensePlate = licensePlate;
    }

    public Guid ParkingLotId { get; }
    public Guid UserId { get; }
    public string LicensePlate { get; }
}