using MediatR;
using Parking.Application.Contracts;

namespace Parking.Application.Features.RegisterParking;

public sealed record RegisterParkingHandler : IRequestHandler<RegisterParkingCommand, CreateParkingLotResponse>
{
    public Task<CreateParkingLotResponse> Handle(RegisterParkingCommand request, CancellationToken cancellationToken)
    {
        return Task.FromResult(new CreateParkingLotResponse(Guid.NewGuid(), null, null, null, 0, 0));
    }
}