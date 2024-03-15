using System.IO;
using System.Threading.Tasks;

namespace EastSeat.Patabei.Application.Contracts.BlobStorage;

/// <summary>
/// Interface for Blob Storage Client
/// </summary>
public interface IBlobStorageClient
{
    /// <summary>
    /// Uploads a file to a blob storage
    /// </summary>
    /// <param name="blobName">Blob container name.</param>
    /// <param name="stream">Blob to upload.</param>
    /// <param name="contentType">Blob content type.</param>
    /// <returns></returns>
    Task UploadFileToBlobAsync(string blobName, Stream stream, string contentType);
}