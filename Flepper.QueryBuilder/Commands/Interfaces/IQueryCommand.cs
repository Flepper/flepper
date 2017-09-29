namespace Flepper.QueryBuilder
{
    /// <summary>
    /// Query Command Interface
    /// </summary>
    public interface IQueryCommand
    {
        /// <summary>
        /// Build a query
        /// </summary>
        /// <returns></returns>
        string Build();

        /// <summary>
        /// Build a query with parameters
        /// </summary>
        /// <returns></returns>
        QueryResult BuildWithParameters();
        
    }
}
