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
            => joinComparisonOperators is IWhereFilter command ? command.Where(field) : null;

        /// <summary>
        /// Add Where to query
        /// </summary>
        /// <param name="joinComparisonOperators">Join Comparison Operator instance</param>
        /// <param name="tableAlias">Table Alias</param>
        /// <param name="field">Column Name</param>
        /// <returns></returns>
        public static IWhereFilter Where(this IJoinComparisonOperators joinComparisonOperators, string tableAlias, string field)
            => joinComparisonOperators is IWhereFilter command ? command.Where(tableAlias, field) : null;

        /// <summary>
        /// Add Inner Join Operator to query
        /// </summary>
        /// <param name="joinComparisonOperators">Join Comparison Operator instance</param>
        /// <param name="table">Table Name</param>
        /// <returns></returns>
        public static IJoin InnerJoin(this IJoinComparisonOperators joinComparisonOperators, string table)
            => joinComparisonOperators is IJoin command ? command.InnerJoin(table) : null;

        /// <summary>
        /// Add Left Join Operator to query
        /// </summary>
        /// <param name="joinComparisonOperators">Join Comparison Operator instance</param>
        /// <param name="table">Table Name</param>
        /// <returns></returns>
        public static IJoin LeftJoin(this IJoinComparisonOperators joinComparisonOperators, string table)
            => joinComparisonOperators is IJoin command ? command.LeftJoin(table) : null;
    }
}
