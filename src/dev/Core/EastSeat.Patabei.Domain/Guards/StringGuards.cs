using Optional;

namespace EastSeat.Patabei.Domain.Guards;

public static partial class Guard
{
    public static partial class Against
    {
        /// <summary>
        /// Guard against a string that is null or empty.
        /// </summary>
        /// <param name="optionalValue">Optional string value to validate.</param>
        /// <returns>True if the string is not empty, otherwise false.</returns>
        public static bool NonEmptyString(Option<string> optionalValue)
        {
            var value = optionalValue.ValueOr(string.Empty);

            return !string.IsNullOrEmpty(value.Trim());
        }
    }
}