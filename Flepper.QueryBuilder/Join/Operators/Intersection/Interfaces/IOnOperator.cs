namespace Flepper.QueryBuilder
{
    /// <summary>
    /// On Operator Interface
    /// </summary>
    public interface IOnOperator : IQueryCommand
    {
        /// <summary>
        /// On Operator Contract
        /// </summary>
        /// <param name="tableAlias">Table Alias</param>
        /// <param name="column">Column Name</param>
        /// <returns></returns>
        IOnOperator On(string tableAlias, string column);
    }
}
