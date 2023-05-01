using Mapster;
using Parking.Application.Contracts;
using Parking.Application.Features.CreateParkingLot;

namespace Parking.Api.Common.Mapping
{
    public class ParkingMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<CreateParkingLotRequest, CreateParkingLotCommand>()
                .Map(dest => dest, src => src);
        }
    }
}