
namespace Flepper.Core.QueryBuilder
{
    public static class WhereFilterExtensions
    {
        public static IComparisonOperators Equal(this IWhereFilter whereFilter, string value)
        {
            var equalCompareOperator = ComparisonOperators.Create();

            equalCompareOperator.Equal(value);

            return equalCompareOperator;
        }

        public static IComparisonOperators Equal(this IWhereFilter whereFilter, int value)
        {
            var equalCompareOperator = ComparisonOperators.Create();

            equalCompareOperator.Equal(value);

            return equalCompareOperator;
        }
    }
}
