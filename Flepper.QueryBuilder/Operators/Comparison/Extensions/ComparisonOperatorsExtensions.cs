
using Flepper.QueryBuilder.Operators.Grouping.Interfaces;

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
        /// Add And Comparison Operator to query
        /// </summary>
        /// <param name="comparisonOperators">Comparison Operators instance</param>
        /// <param name="tableAlias">Table Alias</param>
        /// <param name="column">Column Name</param>
        /// <returns></returns>
        public static ILogicalOperators And(this IComparisonOperators comparisonOperators, string tableAlias, string column)
            => comparisonOperators is ILogicalOperators command ? command.And(tableAlias, column) : null;

        /// <summary>
        /// Add Or Comparison Operator to query
        /// </summary>
        /// <param name="comparisonOperators">Comparison Operators instance</param>
        /// <param name="column">Column Name</param>
        /// <returns></returns>
        public static ILogicalOperators Or(this IComparisonOperators comparisonOperators, string column)
            => comparisonOperators is ILogicalOperators command ? command.Or(column) : null;

        /// <summary>
        /// Add Or Comparison Operator to query
        /// </summary>
        /// <param name="comparisonOperators">Comparison Operators instance</param>
        /// <param name="tableAlias">Table Alias</param>
        /// <param name="column">Column Name</param>
        /// <returns></returns>
        public static ILogicalOperators Or(this IComparisonOperators comparisonOperators, string tableAlias, string column)
            => comparisonOperators is ILogicalOperators command ? command.Or(tableAlias, column) : null;

        /// <summary>
        /// Add Group by to query
        /// </summary>
        /// <param name="comparisonOperators">ComparisonOperators command stance</param>
        /// <param name="column">column used on group</param>
        public static IGrouping GroupBy(this IComparisonOperators comparisonOperators, string column)
             => comparisonOperators is IGrouping command ? command.GroupBy(column) : null;
    }
}
