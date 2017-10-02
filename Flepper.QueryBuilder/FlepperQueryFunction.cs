using Flepper.QueryBuilder.Base;
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
        /// <param name="column">column used by count function</param>
        /// <param name="alias">column alias</param>
        /// <returns>string statement</returns>
        public static SqlColumn Count(string column, string alias)
            => new CountOperator(column, alias);

        /// <summary>
        /// Min Sql Function
        /// </summary>
        /// <param name="column">column used by min function</param>
        /// <param name="alias">column alias</param>
        /// <returns>sring statement</returns>
        public static SqlColumn Min(string column, string alias)
            => new MinOperator(column, alias);

        /// <summary>
        /// Max Sql Function
        /// </summary>
        /// <param name="column">column used by max function</param>
        /// <param name="alias">column alias</param>
        /// <returns>sring statement</returns>
        public static SqlColumn Max(string column, string alias)
            => new MaxOperator(column, alias);
    }
}
