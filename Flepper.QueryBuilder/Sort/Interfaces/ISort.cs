namespace Flepper.QueryBuilder
{
    /// <summary>
    /// OrderBy Sort Interface
    /// </summary>
    public interface ISort : IQueryCommand
    {
        /// <summary>
        /// OrderBy Contract
        /// </summary>
        /// <param name="column">Column</param>
        /// <returns></returns>
        ISortThen OrderBy(string column);

        /// <summary>
        /// OrderBy Contract
        /// </summary>
        /// <param name="tableAlias">Table Alias</param>
        /// <param name="column">Column Name</param>
        /// <returns></returns>
        ISortThen OrderBy(string tableAlias, string column);

        /// <summary>
        /// OrderBy Contract
        /// </summary>
        /// <param name="column">Column</param>
        /// <returns></returns>
        ISortThen OrderByDescending(string column);

        /// <summary>
        /// OrderBy Contract
        /// </summary>
        /// <param name="tableAlias">Table Alias</param>
        /// <param name="column">Column Name</param>
        /// <returns></returns>
        ISortThen OrderByDescending(string tableAlias, string column);
    }
}