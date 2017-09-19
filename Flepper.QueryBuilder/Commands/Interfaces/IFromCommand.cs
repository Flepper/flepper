namespace Flepper.QueryBuilder
{
    /// <summary>
    /// From Command Interface
    /// </summary>
    public interface IFromCommand : IQueryCommand
    {
        /// <summary>
        /// From Command Contract
        /// </summary>
        /// <param name="schema">Schema name</param>
        /// <param name="table">Table name</param>
        /// <returns></returns>
        IFromCommand FromCommand(string schema, string table);

        /// <summary>
        /// From Command Contract
        /// </summary>
        /// <param name="table">Table name</param>
        /// <returns></returns>
        IFromCommand FromCommand(string table);
    }
}