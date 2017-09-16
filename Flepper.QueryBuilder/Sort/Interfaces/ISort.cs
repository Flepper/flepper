namespace Flepper.QueryBuilder
{
    /// <summary>
    /// OrderBy Sort Interface
    /// </summary>
    public interface ISort : IQueryCommand
    {
        /// <summary>
        /// OrderBy Contract
        /// </summary>
        /// <param name="columns">Columns</param>
        /// <returns></returns>
        ISort OrderBy(string[] columns);

        /// <summary>
        /// OrderBy Descending Contract
        /// </summary>
        /// <param name="columns">Columns</param>
        /// <returns></returns>
        ISort OrderByDesc(string[] columns);
    }
}
