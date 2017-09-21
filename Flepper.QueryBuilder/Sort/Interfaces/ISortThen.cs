namespace Flepper.QueryBuilder
{
    /// <summary>
    /// OrderBy Sort Interface
    /// </summary>
    public interface ISortThen : IQueryCommand
    {
        /// <summary>
        /// OrderBy Contract
        /// </summary>
        /// <param name="column">Column</param>
        /// <returns></returns>
        ISortThen ThenBy(string column);

        /// <summary>
        /// OrderBy Contract
        /// </summary>
        /// <param name="tableAlias">Table Alias</param>
        /// <param name="column">Column Name</param>
        /// <returns></returns>
        ISortThen ThenBy(string tableAlias, string column);

        /// <summary>
        /// OrderBy Contract
        /// </summary>
        /// <param name="column">Column</param>
        /// <returns></returns>
        ISortThen ThenByDescending(string column);

        /// <summary>
        /// OrderBy Contract
        /// </summary>
        /// <param name="tableAlias">Table Alias</param>
        /// <param name="column">Column Name</param>
        /// <returns></returns>
        ISortThen ThenByDescending(string tableAlias, string column);
    }
}