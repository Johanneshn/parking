using MediatR;
using Parking.Application.Contracts;

namespace Parking.Application.Features.RegisterParking;

public sealed record RegisterParkingHandler : IRequestHandler<RegisterParkingCommand, CreateParkingLotResponse>
{
    public Task<CreateParkingLotResponse> Handle(RegisterParkingCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}