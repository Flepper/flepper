namespace Flepper.QueryBuilder
{
    /// <summary>
    /// Join Comparison Operator Interface
    /// </summary>
    public interface IJoinComparisonOperators : IQueryCommand
    {
        /// <summary>
        /// Equal Comparison Operator Contract
        /// </summary>
        /// <param name="column">Column Name</param>
        /// <param name="tableAlias">Table alias</param>
        /// <returns></returns>
        IJoinComparisonOperators Equal(string column, string tableAlias);

        /// <summary>
        /// Not Equal Comparison Operator Contract
        /// </summary>
        /// <param name="column">Column Name</param>
        /// <param name="tableAlias">Table alias</param>
        /// <returns></returns>
        IJoinComparisonOperators NotEqual(string column, string tableAlias);
    }
}