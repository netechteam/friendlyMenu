using System.Collections.Generic;
using System.Linq;

namespace Extensions
{
    public static class EnumerableExtensions
    {
        /// <summary>
        /// returns an empty enumerable if the source is null
        /// </summary>
        public static IEnumerable<T> EmptyIfNull<T>(this IEnumerable<T> source)
        {
            if (source == null)
                return Enumerable.Empty<T>();
            else
                return source;
        }

        /// <summary>
        /// takes an enumerable and then splits it into groups of a specified size
        /// </summary>
        public static IEnumerable<IEnumerable<T>> SplitIntoGroups<T>(this IEnumerable<T> source, int groupSize)
        {
            return source
                .Select((item, index) => new { item, key = index / groupSize })
                .GroupBy(x => x.key, x => x.item);
        }
    }
}
