using System;
using System.Collections.Generic;

namespace Linq
{
    public static class Linq
    {
        public static T FirstOrDefault<T>(this IEnumerable<T> source)
        {
            return FirstOrDefault<T>(source, e => true);
        }

        public static T FirstOrDefault<T>(this IEnumerable<T> source, Predicate<T> predicate)
        {
            if (source == null)
            {
                throw new ArgumentException("null");
            }

            if (predicate == null)
            {
                throw new ArgumentException("null");
            }

            foreach (var element in source)
            {
                if (predicate(element))
                {
                    return element;
                }
            }

            return default(T);
        }
    }
}
