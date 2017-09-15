namespace Flepper.QueryBuilder
{
    /// <summary>
    /// Alias Operator Interface
    /// </summary>
    public interface IAliasOperator : IQueryCommand
    {
        /// <summary>
        /// As Operator Alias
        /// </summary>
        /// <param name="alias">Table Alias</param>
        /// <returns></returns>
        IAliasOperator As(string alias);
    }
}