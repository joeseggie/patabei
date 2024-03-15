using System.Diagnostics;
using DotNetEnv;

namespace EastSeat.Patabei.Web.Extensions;

public static class WebApplicationExtensions
{
    public static void LoadEnvFile(this WebApplication app, string contentRootPath)
    {
        var envFilePath = Path.Combine(contentRootPath, ".env");
        if (File.Exists(envFilePath))
        {
            Env.Load(envFilePath);
        }
    }
}