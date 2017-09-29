namespace Flepper.QueryBuilder
{
    /// <summary>
    /// Top Command Interface
    /// </summary>
    public interface ITopCommand : IQueryCommand
    {
        /// <summary>
        /// Top Command Contract
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        ITopCommand TopCommand(int size = 1);
    }
}