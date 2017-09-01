
namespace Flepper.Core.QueryBuilder
{
    public static class LogicalOperatorsExtensions
    {
        public static IComparisonOperators Equal(this ILogicalOperators logicalOperators, string value)
        {
            var equalCompareOperator = ComparisonOperators.Create();

            equalCompareOperator.Equal(value);

            return equalCompareOperator;
        }

        public static IComparisonOperators Equal(this ILogicalOperators logicalOperators, int value)
        {
            var equalCompareOperator = ComparisonOperators.Create();

            equalCompareOperator.Equal(value);

            return equalCompareOperator;
        }
    }
}
