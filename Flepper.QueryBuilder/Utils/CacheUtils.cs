using System;
using System.Collections.Concurrent;
using System.Linq;

namespace Flepper.QueryBuilder.Utils
{
    internal class CacheUtils
    {
        private static readonly ConcurrentDictionary<Type, string[]> DtoProperties = new ConcurrentDictionary<Type, string[]>();

        public static string[] GetDtoProperties<T>() where T : class
        {
            var type = typeof(T);

            if (!DtoProperties.ContainsKey(type))
            {
                AddDtoPropertiesToCache(type);
            }

            if (!DtoProperties.TryGetValue(type, out string[] data))
            {
                throw new Exception($"Can't find a cache entry for type {type.Name}");
            }

            return data;
        }

        private static void AddDtoPropertiesToCache(Type type)
        {
            var columns = type
                ?.GetProperties()
                ?.Select(x => x.Name)
                .ToArray() ?? new string[] { };

            DtoProperties.TryAdd(type, columns);
        }
    }
}
