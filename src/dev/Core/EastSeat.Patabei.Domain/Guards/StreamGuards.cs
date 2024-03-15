using Optional;

namespace EastSeat.Patabei.Domain.Guards;

public static partial class Guard
{
    public static partial class Against
    {
        /// <summary>
        /// Guard against an empty stream.
        /// </summary>
        /// <param name="optionalValue"></param>
        /// <returns></returns>
        public static bool EmptyStream(Option<Stream> optionalValue)
        {
            var stream = optionalValue.ValueOr(() => Stream.Null);

            return stream is not null && stream.Length == 0;
        }
    }
}