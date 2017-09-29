
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
            => comparisonOperators is ILogicalOperators command ? command.And(column) : null;

        /// <summary>
        /// Add Or Comparison Operator to query
        /// </summary>
        /// <param name="comparisonOperators">Comparison Operators instance</param>
        /// <param name="column">Column Name</param>
        /// <returns></returns>
        public static ILogicalOperators Or(this IComparisonOperators comparisonOperators, string column)
            => comparisonOperators is ILogicalOperators command ? command.Or(column) : null;
    }
}
