using Optional;

namespace EastSeat.Patabei.Application.Contracts.Secrets;

/// <summary>
/// Environment variable service interface.
/// </summary>
public interface IEnvironmentVariableService
{
    /// <summary>
    /// Get the value of the environment variable with the specified name.
    /// </summary>
    /// <param name="name">Key of the environment variable to get.</param>
    /// <returns>Value of the environment variable as a string if it exists.</returns>
    public Option<string> GetEnvironmentVariable(string environmentVariableKey);
}