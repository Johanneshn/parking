using Parking.Domain.Common.ValueObjects;

namespace Parking.Domain.ParkingLot;

public sealed class ParkingLot : Entity, IAggregateRoot
{
    public ParkingLot(Address address, string internalName = "")
    {
        Address = address;
        InternalName = internalName;
    }

    public Address Address { get; }
    public string InternalName { get; }

    public override string ToString() => Address.Street;
}