using EastSeat.Patabei.Application.Features.PriceSurveys.Commands;
using EastSeat.Patabei.Domain.Guards;

using FluentValidation;

using Optional;

namespace EastSeat.Patabei.Application.Features.PriceSurveys.Validators;

/// <summary>
/// Validate the <see cref="UploadPriceSurveyCommand"/>.
/// </summary>
class UploadPriceSurveyCommandValidator : AbstractValidator<UploadPriceSurveyCommand>
{
    public UploadPriceSurveyCommandValidator()
    {
        RuleFor(priceSurveyUpload => priceSurveyUpload.FileName)
            .Must(Guard.Against.NonEmptyString).WithMessage("File name is required.");

        RuleFor(x => x.File)
            .Must(Guard.Against.EmptyStream).WithMessage("File stream is required.");

        RuleFor(x => x.ContentType)
            .Must(Guard.Against.NonEmptyString).WithMessage("File content type is required.");
    }
}