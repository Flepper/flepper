namespace Flepper.QueryBuilder.Operators.Grouping.Interfaces
{
    /// <summary>
    /// Group By Interface
    /// </summary>
    public interface IGrouping:IQueryCommand
    {
        /// <summary>
        /// Group select statement by a column
        /// </summary>
        /// <param name="column">Grouped Column</param>
        /// <returns></returns>
        IGrouping GroupBy(string column);
    }
}
