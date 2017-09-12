
namespace Flepper.QueryBuilder
{
    public static class OnOperatorExtensions
    {
        public static IJoinComparisonOperators EqualTo(this IIOnOperator onOperator, string tableAlias, string column)
            => onOperator.To<JoinComparisonOperators>().Equal(tableAlias, column);

        public static IJoinComparisonOperators NotEqualTo(this IIOnOperator onOperator, string tableAlias, string column)
            => onOperator.To<JoinComparisonOperators>().NotEqual(tableAlias, column);
    }
}
