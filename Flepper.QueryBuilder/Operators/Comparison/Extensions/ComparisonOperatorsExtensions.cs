
namespace Flepper.QueryBuilder
{
    /// <summary>
    /// Comparison Operators Extensions
    /// </summary>
    public static class ComparisonOperatorsExtensions
    {
        /// <summary>
        /// Add And Comparison Operator to query
        /// </summary>
        /// <param name="comparisonOperators">Comparison Operators instance</param>
        /// <param name="column">Column Name</param>
        /// <returns></returns>
        public static ILogicalOperators And(this IComparisonOperators comparisonOperators, string column)
            => comparisonOperators.To<LogicalOperators>().And(column);

        /// <summary>
        /// Add Or Comparison Operator to query
        /// </summary>
        /// <param name="comparisonOperators">Comparison Operators instance</param>
        /// <param name="column">Column Name</param>
        /// <returns></returns>
        public static ILogicalOperators Or(this IComparisonOperators comparisonOperators, string column)
            => comparisonOperators.To<LogicalOperators>().Or(column);
    }
}
