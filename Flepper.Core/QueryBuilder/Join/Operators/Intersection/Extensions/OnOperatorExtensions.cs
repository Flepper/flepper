
namespace Flepper.Core.QueryBuilder
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
