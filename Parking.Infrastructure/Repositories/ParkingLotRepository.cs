namespace Parking.Infrastructure.Repositories;

internal class ParkingLotRepository : IParkingLotRepository
{
    private readonly ParkingLotDbContext _context;

    public ParkingLotRepository(ParkingLotDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public IUnitOfWork UnitOfWork => _context;

    public ParkingLot Add(ParkingLot parkingLot)
    {
        return _context.Add(parkingLot).Entity;
    }

    public void Update(ParkingLot parkingLot)
    {
        _context.Entry(parkingLot).State = EntityState.Modified;
    }

    public async Task<ParkingLot?> GetAsync(int id)
    {
        var parkingLot = await _context.ParkingLots.FirstOrDefaultAsync(p => p.Id == id);
        if (parkingLot is null) parkingLot = _context.ParkingLots.Local.FirstOrDefault(p => p.Id == id);

        return parkingLot;
    }
}