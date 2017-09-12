
namespace Flepper.QueryBuilder
{
    public static class ComparisonOperatorsExtensions
    {
        public static ILogicalOperators And(this IComparisonOperators comparisonOperators, string column)
            => comparisonOperators.To<LogicalOperators>().And(column);

        public static ILogicalOperators Or(this IComparisonOperators comparisonOperators, string column)
            => comparisonOperators.To<LogicalOperators>().Or(column);
    }
}
