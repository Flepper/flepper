using Flepper.Core.QueryBuilder.Operators.Comparison.Interfaces;
using Flepper.Core.QueryBuilder.Operators.Logical;
using Flepper.Core.QueryBuilder.Operators.Logical.Interfaces;

namespace Flepper.Core.QueryBuilder.Operators.Comparison.Extensions
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
