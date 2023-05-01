using Parking.Domain.Parking;
using Parking.Domain.SeedWork;

namespace Parking.Infrastructure.Repositories;

internal class ParkingRepository : IParkingRepository
{
    public IUnitOfWork UnitOfWork { get; }
        
    public void AddParking(Domain.Parking.Parking parking)
    {
        throw new NotImplementedException();
    }
}