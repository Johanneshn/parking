using MediatR;
using Parking.Application.Contracts;
using Parking.Application.Interfaces;
using Parking.Domain.Common.ValueObjects;
using Parking.Domain.ParkingLot;

namespace Parking.Application.Features.CreateParkingLot;

public sealed class CreateParkingLotHandler : IRequestHandler<CreateParkingLotCommand, CreateParkingLotResponse>
{
    private readonly IParkingLotRepository _repository;

    public CreateParkingLotHandler(IParkingLotRepository repository)
    {
        _repository = repository;
    } 
    public async Task<CreateParkingLotResponse> Handle(CreateParkingLotCommand request, CancellationToken cancellationToken)
    {
        var address = new Address(
            request.Street, 
            request.City, 
            new ZipCode(request.ZipCode),
            new LongitudeLatitude(request.Longitude, request.Latitude)
        );
        var parkingLot = new ParkingLot(address);
        
        _repository.Add(parkingLot);
        
        await _repository.UnitOfWork.SaveChangesAsync(cancellationToken);
        
        return new CreateParkingLotResponse(
            parkingLot.Id,
            parkingLot.Address.Street,
            parkingLot.Address.City,
            parkingLot.Address.ZipCode.Value,
            parkingLot.Address.LngLat.Longitude,
            parkingLot.Address.LngLat.Latitude
        );
    }
}