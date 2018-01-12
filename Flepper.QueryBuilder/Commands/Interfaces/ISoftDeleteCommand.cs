namespace Flepper.QueryBuilder
{
    /// <summary>
    /// ISoftDeleteCommand Interface
    /// </summary>
    public interface ISoftDeleteCommand : IQueryCommand
    {

        /// <summary>
        /// SoftDeleteCommand Method
        /// </summary>
        /// <typeparam name="T">Type of class that contains the delete flag</typeparam>
        /// <returns></returns>
        ISoftDeleteCommand SoftDeleteCommand<T>(string table) where T : class;
    }
}
