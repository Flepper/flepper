
namespace Flepper.QueryBuilder
{
    public static class LogicalOperatorsExtensions
    {
        public static IComparisonOperators EqualTo(this ILogicalOperators logicalOperators, string value)
        {
            var equalCompareOperator = ComparisonOperators.Create();

            equalCompareOperator.EqualTo(value);

            return equalCompareOperator;
        }

        public static IComparisonOperators EqualTo(this ILogicalOperators logicalOperators, int value)
        {
            var equalCompareOperator = ComparisonOperators.Create();

            equalCompareOperator.EqualTo(value);

            return equalCompareOperator;
        }

        public static IComparisonOperators GreaterThan(this ILogicalOperators logicalOperators, int value)
        {
            var equalCompareOperator = ComparisonOperators.Create();

            equalCompareOperator.GreaterThan(value);

            return equalCompareOperator;
        }

        public static IComparisonOperators LessThan(this ILogicalOperators logicalOperators, int value)
        {
            var equalCompareOperator = ComparisonOperators.Create();

            equalCompareOperator.LessThan(value);

            return equalCompareOperator;
        }

        public static IComparisonOperators GreaterThanOrEqualTo(this ILogicalOperators logicalOperators, int value)
        {
            var equalCompareOperator = ComparisonOperators.Create();

            equalCompareOperator.GreaterThanOrEqualTo(value);

            return equalCompareOperator;
        }

        public static IComparisonOperators LessThanOrEqualTo(this ILogicalOperators logicalOperators, int value)
        {
            var equalCompareOperator = ComparisonOperators.Create();

            equalCompareOperator.LessThanOrEqualTo(value);

            return equalCompareOperator;
        }

        public static IComparisonOperators NotEqualTo(this ILogicalOperators logicalOperators, int value)
        {
            var equalCompareOperator = ComparisonOperators.Create();

            equalCompareOperator.NotEqualTo(value);

            return equalCompareOperator;
        }

        public static IComparisonOperators NotEqualTo(this ILogicalOperators logicalOperators, string value)
        {
            var equalCompareOperator = ComparisonOperators.Create();

            equalCompareOperator.NotEqualTo(value);

            return equalCompareOperator;
        }
    }
}
