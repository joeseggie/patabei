using EastSeat.Patabei.Application.Contracts.BlobStorage;
using EastSeat.Patabei.Application.Features.PriceSurveys.Commands;
using EastSeat.Patabei.Application.Features.PriceSurveys.Validators;
using EastSeat.Patabei.Domain.Guards;

using MediatR;

using Optional.Unsafe;

namespace EastSeat.Patabei.Application.Features.PriceSurveys.Handlers;

public class UploadPriceSurveyCommandHandler(IBlobStorageClient blobStorageClient) : IRequestHandler<UploadPriceSurveyCommand, Unit>
{
    private readonly IBlobStorageClient _blobStorageClient = blobStorageClient;

    public async Task<Unit> Handle(UploadPriceSurveyCommand request, CancellationToken cancellationToken)
    {
        UploadPriceSurveyCommandValidator uploadRequestValidator = new();
        var validationResult = await uploadRequestValidator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid || validationResult.Errors.Count > 0)
        {
            // TODO: Log failed survey file upload request.
            return Unit.Value;
        }

        var priceSurveyFileName = request.FileName.ValueOrFailure("Missing price survey upload file name.");
        var priceSurveyFileContentType = request.ContentType.ValueOrFailure("Missing price survey upload file content type.");
        var priceSurveyFileStream = request.File.ValueOrFailure("Missing price survey upload file stream.");

        await _blobStorageClient.UploadFileToBlobAsync(
                priceSurveyFileName,
                priceSurveyFileStream,
                priceSurveyFileContentType);

        return Unit.Value;
    }
}