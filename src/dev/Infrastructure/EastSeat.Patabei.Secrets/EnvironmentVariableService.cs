using EastSeat.Patabei.Application.Contracts.Secrets;
using Optional;

namespace EastSeat.Patabei.Secrets;

/// <summary>
/// Service to access environment variables.
/// </summary>
public class EnvironmentVariableService : IEnvironmentVariableService
{
    /// <inheritdoc />
    public Option<string> GetEnvironmentVariable(string environmentVariableKey)
    {
        var environmentVariableValue = Environment.GetEnvironmentVariable(environmentVariableKey);

        return environmentVariableValue is not null ? Option.Some(environmentVariableValue) : Option.None<string>();
    }
}
