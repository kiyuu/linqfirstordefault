using System;
using System.Collections.Generic;

namespace Linq
{
    public static class Linq
    {
        public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source)
        {
            if (source == null)
            {
                throw new ArgumentException("Null");
            }

            IList<TSource> list = source as IList<TSource>;
            if (list != null)
            {
                if (list.Count > 0) return list[0];
            }
            else
            {
                using (IEnumerator<TSource> e = source.GetEnumerator())
                {
                    if (e.MoveNext()) return e.Current;
                }
            }
            return default(TSource);
        }

        public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source, Predicate<TSource> predicate)
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

            return default(TSource);
        }
    }
}
