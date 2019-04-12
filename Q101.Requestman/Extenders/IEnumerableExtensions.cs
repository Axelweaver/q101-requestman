using System;
using System.Collections.Generic;

namespace Q101.Requestman.Extenders
{
    public static class IEnumerableExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> numerable, Action<T> action)
        {
            foreach (var element in numerable)
            {
                action(element);
            }
        }
    }
}
