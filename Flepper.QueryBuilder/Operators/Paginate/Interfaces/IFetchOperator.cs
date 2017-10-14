namespace Flepper.QueryBuilder
{
    /// <summary>
    /// Fetch Operator Interface
    /// </summary>
    public interface IFetchOperator : IQueryCommand
    {
        /// <summary>
        /// Fetch Operator Contract
        /// </summary>
        /// <param name="numberOfRows">Number of rows returned</param>
        /// <returns></returns>
        IFetchOperator Fetch(int numberOfRows);
    }
}