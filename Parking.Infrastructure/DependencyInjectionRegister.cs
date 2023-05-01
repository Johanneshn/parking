using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Parking.Domain.Parking;
using Parking.Domain.ParkingLot;
using Parking.Infrastructure.Persistence;
using Parking.Infrastructure.Repositories;

namespace Parking.Infrastructure
{
    public static class DependencyInjectionRegister
    {
        public static IServiceCollection AddPersistance(
            this IServiceCollection services)
        {
            services.AddDbContext<ParkingDbContext>(options => options.UseInMemoryDatabase(databaseName: "database_name"));
            services.AddSingleton<IParkingLotRepository, ParkingLotRepository>();
            services.AddSingleton<IParkingRepository, ParkingRepository>();
            return services;
        }
    }
}