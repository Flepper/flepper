namespace Flepper.QueryBuilder
{
    /// <summary>
    /// Join Interface
    /// </summary>
    public interface IJoin : IQueryCommand
    {
        /// <summary>
        /// Inner Join Contract
        /// </summary>
        /// <param name="table">Table name</param>
        /// <returns></returns>
        IJoin InnerJoin(string table);

        /// <summary>
        /// Left Join Contract
        /// </summary>
        /// <param name="table">Table name</param>
        /// <returns></returns>
        IJoin LeftJoin(string table);
    }
}
