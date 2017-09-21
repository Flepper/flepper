using Flepper.QueryBuilder.Operators.SqlFunctions;

namespace Flepper.QueryBuilder
{
    /// <summary>
    /// Flepper Query Builder Function public API
    /// </summary>
    public static class FlepperQueryFunction
    {
        /// <summary>
        /// Count Sql Function
        /// </summary>
        /// <param name="column"></param>
        /// <param name="alias"></param>
        /// <returns></returns>
        public static SqlFunction Count(string column, string alias)
            => new CountOperator(column,alias);
    }
}
