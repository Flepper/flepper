namespace Flepper.QueryBuilder
{
    /// <summary>
    /// Delete Command Interface
    /// </summary>
    public interface IDeleteCommand : IQueryCommand
    {
        /// <summary>
        /// Delete Command Contract
        /// </summary>
        /// <returns></returns>
        IDeleteCommand DeleteCommand();
    }
}
