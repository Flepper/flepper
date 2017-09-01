using Flepper.Core.QueryBuilder.Join.Operators.Comparison;
using Flepper.Core.QueryBuilder.Join.Operators.Comparison.Interfaces;
using Flepper.Core.QueryBuilder.Join.Operators.Intersection.Interfaces;

namespace Flepper.Core.QueryBuilder.Join.Operators.Intersection.Extensions
{
    public static class OnOperatorExtensions
    {
        public static IJoinComparisonOperators Equal(this IIOnOperator onOperator, string tableAlias, string column)
        {
            var joinComparisonOperator = JoinComparisonOperators.Create();

            joinComparisonOperator.Equal(tableAlias, column);

            return joinComparisonOperator;
        }

        public static IJoinComparisonOperators NotEqual(this IIOnOperator onOperator, string tableAlias, string column)
        {
            var joinComparisonOperator = JoinComparisonOperators.Create();

            joinComparisonOperator.NotEqual(tableAlias, column);

            return joinComparisonOperator;
        }
    }
}
