namespace Parking.Infrastructure.Persistence;

public sealed class ParkingLotDbContext : DbContext, IUnitOfWork
{
    public ParkingLotDbContext(DbContextOptions<ParkingLotDbContext> options)
        : base(options)
    {
    }

    public DbSet<ParkingLot> ParkingLots { get; set; }

    public Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .ApplyConfigurationsFromAssembly(typeof(ParkingLotDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}