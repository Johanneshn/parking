using MediatR;
using Parking.Application.Contracts;

namespace Parking.Application.Features.CreateParkingLot;

public sealed class CreateParkingLotCommand : IRequest<CreateParkingLotResponse>
{
    public CreateParkingLotCommand(
        string street,
        string city,
        string zipCode,
        double longitude,
        double latitude)
    {
        Street = street;
        City = city;
        ZipCode = zipCode;
        Longitude = longitude;
        Latitude = latitude;
    }

    public string Street { get; }
    public string City { get; }
    public string ZipCode { get; }
    public double Longitude { get; }
    public double Latitude { get; }
}