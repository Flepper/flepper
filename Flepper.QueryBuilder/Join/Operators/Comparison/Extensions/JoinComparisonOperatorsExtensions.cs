namespace Flepper.QueryBuilder
{
    /// <summary>
    /// Join Comparison Operator Extensions
    /// </summary>
    public static class JoinComparisonOperatorsExtensions
    {
        /// <summary>
        /// Add Where to query
        /// </summary>
        /// <param name="joinComparisonOperators">Join Comparison Operator instance</param>
        /// <param name="field">Column Name</param>
        /// <returns></returns>
        public static IWhereFilter Where(this IJoinComparisonOperators joinComparisonOperators, string field)
            => joinComparisonOperators.To<WhereFilter>().Where(field);

        /// <summary>
        /// Add Where to query
        /// </summary>
        /// <param name="joinComparisonOperators">Join Comparison Operator instance</param>
        /// <param name="tableAlias">Table Alias</param>
        /// <param name="field">Column Name</param>
        /// <returns></returns>
        public static IWhereFilter Where(this IJoinComparisonOperators joinComparisonOperators, string tableAlias, string field)
            => joinComparisonOperators.To<WhereFilter>().Where(tableAlias, field);
    }
}
