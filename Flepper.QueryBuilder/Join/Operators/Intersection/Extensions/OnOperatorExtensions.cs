
namespace Flepper.QueryBuilder
{
    /// <summary>
    /// On Operator Extensions
    /// </summary>
    public static class OnOperatorExtensions
    {
        /// <summary>
        /// Add Equal Operator to query
        /// </summary>
        /// <param name="onOperator">On Operator instance</param>
        /// <param name="tableAlias">Table Alias</param>
        /// <param name="column">Column Name</param>
        /// <returns></returns>
        public static IJoinComparisonOperators EqualTo(this IOnOperator onOperator, string tableAlias, string column)
            => onOperator.To<JoinComparisonOperators>().Equal(tableAlias, column);

        /// <summary>
        /// Add Mot Equal Operator to query
        /// </summary>
        /// <param name="onOperator">On Operator instance</param>
        /// <param name="tableAlias">Table Alias</param>
        /// <param name="column">Column Name</param>
        /// <returns></returns>
        public static IJoinComparisonOperators NotEqualTo(this IOnOperator onOperator, string tableAlias, string column)
            => onOperator.To<JoinComparisonOperators>().NotEqual(tableAlias, column);
    }
}
