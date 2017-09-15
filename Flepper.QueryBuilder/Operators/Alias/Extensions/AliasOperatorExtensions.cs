namespace Flepper.QueryBuilder
{
    /// <summary>
    /// Alias Operator Extensions
    /// </summary>
    public static class AliasOperatorExtensions
    {
        /// <summary>
        /// Add Where Operator to query
        /// </summary>
        /// <param name="aliasOperator">Alias Operator instance</param>
        /// <param name="field">Column Name</param>
        /// <returns></returns>
        public static IWhereFilter Where(this IAliasOperator aliasOperator, string field)
            => aliasOperator.To<WhereFilter>().Where(field);

        /// <summary>
        /// Add Inner Join Operator to query
        /// </summary>
        /// <param name="aliasOperator">Alias Operator instance</param>
        /// <param name="table">Column Name</param>
        /// <returns></returns>
        public static IJoin InnerJoin(this IAliasOperator aliasOperator, string table)
            => aliasOperator.To<Join>().InnerJoin(table);

        /// <summary>
        /// Add Left Join Operator to query
        /// </summary>
        /// <param name="aliasOperator">Alias Operator instance</param>
        /// <param name="table">Column Name</param>
        /// <returns></returns>
        public static IJoin LeftJoin(this IAliasOperator aliasOperator, string table)
            => aliasOperator.To<Join>().LeftJoin(table);

        /// <summary>
        /// Add On Operator to query
        /// </summary>
        /// <param name="aliasOperator">Alias Operator instance</param>
        /// <param name="tableAlias">Table Alias</param>
        /// <param name="column">Column Name</param>
        /// <returns></returns>
        public static IOnOperator On(this IAliasOperator aliasOperator, string tableAlias, string column)
            => aliasOperator.To<OnOperator>().On(tableAlias, column);
    }
}
