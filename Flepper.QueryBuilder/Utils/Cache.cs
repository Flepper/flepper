using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Flepper.QueryBuilder.Utils
{
    internal static class Cache
    {
        internal static readonly ConcurrentDictionary<Type, string[]> DtoProperties = new ConcurrentDictionary<Type, string[]>();
        internal const string NOT_SUPPORTED_MESSAGE = "The given expression is not supported, you must pass a expression that return an anonymou object, something like that: () => new { dto.Property1, dto.Property2 }";

        internal static string[] GetDtoProperties<T>()
            where T : class
            => GetDtoProperties(typeof(T));

        internal static string[] GetDtoProperties(Type type)
        {
            if (DtoProperties.TryGetValue(type, out string[] data)) return data;

            data = type.GetProperties().Select(x => x.Name).ToArray();
            DtoProperties.TryAdd(type, data);
            return data;
        }

        internal static string[] GetPropertiesFromExpression<T>(Expression<Func<T, object>> newLambdaExpression)
            where T : class
        {
            if (newLambdaExpression.Body is NewExpression newExpression)
                return HandleNewExpression(newExpression);

            if (newLambdaExpression.Body is MemberExpression memberExpression && memberExpression.Member is PropertyInfo propertyInfo)
                return HandleProperty(propertyInfo);

            throw new NotSupportedException(NOT_SUPPORTED_MESSAGE);
        }

        private static string[] HandleProperty(PropertyInfo propertyInfo)
        {
            var propertyType = propertyInfo.PropertyType;
            if (propertyType.IsValueType == false && propertyType != typeof(string))
                throw new NotSupportedException("Only string's or value types expression are supported");

            var @class = ParameterObjectBuilder.CreateClass(new Dictionary<string, object>
            {
                [propertyInfo.Name] = propertyType.IsValueType ? Activator.CreateInstance(propertyType) : ""
            });
            return GetDtoProperties(@class);
        }

        private static string[] HandleNewExpression(NewExpression newExpression)
        {
            var type = newExpression.Constructor.DeclaringType;
            if (type.FullName.Contains("Anonymous") == false)
                throw new NotSupportedException("The given expression is not supported, you must pass a expression that return an anonymous object, something like that: () => new { dto.Property1, dto.Property2 }");

            return GetDtoProperties(type);
        }
    }
}
