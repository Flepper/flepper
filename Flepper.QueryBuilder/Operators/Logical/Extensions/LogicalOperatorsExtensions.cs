
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
        public static IComparisonOperators EqualTo(this ILogicalOperators logicalOperators, string value)
            => logicalOperators.To<ComparisonOperators>().EqualTo(value);

        /// <summary>
        /// Add Equal Operator to query
        /// </summary>
        /// <param name="logicalOperators">Logical Operators instance</param>
        /// <param name="value">Value</param>
        /// <returns></returns>
        public static IComparisonOperators EqualTo(this ILogicalOperators logicalOperators, int value)
            => logicalOperators.To<ComparisonOperators>().EqualTo(value);

        /// <summary>
        /// Add Greater Than Operator to query
        /// </summary>
        /// <param name="logicalOperators">Logical Operators instance</param>
        /// <param name="value">Value</param>
        /// <returns></returns>
        public static IComparisonOperators GreaterThan(this ILogicalOperators logicalOperators, int value)
            => logicalOperators.To<ComparisonOperators>().GreaterThan(value);

        /// <summary>
        /// Add Less Than Operator to query
        /// </summary>
        /// <param name="logicalOperators">Logical Operators instance</param>
        /// <param name="value">Value</param>
        /// <returns></returns>
        public static IComparisonOperators LessThan(this ILogicalOperators logicalOperators, int value)
            => logicalOperators.To<ComparisonOperators>().LessThan(value);

        /// <summary>
        /// Add Greater Than Or Equal Operator to query
        /// </summary>
        /// <param name="logicalOperators">Logical Operators instance</param>
        /// <param name="value">Value</param>
        /// <returns></returns>
        public static IComparisonOperators GreaterThanOrEqualTo(this ILogicalOperators logicalOperators, int value)
            => logicalOperators.To<ComparisonOperators>().GreaterThanOrEqualTo(value);

        /// <summary>
        /// Add Less Than Or Equal Operator to query
        /// </summary>
        /// <param name="logicalOperators">Logical Operators instance</param>
        /// <param name="value">Value</param>
        /// <returns></returns>
        public static IComparisonOperators LessThanOrEqualTo(this ILogicalOperators logicalOperators, int value)
            => logicalOperators.To<ComparisonOperators>().LessThanOrEqualTo(value);

        /// <summary>
        /// Add Not Equal Operator to query
        /// </summary>
        /// <param name="logicalOperators">Logical Operators instance</param>
        /// <param name="value">Value</param>
        /// <returns></returns>
        public static IComparisonOperators NotEqualTo(this ILogicalOperators logicalOperators, int value)
            => logicalOperators.To<ComparisonOperators>().NotEqualTo(value);

        /// <summary>
        /// Add Not Equal Operator to query
        /// </summary>
        /// <param name="logicalOperators">Logical Operators instance</param>
        /// <param name="value">Value</param>
        /// <returns></returns>
        public static IComparisonOperators NotEqualTo(this ILogicalOperators logicalOperators, string value)
            => logicalOperators.To<ComparisonOperators>().NotEqualTo(value);
    }
}
