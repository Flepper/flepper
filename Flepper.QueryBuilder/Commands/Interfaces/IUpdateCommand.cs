namespace Flepper.QueryBuilder
{
    /// <summary>
    /// Update Command Interface
    /// </summary>
    public interface IUpdateCommand : IQueryCommand
    {
        /// <summary>
        /// Update Command Contract
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        IUpdateCommand UpdateCommand(string table);
    }
}