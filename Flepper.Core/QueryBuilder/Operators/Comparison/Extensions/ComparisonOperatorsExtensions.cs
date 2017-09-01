
namespace Flepper.Core.QueryBuilder
{
    public static class ComparisonOperatorsExtensions
    {
        public static ILogicalOperators And(this IComparisonOperators comparisonOperators, string column)
        {
            var logicalOperators = new LogicalOperators();

            logicalOperators.And(column);

            return logicalOperators;
        }

        public static ILogicalOperators Or(this IComparisonOperators comparisonOperators, string column)
        {
            var logicalOperators = new LogicalOperators();

            logicalOperators.Or(column);

            return logicalOperators;
        }
    }
}
