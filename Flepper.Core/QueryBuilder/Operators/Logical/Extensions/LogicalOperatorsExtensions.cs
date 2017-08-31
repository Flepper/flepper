using Flepper.Core.QueryBuilder.Operators.Comparison;
using Flepper.Core.QueryBuilder.Operators.Comparison.Interfaces;
using Flepper.Core.QueryBuilder.Operators.Logical.Interfaces;

namespace Flepper.Core.QueryBuilder.Operators.Logical.Extensions
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
