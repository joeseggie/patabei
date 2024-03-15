using MediatR;

using Optional;

namespace EastSeat.Patabei.Application.Features.PriceSurveys.Commands;

/// <summary>
/// Command to upload a price survey file to Azure blob storage.
/// </summary>
public class UploadPriceSurveyCommand : IRequest<Unit>
{
    /// <summary>
    /// Name of the file to be uploaded.
    /// </summary>
    public Option<string> FileName { get; set; }

    /// <summary>
    /// File stream to be uploaded.
    /// </summary>
    public Option<Stream> File { get; set; }

    /// <summary>
    /// ContentType of the file to be uploaded.
    /// </summary>
    public Option<string> ContentType { get; set; }

    /// <summary>
    /// File size in bytes.
    /// </summary>
    public Option<int> FileSize { get; set; }
}