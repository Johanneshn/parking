using Microsoft.EntityFrameworkCore;
using Parking.Domain.ParkingLot;

namespace Parking.Infrastructure.Persistence;

public sealed class ParkingDbContext : DbContext
{
    public ParkingDbContext(DbContextOptions<ParkingDbContext> options)
        : base(options) { }

    public DbSet<ParkingLot> ParkingLots { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .ApplyConfigurationsFromAssembly(typeof(ParkingDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}