using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Parking.Application.Contracts;
using Parking.Application.Features.CreateParkingLot;
using Parking.Application.Features.RegisterParking;

namespace Parking.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ParkingLotController : ControllerBase
{
    private readonly ISender _mediator;
    private readonly IMapper _mapper;

    public ParkingLotController(ISender mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task<IActionResult> CreateParkingLot(CreateParkingLotRequest request)
    {
        var command = _mapper.Map<CreateParkingLotCommand>(request);
        var result = await _mediator.Send(command);

        return Ok(result);
    }
}