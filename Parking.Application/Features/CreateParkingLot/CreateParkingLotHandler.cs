using MediatR;
using Parking.Application.Contracts;

namespace Parking.Application.Features.CreateParkingLot;

public sealed class CreateParkingLotHandler : IRequestHandler<CreateParkingLotCommand, CreateParkingLotResponse>
{
    public Task<CreateParkingLotResponse> Handle(CreateParkingLotCommand request, CancellationToken cancellationToken)
    {
        return Task.FromResult(new CreateParkingLotResponse(Guid.NewGuid(), "", "", "", 0, 0));
    }
}