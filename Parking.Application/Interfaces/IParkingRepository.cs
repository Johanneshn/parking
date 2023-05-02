using Parking.Domain.SeedWork;

namespace Parking.Application.Interfaces;

public interface IParkingRepository : IRepository<Domain.Parking.Parking>
{
    void AddParking(Domain.Parking.Parking parking);
}