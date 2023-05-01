using Parking.Domain.ParkingLot;

namespace Parking.Application.Common.Interfaces
{
    public interface IParkingLotRepository
    {
        void AddParkingLot(ParkingLot parkingLot);
    }
}