using Parking.Infrastructure.EntityConfigurations;

namespace Parking.Infrastructure.Persistence;

public sealed class ParkingLotDbContext : DbContext, IUnitOfWork
{
    public const string DEFAULT_SCHEMA = "parkinglots";
    public ParkingLotDbContext(DbContextOptions<ParkingLotDbContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }

    public DbSet<ParkingLot> ParkingLots { get; set; }

  
    public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
    {
        // await _mediator.DispatchDomainEventsAsync(this);
        
        var result = await base.SaveChangesAsync(cancellationToken);

        return true;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .ApplyConfigurationsFromAssembly(typeof(ParkingLotDbContext).Assembly);
    modelBuilder.ApplyConfiguration(new ParkingLotEntityTypeConfiguration());
        base.OnModelCreating(modelBuilder);
    }
}