namespace Flepper.QueryBuilder
{
    /// <summary>
    /// Logical Operator Interface
    /// </summary>
    public interface ILogicalOperators : IQueryCommand
    {
        /// <summary>
        /// And Logical Operator contract
        /// </summary>
        /// <param name="column">Column name</param>
        /// <returns></returns>
        ILogicalOperators And(string column);

        /// <summary>
        /// And Logical Operator contract
        /// </summary>
        /// <param name="tableAlias">Table Alias</param>
        /// <param name="column">Column name</param>
        /// <returns></returns>
        ILogicalOperators And(string tableAlias, string column);

        /// <summary>
        /// Or Logical Operator contract
        /// </summary>
        /// <param name="column">Column name</param>
        /// <returns></returns>
        ILogicalOperators Or(string column);

        /// <summary>
        /// Or Logical Operator contract
        /// </summary>
        /// <param name="tableAlias">Table Alias</param>
        /// <param name="column">Column name</param>
        /// <returns></returns>
        ILogicalOperators Or(string tableAlias, string column);
    }
}