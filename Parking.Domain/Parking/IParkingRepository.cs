namespace Parking.Domain.Parking;

public interface IParkingRepository : IRepository<Parking>
{
    void AddParking(Parking parking);
}