namespace Flepper.QueryBuilder
{
    /// <summary>
    /// Where Filter Interface
    /// </summary>
    public interface IWhereFilter : IQueryCommand, ISortCommand
    {
        /// <summary>
        /// Where Filter Contract
        /// </summary>
        /// <param name="field">Column Name</param>
        /// <returns></returns>
        IWhereFilter Where(string field);

        /// <summary>
        /// Where Filter Contract
        /// </summary>
        /// <param name="tableAlias">Table alias</param>
        /// <param name="field">Column Name</param>
        /// <returns></returns>
        IWhereFilter Where(string tableAlias, string field);
               
    }
}
