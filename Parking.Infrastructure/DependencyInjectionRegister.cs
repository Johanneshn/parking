using Microsoft.Extensions.DependencyInjection;
using Parking.Infrastructure.Repositories;

namespace Parking.Infrastructure;

public static class DependencyInjectionRegister
{
    public static IServiceCollection AddPersistence(
        this IServiceCollection services)
    {
        services.AddDbContext<ParkingLotDbContext>(options => options.UseInMemoryDatabase("database_name"));
        services.AddSingleton<IParkingLotRepository, ParkingLotRepository>();
        return services;
    }
}