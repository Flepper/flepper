
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
            => logicalOperators is IComparisonOperators command ? command.EqualTo(value) : null;

        /// <summary>
        /// Add Greater Than Operator to query
        /// </summary>
        /// <param name="logicalOperators">Logical Operators instance</param>
        /// <param name="value">Value</param>
        /// <returns></returns>
        public static IComparisonOperators GreaterThan<T>(this ILogicalOperators logicalOperators, T value)
            => logicalOperators is IComparisonOperators command ? command.GreaterThan(value) : null;

        /// <summary>
        /// Add Less Than Operator to query
        /// </summary>
        /// <param name="logicalOperators">Logical Operators instance</param>
        /// <param name="value">Value</param>
        /// <returns></returns>
        public static IComparisonOperators LessThan<T>(this ILogicalOperators logicalOperators, T value)
            => logicalOperators is IComparisonOperators command ? command.LessThan(value) : null;

        /// <summary>
        /// Add Greater Than Or Equal Operator to query
        /// </summary>
        /// <param name="logicalOperators">Logical Operators instance</param>
        /// <param name="value">Value</param>
        /// <returns></returns>
        public static IComparisonOperators GreaterThanOrEqualTo<T>(this ILogicalOperators logicalOperators, T value)
            => logicalOperators is IComparisonOperators command ? command.GreaterThanOrEqualTo(value) : null;

        /// <summary>
        /// Add Less Than Or Equal Operator to query
        /// </summary>
        /// <param name="logicalOperators">Logical Operators instance</param>
        /// <param name="value">Value</param>
        /// <returns></returns>
        public static IComparisonOperators LessThanOrEqualTo<T>(this ILogicalOperators logicalOperators, T value)
            => logicalOperators is IComparisonOperators command ? command.LessThanOrEqualTo(value) : null;

        /// <summary>
        /// Add Not Equal Operator to query
        /// </summary>
        /// <param name="logicalOperators">Logical Operators instance</param>
        /// <param name="value">Value</param>
        /// <returns></returns>
        public static IComparisonOperators NotEqualTo<T>(this ILogicalOperators logicalOperators, T value)
            => logicalOperators is IComparisonOperators command ? command.NotEqualTo<T>(value) : null;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="logicalOperators"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static IComparisonOperators Contains<T>(this ILogicalOperators logicalOperators, T value)
            => logicalOperators is IComparisonOperators command ? command.Contains(value) : null;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="logicalOperators"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static IComparisonOperators StartsWith<T>(this ILogicalOperators logicalOperators, T value)
            => logicalOperators is IComparisonOperators command ? command.StartsWith(value) : null;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="logicalOperators"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static IComparisonOperators EndsWith<T>(this ILogicalOperators logicalOperators, T value)
            => logicalOperators is IComparisonOperators command ? command.EndsWith(value) : null;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logicalOperators"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static IComparisonOperators Between<TFrom, TTo>(this ILogicalOperators logicalOperators, TFrom from, TTo to)
            => logicalOperators is IComparisonOperators command ? command.Between(from, to) : null;
    }
}
