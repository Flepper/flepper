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

        internal static string[] GetTypeProperties<T>()
            where T : class
            => GetTypeProperties(typeof(T));

        internal static string[] GetTypeProperties(Type type)
            => GetTypeProperties(ref type, () => GetPropertiesNameFromType(type));

        internal static string[] GetPropertiesFromExpression<T>(Expression<Func<T, object>> newLambdaExpression)
            where T : class
        {
            if (newLambdaExpression.Body is NewExpression newExpression)
                return HandleNewExpression(newExpression);

            if (newLambdaExpression.Body is MemberExpression memberExpression && memberExpression.Member is PropertyInfo propertyInfo)
                return HandleProperty(propertyInfo, newLambdaExpression.ToString());

            throw new NotSupportedException(NOT_SUPPORTED_MESSAGE);
        }

        private static string[] GetTypeProperties(ref Type type, Func<string[]> getProperties)
        {
            if (type != null && DtoProperties.TryGetValue(type, out string[] data)) return data;

            data = getProperties();
            DtoProperties.TryAdd(type, data);
            return data;
        }

        private static string[] HandleProperty(PropertyInfo propertyInfo, string className)
        {
            var type = ParameterObjectBuilder.GetTypeFromName(className);

            string[] GetProperties()
            {
                var propertyType = propertyInfo.PropertyType;
                if (propertyType.IsValueType == false && propertyType != typeof(string))
                    throw new NotSupportedException("Only string's or value types expression are supported");

                type = ParameterObjectBuilder.CreateClass(new Dictionary<string, object>
                {
                    [propertyInfo.Name] = propertyType.IsValueType ? Activator.CreateInstance(propertyType) : ""
                }, className);
                return GetPropertiesNameFromType(type);
            }

            return GetTypeProperties(ref type, GetProperties);
        }

        private static string[] HandleNewExpression(NewExpression newExpression)
        {
            var type = newExpression.Constructor.DeclaringType;
            if (type.FullName.Contains("Anonymous") == false)
                throw new NotSupportedException("The given expression is not supported, you must pass a expression that return an anonymous object, something like that: () => new { dto.Property1, dto.Property2 }");

            return GetTypeProperties(type);
        }

        private static string[] GetPropertiesNameFromType(Type type)
            => type.GetProperties().Select(x => x.Name).ToArray();
    }
}
