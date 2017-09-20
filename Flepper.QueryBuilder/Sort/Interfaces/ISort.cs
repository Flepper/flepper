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
        /// <param name="descending">Descending</param>
        /// <returns></returns>
        ISort OrderBy(string column, bool descending = false);

        /// <summary>
        /// OrderBy Contract
        /// </summary>
        /// <param name="tableAlias">Table Alias</param>
        /// <param name="column">Column Name</param>
         /// <param name="descending">Descending</param>
        /// <returns></returns>
        ISort OrderBy(string tableAlias, string column, bool descending = false);    
    }
}
