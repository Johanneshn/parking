using Parking.Domain.ParkingLot;
using Parking.Domain.SeedWork;

namespace Parking.Infrastructure.Repositories;

internal class ParkingLotRepository : IParkingLotRepository
{
    public IUnitOfWork UnitOfWork { get; }
        
    public ParkingLot Add(ParkingLot parkingLot)
    {
        throw new NotImplementedException();
    }

    public ParkingLot Update(ParkingLot parkingLot)
    {
        throw new NotImplementedException();
    }

    public Task<ParkingLot> FindAsync(string parkingLotIdentityGuid)
    {
        throw new NotImplementedException();
    }

    public Task<ParkingLot> FindByIdAsync(string id)
    {
        throw new NotImplementedException();
    }
}