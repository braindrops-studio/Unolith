using System;
using System.Collections.Generic;
using System.Linq;

namespace Braindrops.Unolith.Utility
{
    public static class Extensions
    {
        private static Random random = new Random();
     
        public static T GetRandomElement<T>(this IEnumerable<T> list)
        {
            var enumerable = list.ToList();
            return !enumerable.Any() ? default(T) : enumerable.ElementAt(random.Next(enumerable.Count()));
        }
    }
}