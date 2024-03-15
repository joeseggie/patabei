using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

using EastSeat.Patabei.Application.Contracts.BlobStorage;

namespace EastSeat.Patabei.BlobStorage;

/// <summary>
/// Client to make requests to Azure Blob Storage service.
/// </summary>
public class BlobStorageClient : IBlobStorageClient
{
    /// <inheritdoc />
    public async Task UploadFileToBlobAsync(string blobName, Stream stream, string contentType)
    {
        string storageConnectionString = "azure-storage-connection-string";
        string blobContainerName = "your-container-name";

        BlobServiceClient blobServiceClient = new(storageConnectionString);
        BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(blobContainerName);
        await containerClient.CreateIfNotExistsAsync();
        BlobClient blobClient = containerClient.GetBlobClient(blobName);

        await blobClient.UploadAsync(stream, new BlobHttpHeaders { ContentType = contentType });
        stream.Close();
    }
}
