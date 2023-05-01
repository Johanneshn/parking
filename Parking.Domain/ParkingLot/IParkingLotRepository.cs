namespace Parking.Domain.ParkingLot;

public interface IParkingLotRepository : IRepository<ParkingLot>
{
    ParkingLot Add(ParkingLot parkingLot);
    ParkingLot Update(ParkingLot parkingLot);
    Task<ParkingLot> FindAsync(string parkingLotIdentityGuid);
    Task<ParkingLot> FindByIdAsync(string id);
}