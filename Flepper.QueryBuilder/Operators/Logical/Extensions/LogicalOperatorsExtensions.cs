
namespace Flepper.QueryBuilder
{
    public static class LogicalOperatorsExtensions
    {
        public static IComparisonOperators EqualTo(this ILogicalOperators logicalOperators, string value)
            => logicalOperators.To<ComparisonOperators>().EqualTo(value);

        public static IComparisonOperators EqualTo(this ILogicalOperators logicalOperators, int value)
            => logicalOperators.To<ComparisonOperators>().EqualTo(value);

        public static IComparisonOperators GreaterThan(this ILogicalOperators logicalOperators, int value)
            => logicalOperators.To<ComparisonOperators>().GreaterThan(value);

        public static IComparisonOperators LessThan(this ILogicalOperators logicalOperators, int value)
            => logicalOperators.To<ComparisonOperators>().LessThan(value);

        public static IComparisonOperators GreaterThanOrEqualTo(this ILogicalOperators logicalOperators, int value)
            => logicalOperators.To<ComparisonOperators>().GreaterThanOrEqualTo(value);

        public static IComparisonOperators LessThanOrEqualTo(this ILogicalOperators logicalOperators, int value)
            => logicalOperators.To<ComparisonOperators>().LessThanOrEqualTo(value);

        public static IComparisonOperators NotEqualTo(this ILogicalOperators logicalOperators, int value)
            => logicalOperators.To<ComparisonOperators>().NotEqualTo(value);

        public static IComparisonOperators NotEqualTo(this ILogicalOperators logicalOperators, string value)
            => logicalOperators.To<ComparisonOperators>().NotEqualTo(value);
    }
}
