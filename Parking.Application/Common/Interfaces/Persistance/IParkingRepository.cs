namespace Parking.Application.Common.Interfaces
{
    public interface IParkingRepository
    {
        void AddParking(Domain.Parking.Parking parking);
    }
}