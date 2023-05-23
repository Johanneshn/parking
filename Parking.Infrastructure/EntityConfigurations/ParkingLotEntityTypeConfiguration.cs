using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Parking.Infrastructure.EntityConfigurations;

public class ParkingLotEntityTypeConfiguration : IEntityTypeConfiguration<ParkingLot>
{
    public void Configure(EntityTypeBuilder<ParkingLot> parkingLotConfiguration)
    {
        parkingLotConfiguration.ToTable("parkinglots", ParkingLotDbContext.DEFAULT_SCHEMA);
        parkingLotConfiguration.HasKey(cr => cr.Id);
        parkingLotConfiguration.OwnsOne(o => o.Address,
            builder =>
            {
                builder.OwnsOne(
                    o => o.ZipCode
                );
                builder.OwnsOne(
                    o => o.LngLat
                );
            }
        );
    } 
}