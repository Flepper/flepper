using System;
using System.Collections.Concurrent;
using System.Linq;

namespace Flepper.QueryBuilder.Utils
{
    internal class Cache
    {
        private static readonly ConcurrentDictionary<Type, string[]> DtoProperties = new ConcurrentDictionary<Type, string[]>();

        public static string[] GetDtoProperties<T>() where T : class
        {
            var type = typeof(T);

            if (DtoProperties.TryGetValue(type, out string[] data)) return data;

            data = type.GetProperties().Select(x => x.Name).ToArray();
            DtoProperties.TryAdd(type, data);
            return data;
        }
    }
}
