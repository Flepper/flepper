
namespace Flepper.QueryBuilder
{
    /// <summary>
    /// Logical Operators Extensions
    /// </summary>
    public static class LogicalOperatorsExtensions
    {
        /// <summary>
        /// Add Equal Operator to query
        /// </summary>
        /// <param name="logicalOperators">Logical Operators instance</param>
        /// <param name="value">Value</param>
        /// <returns></returns>
        public static IComparisonOperators EqualTo<T>(this ILogicalOperators logicalOperators, T value)
            => logicalOperators.To<ComparisonOperators>().EqualTo(value);

        /// <summary>
        /// Add Greater Than Operator to query
        /// </summary>
        /// <param name="logicalOperators">Logical Operators instance</param>
        /// <param name="value">Value</param>
        /// <returns></returns>
        public static IComparisonOperators GreaterThan<T>(this ILogicalOperators logicalOperators, T value)
            => logicalOperators.To<ComparisonOperators>().GreaterThan(value);

        /// <summary>
        /// Add Less Than Operator to query
        /// </summary>
        /// <param name="logicalOperators">Logical Operators instance</param>
        /// <param name="value">Value</param>
        /// <returns></returns>
        public static IComparisonOperators LessThan<T>(this ILogicalOperators logicalOperators, T value)
            => logicalOperators.To<ComparisonOperators>().LessThan(value);

        /// <summary>
        /// Add Greater Than Or Equal Operator to query
        /// </summary>
        /// <param name="logicalOperators">Logical Operators instance</param>
        /// <param name="value">Value</param>
        /// <returns></returns>
        public static IComparisonOperators GreaterThanOrEqualTo<T>(this ILogicalOperators logicalOperators, T value)
            => logicalOperators.To<ComparisonOperators>().GreaterThanOrEqualTo(value);

        /// <summary>
        /// Add Less Than Or Equal Operator to query
        /// </summary>
        /// <param name="logicalOperators">Logical Operators instance</param>
        /// <param name="value">Value</param>
        /// <returns></returns>
        public static IComparisonOperators LessThanOrEqualTo<T>(this ILogicalOperators logicalOperators, T value)
            => logicalOperators.To<ComparisonOperators>().LessThanOrEqualTo(value);

        /// <summary>
        /// Add Not Equal Operator to query
        /// </summary>
        /// <param name="logicalOperators">Logical Operators instance</param>
        /// <param name="value">Value</param>
        /// <returns></returns>
        public static IComparisonOperators NotEqualTo<T>(this ILogicalOperators logicalOperators, T value)
            => logicalOperators.To<ComparisonOperators>().NotEqualTo(value);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="logicalOperators"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static IComparisonOperators Contains<T>(this ILogicalOperators logicalOperators, T value)
            => logicalOperators.To<ComparisonOperators>().Contains(value);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="logicalOperators"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static IComparisonOperators StartsWith<T>(this ILogicalOperators logicalOperators, T value)
            => logicalOperators.To<ComparisonOperators>().StartsWith(value);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="logicalOperators"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static IComparisonOperators EndsWith<T>(this ILogicalOperators logicalOperators, T value)
            => logicalOperators.To<ComparisonOperators>().EndsWith(value);
    }
}
