using Parking.Domain.ParkingLot;
using Parking.Domain.SeedWork;

namespace Parking.Application.Interfaces;

public interface IParkingLotRepository : IRepository<ParkingLot>
{
    ParkingLot Add(ParkingLot parkingLot);
    void Update(ParkingLot parkingLot);
    Task<ParkingLot?> GetAsync(int id);
}