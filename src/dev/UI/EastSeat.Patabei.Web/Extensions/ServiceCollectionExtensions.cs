using EastSeat.Patabei.Application.Contracts.BlobStorage;
using EastSeat.Patabei.Application.Contracts.Secrets;
using EastSeat.Patabei.BlobStorage;
using EastSeat.Patabei.Secrets;
using MediatR;

namespace EastSeat.Patabei.Web.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddPatabeiServices(this IServiceCollection services)
    {
        services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
        services.AddScoped<IEnvironmentVariableService, EnvironmentVariableService>();
        services.AddScoped<IBlobStorageClient, BlobStorageClient>();
    }
}