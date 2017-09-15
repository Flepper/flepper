namespace Flepper.QueryBuilder
{
    /// <summary>
    /// Insert Command Interface
    /// </summary>
    public interface IInsertCommand : IQueryCommand
    {
        /// <summary>
        /// Insert Into Command contract
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        IInsertIntoCommand Into(string table);
    }
}
