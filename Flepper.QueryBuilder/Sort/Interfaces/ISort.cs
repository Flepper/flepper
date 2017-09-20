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
        ISort OrderBy(string column);

        /// <summary>
        /// OrderBy Contract
        /// </summary>
        /// <param name="tableAlias">Table Alias</param>
        /// <param name="column">Column Name</param>
        /// <returns></returns>
        ISort OrderBy(string tableAlias, string column);

        /// <summary>
        /// OrderBy Contract
        /// </summary>
        /// <param name="column">Column</param>
        /// <returns></returns>
        ISort OrderByDescending(string column);

        /// <summary>
        /// OrderBy Contract
        /// </summary>
        /// <param name="tableAlias">Table Alias</param>
        /// <param name="column">Column Name</param>
        /// <returns></returns>
        ISort OrderByDescending(string tableAlias, string column);
    }
}