using FluentValidation;

namespace Parking.Application.Features.CreateParkingLot;

public sealed class CreateParkingLotCommandValidator : AbstractValidator<CreateParkingLotCommand>
{
    public CreateParkingLotCommandValidator()
    {
        RuleFor(request => request.City).NotEmpty();
        RuleFor(request => request.ZipCode).NotEmpty();
        RuleFor(request => request.Street).NotEmpty();

        RuleFor(request => request.Latitude)
            .GreaterThanOrEqualTo(-90)
            .LessThanOrEqualTo(90);

        RuleFor(request => request.Longitude)
            .GreaterThanOrEqualTo(-180)
            .LessThanOrEqualTo(180);
    }
}