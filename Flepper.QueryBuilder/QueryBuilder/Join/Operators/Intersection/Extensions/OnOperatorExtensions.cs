
namespace Flepper.QueryBuilder
{
    public static class OnOperatorExtensions
    {
        public static IJoinComparisonOperators EqualTo(this IIOnOperator onOperator, string tableAlias, string column)
        {
            var joinComparisonOperator = JoinComparisonOperators.Create();

            joinComparisonOperator.Equal(tableAlias, column);

            return joinComparisonOperator;
        }

        public static IJoinComparisonOperators NotEqualTo(this IIOnOperator onOperator, string tableAlias, string column)
        {
            var joinComparisonOperator = JoinComparisonOperators.Create();

            joinComparisonOperator.NotEqual(tableAlias, column);

            return joinComparisonOperator;
        }
    }
}
