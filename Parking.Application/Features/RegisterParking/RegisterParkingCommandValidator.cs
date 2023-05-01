using FluentValidation;

namespace Parking.Application.Features.RegisterParking;

public sealed class RegisterParkingCommandValidator : AbstractValidator<RegisterParkingCommand>
{
    public RegisterParkingCommandValidator()
    {
        RuleFor(request => request.UserId).NotEmpty();
        RuleFor(request => request.ParkingLotId).NotEmpty();
        RuleFor(request => request.LicensePlate).NotEmpty().MinimumLength(6);
    }
}