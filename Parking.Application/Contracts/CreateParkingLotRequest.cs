namespace Parking.Application.Contracts;

public record CreateParkingLotRequest(
    string Street,
    string City,
    string ZipCode,
    double Longitude,
    double Latitude);

public record CreateParkingLotResponse(
    Guid Id,
    string Street,
    string City,
    string ZipCode,
    double Longitude,
    double Latitude);