
namespace Flepper.Core.QueryBuilder
{
    public static class WhereFilterExtensions
    {
        public static IComparisonOperators EqualTo(this IWhereFilter whereFilter, string value)
        {
            var equalCompareOperator = ComparisonOperators.Create();

            equalCompareOperator.EqualTo(value);

            return equalCompareOperator;
        }

        public static IComparisonOperators EqualTo(this IWhereFilter whereFilter, int value)
        {
            var equalCompareOperator = ComparisonOperators.Create();

            equalCompareOperator.EqualTo(value);

            return equalCompareOperator;
        }

        public static IComparisonOperators GreaterThan(this IWhereFilter whereFilter, int value)
        {
            var equalCompareOperator = ComparisonOperators.Create();

            equalCompareOperator.GreaterThan(value);

            return equalCompareOperator;
        }

        public static IComparisonOperators LessThan(this IWhereFilter whereFilter, int value)
        {
            var equalCompareOperator = ComparisonOperators.Create();

            equalCompareOperator.LessThan(value);

            return equalCompareOperator;
        }

        public static IComparisonOperators GreaterThanOrEqualTo(this IWhereFilter whereFilter, int value)
        {
            var equalCompareOperator = ComparisonOperators.Create();

            equalCompareOperator.GreaterThanOrEqualTo(value);

            return equalCompareOperator;
        }

        public static IComparisonOperators LessThanOrEqualTo(this IWhereFilter whereFilter, int value)
        {
            var equalCompareOperator = ComparisonOperators.Create();

            equalCompareOperator.LessThanOrEqualTo(value);

            return equalCompareOperator;
        }

        public static IComparisonOperators NotEqualTo(this IWhereFilter whereFilter, int value)
        {
            var equalCompareOperator = ComparisonOperators.Create();

            equalCompareOperator.NotEqualTo(value);

            return equalCompareOperator;
        }

        public static IComparisonOperators NotEqualTo(this IWhereFilter whereFilter, string value)
        {
            var equalCompareOperator = ComparisonOperators.Create();

            equalCompareOperator.NotEqualTo(value);

            return equalCompareOperator;
        }
    }
}
